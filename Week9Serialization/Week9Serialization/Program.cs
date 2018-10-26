using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9Serialization
{
    public class Program
    {
        static void Main(string[] args)
        {           
            Teacher teacher = new Teacher();

            teacher.FirstName = "Mark";
            teacher.LastName = "Twain";
            teacher.Title = "Dr.";
            teacher.Subject = "History";
            teacher.Students = new List<Student>()
                {
                    new Student
                    {
                    FirstName = "Timmy",
                    LastName = "Seth",
                    Grade = "Sophomore",
                    ID = "0562728"
                    },

                    new Student
                    {
                    FirstName = "Will",
                    LastName = "Smith",
                    Grade = "Freshman",
                    ID = "0478924"
                    },
                    new Student
                    {
                    FirstName = "Sam",
                    LastName = "Hoffman",
                    Grade = "Sophomore",
                    ID = "0792684"
                    }
                };
            JsonSerializer.JsonParser(teacher);
        }
    }
}
