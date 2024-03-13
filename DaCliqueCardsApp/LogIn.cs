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
                    menu.Show();
                }
            }
            catch
            {
                MessageBox.Show("Wrong Credentials!");
            }
        }
    }
}
