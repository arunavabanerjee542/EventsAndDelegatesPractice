using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesPractice
{
    public delegate void Attendence(string message);

    class InnoadAttendence
    {
        public event Attendence AttendenceEvent;

        public void callEvent(string message)
        {
            OnLoadAttendenceEvent(message);
        }

        protected void OnLoadAttendenceEvent(string message)
        {
            // Trick 1 : call the event ditectly

            if(AttendenceEvent != null)
            {
                AttendenceEvent(message);
            }


            // Trick 2 : Accessing the delegate first and invoking the delegate

            Attendence del = AttendenceEvent as Attendence;

            if ( del!= null)
            {
                del(message);
            }





        }




    }
}
