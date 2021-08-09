using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public int Mark { get; set; }
        public int StudentsId { get; set; }
    }
}
