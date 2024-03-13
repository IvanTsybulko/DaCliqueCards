using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaCliqueCardsApp
{
    public class Card
    {
        public Card()
        {
				
        }

        public Card(int cardExampleId, DateTime startingDate, DateTime endDate, int classesLeft, int studentId, int coachId)
        {
			CardExampleId = cardExampleId;
			StartingDate = startingDate;
			EndDate = endDate;
			ClassesLeft = classesLeft;
			StudentId = studentId;
			CoachId = coachId;
        }
        private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private int cardExampleId;

		public int CardExampleId
		{
			get { return cardExampleId; }
			set 
			{
				if(value == null)
				{
					throw new NullReferenceException("Card example id can not be null!");
				}
				cardExampleId = value;
			}
		}

		private DateTime startingDate;

		public DateTime StartingDate
		{
			get { return startingDate; }
			set { startingDate = value; }
		}


		private DateTime  endDate;

		public DateTime  EndDate
		{
			get { return endDate; }
			set { endDate = value; }
		}

		private int classesLeft;

		public int ClassesLeft
		{
			get { return classesLeft; }
			set 
			{
				classesLeft = value; 
			}
		}

		private int studentId;

		public int StudentId
		{
			get { return studentId; }
			set 
			{
                if (value == null)
                {
                    throw new NullReferenceException("Student id can not be null!");
                }
                studentId = value; 
			}
		}


		private int coachId;

		public int CoachId
		{
			get { return coachId; }
			set 
			{
                if (value == null)
                {
                    throw new NullReferenceException("Coach id can not be null!");
                }
                coachId = value; 
			}
		}
        public string FullInfo
        {
            get { return $"{StartingDate.ToString("yyyy-dd-MM")} to {EndDate.ToString("dd-MM")} {GetCoachName()} Card: {GetCardExampleName()} ({ClassesLeft} Classes left)"; }
        }

		private string GetCoachName()
		{
			DataAccess db = new DataAccess();
			Coach coach = db.GetCoachById(CoachId);

			return $"{coach.FirstName} {coach.LastName[0]}.";
		}

		private string GetCardExampleName()
		{
            DataAccess db = new DataAccess();
			CardExample ce = db.GetCardExampleById(CardExampleId);

			return ce.Name;
        }
    }
}
