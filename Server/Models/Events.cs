using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Models
{
    public class Events
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Day { get; set; }
        public DateTime Time { get; set; }
    }
}
