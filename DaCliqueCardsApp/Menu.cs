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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void NewCardButton_Click(object sender, EventArgs e)
        {
            CreateCard createCard = new CreateCard();
            createCard.Show();
        }

        private void NewStudentButton_Click(object sender, EventArgs e)
        {
            NewStudent newStudent = new NewStudent();
            newStudent.Show();
        }

        private void CreateClassButton_Click_1(object sender, EventArgs e)
        {
            CreateClass createTraining = new CreateClass();
            createTraining.Show();
        }

        private void CheckCardsButton_Click(object sender, EventArgs e)
        {
            CheckCards checkCards = new CheckCards();
            checkCards.Show(); 
        }
    }
}
