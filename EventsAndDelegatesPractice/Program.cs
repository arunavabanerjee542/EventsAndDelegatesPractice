using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            InnoadAttendence markattendence = new InnoadAttendence();
            var hr = new HrDepartment();
            var qa = new QualityAssistance();
            var softwaretrainee = new SoftwareTrainee();
            var sde = new SoftwareDevelopementTeam();

            markattendence.AttendenceEvent += hr.HRattendence;
            markattendence.AttendenceEvent +=  qa.QAattendence;
            markattendence.AttendenceEvent += softwaretrainee.SoftwareTraineeAttendence;
            markattendence.AttendenceEvent += sde.SoftwareDevelopementAttendence;

           

            // using Anonymous methods 

            markattendence.AttendenceEvent += delegate (string s)
            {
                Console.WriteLine( " I BELONG TO ANONYMOUS DEPARTMENT :" + s );
            };

            // using Lambda
            markattendence.AttendenceEvent += (s) =>
            {
                Console.WriteLine(" I BELING TO LAMBDA DEPARTMENT :" + s);
            };







            markattendence.callEvent(" ATTENDENCE VERIFIED ");



            Console.ReadLine();




        }

        private static void Markattendence_AttendenceEvent(string message)
        {
            throw new NotImplementedException();
        }
    }
}
