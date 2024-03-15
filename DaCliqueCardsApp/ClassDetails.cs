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
    public partial class ClassDetails : Form
    {
        List<Student> students = new List<Student>();
        public ClassDetails()
        {
            InitializeComponent();
        }

        private void ClassDetails_Load(object sender, EventArgs e)
        {
            Class currClass = CurrClass.CurrentClass;
            DateLabel.Text = $"Date: {currClass.Date.ToString("yyyy-dd-MM")}";
            StartsLabel.Text = $"Starts: {currClass.Date.ToString("hh:mm")}";
            EndsLabel.Text = $"Ends: {currClass.Date.Add(currClass.ClassDuration).ToString("hh:mm")}";
            AttendancesLabel.Text = $"Attendances: {currClass.AtendancesCount}";
            PlaceLabel.Text = $"Place: {currClass.GetPlaceName()}";
            CoachLabel.Text = $"Coach: {currClass.GetCoachName()}";

            DataAccess db = new DataAccess();
            students = db.GetStudentsByClassId(currClass.Id);

            ClassTypeLabel.Text = $"Type: {db.GetClassTypeById(currClass.ClassTypeId).ClassTypeName}";

            StudentsListBox.DataSource = students;
            StudentsListBox.DisplayMember = "FullInfo";
        }
    }
}
