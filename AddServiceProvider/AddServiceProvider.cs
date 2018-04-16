using LogicHandling;
using ServiceDefintion;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AddServiceProvider
{
    class AddServiceProviders
    {
        static void Main(string[] args)
        {
            LogicHandler lh = new LogicHandler();

            StudentDataService.AddStudentInformer =lh.AddStudent;
            StudentDataService.QueryStudentInformer = lh.GetStudents;

            ServiceHost host = new ServiceHost(typeof(StudentDataService));
            host.Open();



        }
    }
}
