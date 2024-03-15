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
    public partial class CardDetails : Form
    {
        List<Class> classes = new List<Class>();
        public CardDetails()
        {
            InitializeComponent();
        }

        private void CardDetails_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            classes = db.GetClassesByCardId(CurrentCard.CurrCard.Id);
            ClassesListBox.DataSource = classes;
            ClassesListBox.DisplayMember = "FullInfo";
        }
    }
}
