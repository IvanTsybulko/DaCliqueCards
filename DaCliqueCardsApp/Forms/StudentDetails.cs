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
    public partial class StudentDetails : Form
    {
        List<Card> cards = new List<Card>();
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            Student currStudent = CurrentStudent.CurrStudent;

            NameLabel.Text = $"Name: {currStudent.FirstName}  {currStudent.LastName}";
            AgeLabel.Text = $"Age: {currStudent.Age}";
            PhoneNumberLabel.Text = $"Phone Number: {currStudent.PhoneNumber}";
            ActiveCardLabel.Text = $"Active Card: {currStudent.HasActiveCard()}";

            DataAccess db = new DataAccess();
            cards = db.GetStudentCards(currStudent.Id);
            cards.Reverse();
            CardsListBox.DataSource = cards;
            CardsListBox.DisplayMember = "FullInfo";
        }

        private void CardDetailsButton_Click(object sender, EventArgs e)
        {
            Card cd = (Card)CardsListBox.SelectedItem;
            CurrentCard.CurrCard = cd;

            CardDetails cardDetails = new CardDetails();
            cardDetails.Show();
        }
    }
}
