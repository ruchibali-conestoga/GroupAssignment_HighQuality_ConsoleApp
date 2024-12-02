using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment_ConsoleApp.Class
{
    public class Appointment
    {
        public DateTime startTime { get; set; }
        public int durationInMinutes { get; set; }
        public string petName { get; set; }
        public string ownerName { get; set; }
    }
}
