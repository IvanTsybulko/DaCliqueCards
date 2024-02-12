using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaCliqueCardsApp
{
    public class Coach
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string firstName;

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		private string lastName;

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		private string username;

		public string Username
		{
			get { return username; }
			set { username = value; }
		}

		private string phoneNumber;

		public string PhoneNumber
		{
			get { return phoneNumber; }
			set { phoneNumber = value; }
		}

		private string password;

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		public string FullInfo
		{
			get { return $"{FirstName} {LastName}"; }
		}
	}
}
