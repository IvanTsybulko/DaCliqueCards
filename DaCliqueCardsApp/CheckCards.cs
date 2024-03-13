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
    public partial class CheckCards : Form
    {
        List<Class> classes = new List<Class>();
        List<Student> students = new List<Student>();
        public CheckCards()
        {
            InitializeComponent();
        }

        private void updateStudentListBox()
        {
            Class newClass = (Class)ChooseClassComboBox.SelectedValue;
            DataAccess db = new DataAccess();
            students = db.GetStudentsNotInClass(newClass.Id);
            students = students.Where(s => s.FullInfo.ToLower().Contains(StudentNameText.Text.ToLower())).ToList();
            students = students.OrderBy(s => s.FullInfo).ToList();

            students = students.Where(s => s.HasActiveCard()).ToList();
           
            StudentsCheckListBox.DataSource = students;
            StudentsCheckListBox.DisplayMember = "FullInfo";
        }

        private void CheckCards_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            classes = db.GetClasses(CurrentCoach.CurrCoach.Id).ToList();

            classes = classes.Where(c => c.Date <  DateTime.Now).ToList();
            classes = classes.OrderByDescending(c => c.Date).ToList();

            ChooseClassComboBox.DataSource = classes;
            ChooseClassComboBox.DisplayMember = "FullInfo";

            updateStudentListBox();

        }

        private void SearchStudentButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            students = db.GetStudents(StudentNameText.Text);
            updateStudentListBox();
        }

        private void CheckCardsButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            List<Student> checkedStudents = new List<Student>();
            checkedStudents = StudentsCheckListBox.CheckedItems.Cast<Student>().ToList();

            foreach (Student student in checkedStudents)
            {
                try
                {
                    Class newClass = (Class)ChooseClassComboBox.SelectedValue;
                    List<Card> studentCards = db.GetStudentCards(student.Id);

                    Card card = studentCards.Last();

                    db.UpadteCardClassesLeft(card.Id, (card.ClassesLeft - newClass.AtendancesCount));

                    ClassCard cc = new ClassCard(newClass.Id, card.Id);
                    db.InsertClassCard(cc);
                    updateStudentListBox();
                }
                catch (Exception)
                {

                    MessageBox.Show($"Student {student.FirstName} {student.LastName} does not have an active card! ");
                }

            }
        }

        private void ChooseClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateStudentListBox();
        }
    }
}
