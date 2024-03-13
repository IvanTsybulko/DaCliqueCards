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
			set 
			{
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can not be null or white space");
                }
                name = value; 
			}
		}

		private int numberOfClasses;

		public int NumberOfClasses
		{
			get { return numberOfClasses; }
			set 
			{
				if(value <= 0)
				{
					throw new ArgumentException("Number of classes can not be 0 or less!");
				}
				numberOfClasses = value; 
			}
		}

		private decimal price;

		public decimal Price
		{
			get { return price; }
			set 
			{
                if (value <= 0)
                {
                    throw new ArgumentException("Price can not be 0 or less!");
                }
                price = value; 
			}
		}

        public string FullInfo
        {
            get { return $"Name: {Name} Classes Price: {Price} lv."; }
        }
    }
}
