using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			set { firstName = value; }
		}

		private string lastName;

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		private string phoneNumber;

		public string PhoneNumber
		{
			get { return phoneNumber; }
			set { phoneNumber = value; }
		}

		public string FullInfo
		{
			get { return $"{FirstName} {LastName} ({AtendancesLeft()} Classes left)"; }
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
