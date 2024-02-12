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
			set { cardExampleId = value; }
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
			set { classesLeft = value; }
		}

		private int studentId;

		public int StudentId
		{
			get { return studentId; }
			set { studentId = value; }
		}


		private int coachId;

		public int CoachId
		{
			get { return coachId; }
			set { coachId = value; }
		}
    }
}
