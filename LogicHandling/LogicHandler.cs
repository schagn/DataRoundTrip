using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicHandling
{
    public class LogicHandler
    {

        private static List<Student> students;
        private static List<Student> GetInstance()
        {
            if(students == null)
            {
                students = new List<Student>();
            }
            return students;
        }

        public void AddStudent (Student s)
        {
            GetInstance().Add(s);
        }

        public List<Student> GetStudents()
        {
            return GetInstance();
        }

        // weitere Funktionen wie delete, update 

    }
}
