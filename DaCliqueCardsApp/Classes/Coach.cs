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
			set 
			{
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("First name can not be null or white space!");
                }
				firstName = value; 
			}
		}

		private string lastName;

		public string LastName
		{
			get { return lastName; }
			set 
			{
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("Last name can not be null or white space!");
                }
                lastName = value; 
			}
		}

		private string username;

		public string Username
		{
			get { return username; }
			set 
			{ 
				if (String.IsNullOrWhiteSpace(value))
				{
					throw new NullReferenceException("Username can not be null or white space!");
				}
				username = value; 
			}
		}

		private string phoneNumber;

		public string PhoneNumber
		{
			get { return phoneNumber; }
			set 
			{
                if (value.Any(char.IsLetter))
                {
                    throw new ArgumentException("Phone number can not contain letters!");
                }
                phoneNumber = value; 
			}
		}

		private string password;

		public string Password
		{
			get { return password; }
			set 
			{
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("Password can not be null or white space!");
                }
                password = value; 
			}
		}

		public string FullInfo
		{
			get { return $"{FirstName} {LastName}"; }
		}
	}
}
