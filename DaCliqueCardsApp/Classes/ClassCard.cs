using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaCliqueCardsApp
{
    public class ClassCard
    {

        public ClassCard()
        {
				
        }

        public ClassCard(int classId, int cardId)
        {
            ClassId = classId;
			CardId = cardId;
        }
        private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private int classId;

		public int ClassId
		{
			get { return classId; }
			set 
			{ 
				if(value.Equals(null))
				{
					throw new ArgumentNullException("Calss id can not be null!");
				}
				classId = value;
			}
		}

		private int cardId;

		public int CardId
		{
			get { return cardId; }
			set 
			{
                if (value.Equals(null))
                {
                    throw new ArgumentNullException("Card id can not be null!");
                }
                cardId = value; 
			}
		}

	}
}
