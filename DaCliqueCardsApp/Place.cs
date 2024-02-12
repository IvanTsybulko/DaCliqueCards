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
			set { name = value; }
		}

		private decimal pricePerHour;

		public decimal PricePerHour
		{
			get { return pricePerHour; }
			set { pricePerHour = value; }
		}

		private string location;

		public string Location
		{
			get { return location; }
			set { location = value; }
		}

	}
}
