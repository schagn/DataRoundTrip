using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Shared;

namespace ServiceDefintion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentDataService" in both code and config file together.
    public class StudentDataService : IStudentDataService
    {
       public static Action<Student> AddStudentInformer;
       public static Func<List<Student>> QueryStudentInformer;


        public void AddStudent(Student s)
        {
            AddStudentInformer(s);
        }

        public List<Student> QueryStudents()
        {
            return QueryStudentInformer();
        }
    }
}
