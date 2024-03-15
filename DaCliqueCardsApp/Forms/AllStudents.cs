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
    public partial class AllStudents : Form
    {
        List<Student> students = new List<Student>();

        public AllStudents()
        {
            InitializeComponent();
        }

        private void updateStudentsListBoc()
        {
            StudentsListBox.DataSource = students;
            StudentsListBox.DisplayMember = "FullInfo";
        }

        private void AllStudents_Load(object sender, EventArgs e)
        {
            SearchStudentButton.PerformClick();
        }

        private void SearchStudentButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            students = db.GetStudents(NameTextBox.Text);
            updateStudentsListBoc();
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            StudentDetails sd = new StudentDetails();
            Student currStudent = (Student)StudentsListBox.SelectedItem;
            CurrentStudent.CurrStudent = currStudent;
            sd.Show();
        }
    }
}
