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
    public partial class DeleteReschedule : Form
    {
        List<Class> classes = new List<Class>();
        public DeleteReschedule()
        {
            InitializeComponent();
        }

        private void updateClasses()
        {
            DataAccess db = new DataAccess();
            classes = db.GetClasses(CurrentCoach.CurrCoach.Id).ToList();
            classes = classes.Where(c => c.Date > DateTime.Now).ToList();

            classes.Reverse();

            ChooseClassComboBox.DataSource = classes;
            ChooseClassComboBox.DisplayMember = "FullInfo";

            if (classes.Count == 0)
            {
                ChooseClassComboBox.Text = string.Empty;
            }
        }
        private void DeleteReschedule_Load(object sender, EventArgs e)
        {
            updateClasses();
        }

        private void DeleteClassButton_Click(object sender, EventArgs e)
        {
            Class selectedClass = (Class)ChooseClassComboBox.SelectedItem;

            if (selectedClass.Date > DateTime.Now)
            {
                if (CurrentCoach.CurrCoach.Id == selectedClass.CoachId)
                {
                    DataAccess db = new DataAccess();
                    db.DeleteClassById(selectedClass.Id);
                    MessageBox.Show("Class has been deleted");
                    updateClasses();
                }
                else
                {
                    MessageBox.Show("You can not change other people classes");
                }
            }
            else
            {
                MessageBox.Show("You can only delete future classes");
            }
        }

        //Checks if there is already a class on that date
        private bool ClassIsFree(Class selectedClass)
        {
            DataAccess db = new DataAccess();

            List<Class> allClasses = db.GetClasses();

            bool classIsFree = true;
            foreach (var c in allClasses)
            {
                if (c.Id != selectedClass.Id)
                {
                    classIsFree = true;

                    if (c.Date < newDatePicker.Value.Add(selectedClass.ClassDuration))
                    {
                        if (newDatePicker.Value < (c.Date.Add(c.ClassDuration)))
                        {
                            if (c.PlaceId == selectedClass.PlaceId)
                            {
                                classIsFree = false;
                                break;
                            }
                        }
                    }
                }

            }

            return classIsFree;
        }

        private void RescheduleButton_Click(object sender, EventArgs e)
        {
            Class selectedClass = (Class)ChooseClassComboBox.SelectedItem;

            if (selectedClass.Date > DateTime.Now && newDatePicker.Value > DateTime.Now)
            {
                bool classIsFree = ClassIsFree(selectedClass);

                if (classIsFree)
                {
                    if (CurrentCoach.CurrCoach.Id == selectedClass.CoachId)
                    {
                        DataAccess db = new DataAccess();
                        db.UpadteClasDate(selectedClass.Id, newDatePicker.Value);
                        updateClasses();
                        MessageBox.Show("Class has been updated");
                    }
                    else
                    {
                        MessageBox.Show("You can not change other people classes");
                    }
                }
                else
                {
                    MessageBox.Show("Class is not free!");
                }
            }
            else
            {
                MessageBox.Show("You can only update classes in to the future!");
            }
        }
    }
}
