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
    public partial class CreateCard : Form
    {
        List<Student> students = new List<Student>();
        List<CardExample> cardExamples = new List<CardExample>();


        public CreateCard()
        {
            InitializeComponent();
            updateStudentsListBoc();
        }

        private void updateStudentsListBoc()
        {
            students = students.Where(s => s.HasActiveCard() == false).ToList();//Checks which students dont have a card
            StudentsListBox.DataSource = students;
            StudentsListBox.DisplayMember = "FullInfo";
        }

        private void searchStudentButton_Click(object sender, EventArgs e)//Displays all students that dont have a card
        {
            DataAccess db = new DataAccess();
            students = db.GetStudents(lastNameText.Text);
            updateStudentsListBoc();
        }

        private void LoadCardTypes()// Displays all the card variations in the drop box for card types
        {
            DataAccess db = new DataAccess();
            cardExamples = db.GetCardExamples();
            CardTypesListBox.DataSource = cardExamples;
            CardTypesListBox.DisplayMember = "FullInfo";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            searchStudentButton.PerformClick();
            LoadCardTypes();
        }

        private void lastNameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchStudentButton.PerformClick();
            }
        }

        private int CheckLastCardForNegative(int studentId)
        {
            DataAccess db = new DataAccess();

            List<Card> cards = new List<Card>();

            cards = db.GetStudentCards(studentId);

            if (cards.Count == 0)
            {
                return 0;
            }

            Card lastCard = cards.Last();

            return lastCard.ClassesLeft;
        }

        private void CreateCardButton_Click(object sender, EventArgs e)
        {
            try
            {
                int exampleCardSelectedIndex = CardTypesListBox.SelectedIndex;
                CardExample cardExample = cardExamples[exampleCardSelectedIndex];

                int studentSelectedIndex = StudentsListBox.SelectedIndex;
                Student student = students[studentSelectedIndex];

                DateTime startingDate = StartingDateDateTimePicker.Value;
                DateTime endDate = startingDate.AddDays(40);

                int numberOfClasses = cardExample.NumberOfClasses + CheckLastCardForNegative(student.Id);



                Card card = new Card(cardExample.Id, startingDate, endDate,
                numberOfClasses, student.Id, CurrentCoach.CurrCoach.Id);

                DataAccess db = new DataAccess();
                db.InsertCard(card);
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong while creating card!");
            }
        }
    }
}
