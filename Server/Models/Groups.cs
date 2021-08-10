using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Models
{
    public class Groups
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StudentList { get; set; }

        public virtual List<Studetns> Studetns { get; set; }
    }
}
