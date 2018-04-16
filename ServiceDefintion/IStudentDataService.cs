using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceDefintion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentDataService" in both code and config file together.
    [ServiceContract]
    public interface IStudentDataService
    {
        [OperationContract]
        List<Student> QueryStudents();

        [OperationContract]
        void AddStudent(Student s);
    }
}
