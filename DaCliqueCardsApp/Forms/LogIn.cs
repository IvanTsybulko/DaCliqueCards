using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DaCliqueCardsApp;

namespace DaCliqueCardsApp
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string username = UsernameText.Text;
            string password = PasswordText.Text;

            DataAccess db = new DataAccess();
            try
            {
                Coach coach = db.LogInCoach(username, password);

                if (coach != null)
                {
                    CurrentCoach.CurrCoach = coach;
                    Menu menu = new Menu();
                    menu.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Wrong Credentials!");
            }
        }

        private void PasswordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                LogInButton.PerformClick();
            }
        }

        private void UsernameText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                PasswordText.Focus();
            }
        }
    }
}
