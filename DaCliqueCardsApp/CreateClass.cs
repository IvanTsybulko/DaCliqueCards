using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaCliqueCardsApp
{
    public partial class CreateClass : Form
    {
        List<Student> students = new List<Student>();
        List<Place> places = new List<Place>();
        List<ClassType> types = new List<ClassType>();


        public CreateClass()
        {
            InitializeComponent();
        }

        private void CheckCards_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            places = db.GetPlaces();

            PlacesComboBox.DataSource = places;
            PlacesComboBox.DisplayMember = "Name";

            types = db.GetClassTypes();

            ClassTypesComboBox.DataSource = types;
            ClassTypesComboBox.DisplayMember = "ClassTypeName";

            students = db.GetStudents(StudentNameText.Text);
            updateStudentListBox();
        }

        private void updateStudentListBox()
        {
            students = students.Where(s => s.HasActiveCard()).ToList();
            StudentsCheckListBox.DataSource = students;
            StudentsCheckListBox.DisplayMember = "FullInfo";
        }

        private void SearchStudentButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            students = db.GetStudents(StudentNameText.Text);
            updateStudentListBox();
        }

        private void CreateClassButton_Click(object sender, EventArgs e)
        {
            ClassType classType = types[ClassTypesComboBox.SelectedIndex];
            TimeSpan classDuration = ClassDurationDateTimePicker.Value.TimeOfDay;
            int atendancesCount = (int)AtendancesCountNumeric.Value;
            Place place = places[PlacesComboBox.SelectedIndex];
            DateTime date = ClassDateDateTimePicker.Value;

            Class newClass = new Class(classType.Id, classDuration, atendancesCount, place.Id, CurrentCoach.CurrCoach.Id, date);

            DataAccess db = new DataAccess();
            db.InsertClass(newClass);

            List<Class> classes = new List<Class>();
            classes = db.GetClasses();

            newClass = classes.Where(x => x.CoachId == CurrentCoach.CurrCoach.Id).Last();

            List<Student> checkedStudents = new List<Student>();
            checkedStudents = StudentsCheckListBox.CheckedItems.Cast<Student>().ToList();

            foreach (Student student in checkedStudents)
            {
                try
                {
                    List<Card> studentCards = db.GetStudentCards(student.Id);

                    Card card = studentCards.Last();

                    db.UpadteCardClassesLeft(card.Id, (card.ClassesLeft - (int)AtendancesCountNumeric.Value));

                    ClassCard cc = new ClassCard(newClass.Id, card.Id);
                    db.InsertClassCard(cc);
                }
                catch (Exception)
                {

                    MessageBox.Show($"Student {student.FirstName} {student.LastName} does not have an active card! ");
                }

            }

            updateStudentListBox();
        }
    }
}
