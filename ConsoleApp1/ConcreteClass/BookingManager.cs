using GroupAssignment_ConsoleApp.Class;
using GroupAssignment_ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment_ConsoleApp.ConcreteClass
{
    public class BookingManager 
    {
        private List<Appointment> appointments = new List<Appointment>();

        public void AddAppointment(Appointment appointment)
        {            
            appointments.Add(appointment);
        }

        public List<Appointment> GetAppointments()
        {
            return appointments;
        }
    }
}
