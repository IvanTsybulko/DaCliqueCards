using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Dapper;

namespace DaCliqueCardsApp
{
    public class DataAccess
    {
        public List<Student> GetStudents(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))  
            {
                //var output =  connection.Query<Student>($"SELECT * FROM Students WHERE FirstName + ' ' + LastName LIKE '%{name}%';").ToList(); easier but bad practice
                var output = connection.Query<Student>($"dbo.Students_GetByName @name", new {Name = name}).ToList();
                return output;
            }
        }

        public List<Student> GetStudentsByClassId(int classId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                var output = connection.Query<Student>($"dbo.GetStudentsByClassId @ClassId", new { ClassId = classId }).ToList();
                return output;
            }
        }

        public List<Student> GetStudentsNotInClass(int classId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                var output = connection.Query<Student>($"dbo.Students_GetNotInClass @ClassId", new { ClassId = classId }).ToList();
                return output;
            }
        }

        public List<Card> GetStudentCards(int studentId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                var output = connection.Query<Card>($"dbo.Cards_GetByStudentId @StudentId", new { StudentId = studentId }).ToList();
                return output;
            }
        }
        public List<Class> GetClasses(int coachId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                var output = connection.Query<Class>($"dbo.Classes_GetByCoachId @CoachId", new { CoachId = coachId }).ToList();
                return output;
            }
        }

        public List<ClassCard> GetClassCard(int classId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                var output = connection.Query<ClassCard>($"dbo.ClassCard_ByClassId @ClassId", new { ClassId = classId }).ToList();
                return output;
            }
        }

        public Coach GetCoachById(int CoachId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                var output = connection.Query<Coach>($"dbo.Coaches_GetById @CoachId", new { CoachId = CoachId }).ToList();
                return output.First();
            }
        }

        public ClassType GetClassTypeById(int ClassTypeId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                var output = connection.Query<ClassType>($"dbo.ClassType_GetById @ClassTypeId", new { ClassTypeId = ClassTypeId }).ToList();
                return output.First();
            }
        }

        public List<Class> GetClassesByCardId(int CardId) 
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                var output = connection.Query<Class>($"dbo.Classes_GetByCardId @inputCardId", new { inputCardId = CardId }).ToList();
                return output;
            }
        }

        public Place GetPlaceById(int PlaceId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                var output = connection.Query<Place>($"dbo.Place_GetById @PlaceId", new { PlaceId = PlaceId }).ToList();
                return output.First();
            }
        }

        public CardExample GetCardExampleById(int CardExampleId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                var output = connection.Query<CardExample>($"dbo.CardExample_GetById @CardExampleId", new { CardExampleId = CardExampleId }).ToList();
                return output.First();
            }
        }

        public Coach LogInCoach(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                var output = connection.QueryFirst<Coach>($"dbo.Coaches_LogIn @username, @password", new {Username = username, Password = password});
                return output;
            }
        }

        public List<CardExample> GetCardExamples()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                var output = connection.Query<CardExample>($"dbo.CardExamples_GetAll").ToList();
                return output;
            }
        }

        public List<Place> GetPlaces()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                var output = connection.Query<Place>($"dbo.Places_GetAll").ToList();
                return output;
            }
        }

        public List<ClassType> GetClassTypes()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                var output = connection.Query<ClassType>($"dbo.ClassTypes_GetAll").ToList();
                return output;
            }
        }
        public List<Class> GetClasses()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                var output = connection.Query<Class>($"dbo.Classes_GetAll").ToList();
                return output;
            }
        }


        public void InsertStudent(string firstName, string lastName, int age, string phoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                Student newStudent = new Student(firstName,lastName,age,phoneNumber);

                connection.Execute("dbo.Students_Insert @Firstname, @LastName, @Age, @PhoneNumber", newStudent);
            } 
        }

        public void InsertCard(Card card)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                connection.Execute("dbo.Cards_Insert @CardExampleId, @StartingDate, @EndDate, @ClassesLeft, @StudentId, @CoachId", card);
            }

        }

        public void InsertClass(Class newClass)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                connection.Execute("dbo.InsertClass @ClassTypeId, @ClassDuration, @AtendancesCount, @PlaceId, @CoachId, @Date", newClass);
            }
        }

        public void InsertClassCard(ClassCard cc)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                connection.Execute("dbo.ClassCard_Insert @ClassId, @CardId", cc);
            }
        }


        public void UpadteCardClassesLeft(int id, int classesLeft)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                connection.Execute("dbo.Card_ClassesLeftUpdate @Id, @ClassesLeft",new { id, classesLeft });
            }
        }
        public void UpadteClasDate(int ClassId, DateTime newDate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                connection.Execute("dbo.Classes_UpdateDateById @ClassId, @NewDate", new { ClassId, newDate });
            }
        }



        public void DeleteClassById(int ClassId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DaCliqueCardsDB")))
            {
                connection.Execute("dbo.Classes_DeleteById @ClassId", new { ClassId });
            }
        }
    }
}