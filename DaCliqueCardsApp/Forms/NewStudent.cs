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
    public partial class NewStudent : Form
    {
        public NewStudent()
        {
            InitializeComponent();
        }

        private void CreateStudentButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertStudent(FirstNameText.Text, LastNameText.Text, int.Parse(AgeText.Text), PhoneNumberText.Text);
            FirstNameText.Text = "";
            LastNameText.Text = "";
            AgeText.Text = "";
            PhoneNumberText.Text = "";

            MessageBox.Show("Student was successfully created!");
        }

        private void FirstNameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                LastNameText.Focus();
            }
        }

        private void LastNameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                AgeText.Focus();
            }
        }

        private void AgeText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                PhoneNumberText.Focus();
            }
        }

        private void PhoneNumberText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                CreateStudentButton.PerformClick();
            }
        }
    }
}
