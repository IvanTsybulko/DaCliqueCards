using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaCliqueCardsApp;

namespace DaCliqueCardsApp
{
    public class Student
    {
        public Student(string firstName, string lastName, int age, string phoneNumber)
        {
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			PhoneNumber = phoneNumber;
        }

        public Student()
        {
            
        }
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

		private int age;

		public int Age
		{
			get { return age; }
			set 
			{ 
				if(value <= 0)
				{
					throw new ArgumentException("Age must be positive number!");
				}
				age = value; 
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

		public string FullInfo
		{
			get { return $"{FirstName} {LastName} ({AtendancesLeft()} Classes left) {EndDate()}"; }
		}

		private int AtendancesLeft()
		{
            DataAccess db = new DataAccess();
            List<Card> cards = db.GetStudentCards(Id);

			if(cards.Count > 0)
			{
				return cards.Last().ClassesLeft;
			}

			return 0;
        }

        private string EndDate()
        {
            DataAccess db = new DataAccess();
            List<Card> cards = db.GetStudentCards(Id);

            if (cards.Count > 0)
            {
                return $"End Date: {cards.Last().EndDate.ToString("yyyy-dd-MM")}";
            }

            return "";
        }

        public List<Card> Cards()
		{
            DataAccess db = new DataAccess();
            List<Card> cards = db.GetStudentCards(Id);
			return cards;
        }

		public bool HasActiveCard()
		{
			DataAccess db = new DataAccess();
			List<Card> cards = db.GetStudentCards(Id);

			if(cards.Count == 0)
			{
				return false;
			}

			Card card = cards.Last();

			if(card.ClassesLeft > 0 && card.EndDate > DateTime.Now)
			{
				return true;
			}

			return false;
		}
	}
}
