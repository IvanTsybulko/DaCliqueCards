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

        }

        private void CreateClassButton_Click(object sender, EventArgs e)
        {
            ClassType classType = types[ClassTypesComboBox.SelectedIndex];
            TimeSpan classDuration = ClassDurationDateTimePicker.Value.TimeOfDay;
            int atendancesCount = (int)AtendancesCountNumeric.Value;
            Place place = places[PlacesComboBox.SelectedIndex];
            DateTime date = ClassDateDateTimePicker.Value;

            DataAccess db = new DataAccess();

            List<Class> allClasses = db.GetClasses();

            bool classIsFree = true;
            foreach (var c in allClasses)
            {
                if (c.Date < date.Add(classDuration))
                {
                    if (date < (c.Date.Add(c.ClassDuration)))
                    {
                        if (c.PlaceId == place.Id)
                        {
                            classIsFree = false;
                            break;
                        }
                    }
                }
            }

            if (classIsFree)
            {
                Class newClass = new Class(classType.Id, classDuration, atendancesCount, place.Id, CurrentCoach.CurrCoach.Id, date);
                db.InsertClass(newClass);

                List<Class> classes = new List<Class>();
                classes = db.GetClasses();

                newClass = classes.Where(x => x.CoachId == CurrentCoach.CurrCoach.Id).Last();

                MessageBox.Show("Class created!");
            }
            else
            {
                MessageBox.Show("Class is not free!");
            }
        }
    }
}
