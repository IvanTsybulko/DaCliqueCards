using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaCliqueCardsApp
{
    public class Class 
    {
        public Class()
        {
				
        }

        public Class(int classTypeId, TimeSpan classDuration,int atendancesCount, int placeId,int coachId, DateTime date)
        {
			ClassTypeId = classTypeId;
			ClassDuration = classDuration;
			AtendancesCount = atendancesCount;
			PlaceId = placeId;
			CoachId = coachId;
			Date = date;
        }
        private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}


        private TimeSpan classDuration;

        public TimeSpan ClassDuration
        {
            get { return classDuration; }
            set { classDuration = value; }
        }

        private int classTypeId;

		public int ClassTypeId
		{
			get { return classTypeId; }
			set { classTypeId = value; }
		}

        private int atendancesCount;

        public int AtendancesCount
        {
            get { return atendancesCount; }
            set { atendancesCount = value; }
        }

        private int placeId;

        public int PlaceId
        {
            get { return placeId; }
            set { placeId = value; }
        }

        private int coachId;

        public int CoachId
        {
            get { return coachId; }
            set { coachId = value; }
        }

        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string FullInfo
        {
            get { return $"Date: {Date}"; }
        }


    }
}
