using GroupAssignment_ConsoleApp.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment_ConsoleApp.Interfaces
{
   public interface IBookingService
    {
        void bookAppointment(Appointment appointment);
        List<Appointment> getAppointments();
    }
}
