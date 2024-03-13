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
            set 
            {
                classDuration = value; 
            }
        }

        private int classTypeId;

		public int ClassTypeId
		{
			get { return classTypeId; }
			set 
            { 
                if(value == null)
                {
                    throw new NullReferenceException("TypeId can not be null!");
                }
                classTypeId = value; 
            }
		}

        private int atendancesCount;

        public int AtendancesCount
        {
            get { return atendancesCount; }
            set 
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Attendances count can not be 0 or less!");
                }
                atendancesCount = value; 
            }
        }

        private int placeId;

        public int PlaceId
        {
            get { return placeId; }
            set {
                if (value == null)
                {
                    throw new NullReferenceException("PlaceId can not be null!");
                }
                placeId = value; 
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
                    throw new NullReferenceException("CoachId can not be null!");
                }
                coachId = value; 
            }
        }

        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string DateInfo
        {
            get { return $"Date: {Date}"; }
        }

        public string FullInfo
        {
            get { return $"Date: {Date.ToString("yyyy-dd-MM HH:mm")} To: {Date.Add(classDuration).ToString("HH:mm")}  Coach: {GetCoachName()}  Class: {GetClassTypeName()}  Place: {GetPlaceName()}  Attendances: {AtendancesCount}"; }
        }

        public string GetClassTypeName()
        {
            DataAccess db = new DataAccess();
            ClassType ct = db.GetClassTypeById(ClassTypeId);
            return ct.ClassTypeName;
        }

        public string GetCoachName()
        {
            DataAccess db = new DataAccess();
            Coach c = db.GetCoachById(CoachId);
            string name = c.FirstName;
            return name;
        }

        public string GetPlaceName()
        {
            DataAccess db = new DataAccess();
            Place c = db.GetPlaceById(PlaceId);
            string name = c.Name;
            return name;
        }
    }
}
