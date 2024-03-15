using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaCliqueCardsApp
{
    public class Place
    {
        public Place()
        {
				
        }

        public Place(string name, decimal pricePerhour,string location)
        {
			Name = name;
			PricePerHour = pricePerhour;
			Location = location;
        }
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

		private decimal pricePerHour;

		public decimal PricePerHour
		{
			get { return pricePerHour; }
			set 
			{ 
				if(value < 0)
				{
					throw new ArgumentException("Price per hour can not be negative number");
				}
				pricePerHour = value; 
			}
		}

		private string location;

		public string Location
		{
			get { return location; }
			set 
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new NullReferenceException("Location can not be null or white space");
				}
				location = value; 
			}
		}

	}
}
