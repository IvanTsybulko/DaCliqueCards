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
    public partial class AllClasses : Form
    {
        List<Class> classes = new List<Class>();
        List<Place> places = new List<Place>();
        public AllClasses()
        {
            InitializeComponent();
        }

        private void updateClasses()
        {
            classes = classes.OrderBy(c => c.Date).ToList();
            ClassesListBox.DataSource = classes;
            ClassesListBox.DisplayMember = "FullInfo";
        }

        private void AllClasses_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            classes = db.GetClasses();
            places = db.GetPlaces();
            PlaceComboBox.DataSource = places;
            PlaceComboBox.DisplayMember = "Name";
            updateClasses();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DateTime startingDate = BegginingDateTimePicker.Value;
            DateTime endDate = EndDateTimePicker.Value;

            Place place = (Place)PlaceComboBox.SelectedItem;
            classes = classes.Where(c => c.PlaceId == place.Id).ToList();

            classes = classes.Where(c => c.Date >= startingDate && c.Date <= endDate).ToList();
            updateClasses();
            DataAccess db = new DataAccess();
            classes = db.GetClasses();
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            CurrClass.CurrentClass = (Class)ClassesListBox.SelectedItem;

            ClassDetails classDetails = new ClassDetails();
            classDetails.Show();
        }
    }
}
