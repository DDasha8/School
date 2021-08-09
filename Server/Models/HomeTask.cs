using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Models
{
    public class HomeTask
    {
        public int Id { get; set; }
        public DateTime Day { get; set; }
        public string Content { get; set; } 
        public int SubjectsId { get; set; }
        public int StudentsId { get; set; }
    }
}
