using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Models
{
    public class Exams
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public DateTime Day { get; set; }
        public int SubjectsId { get; set; }
        public int GroupsId { get; set; }
    }
}
