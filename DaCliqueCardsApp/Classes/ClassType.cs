using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaCliqueCardsApp
{
    public class ClassType
    {
        public ClassType()
        {
				
        }

        public ClassType(string classTypeName)
        {
			ClassTypeName = classTypeName;
        }
        private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string classTypeName;

		public string ClassTypeName
		{
			get { return classTypeName; }
			set 
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Class Type can not be null or white space!");
				}
				classTypeName = value; 
			}
		}

	}
}
