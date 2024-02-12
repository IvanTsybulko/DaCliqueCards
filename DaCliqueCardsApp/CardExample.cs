using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaCliqueCardsApp
{
    public class CardExample
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private int numberOfClasses;

		public int NumberOfClasses
		{
			get { return numberOfClasses; }
			set { numberOfClasses = value; }
		}

		private decimal price;

		public decimal Price
		{
			get { return price; }
			set { price = value; }
		}

        public string FullInfo
        {
            get { return $"Name: {Name} Classes Price: {Price} lv."; }
        }
    }
}
