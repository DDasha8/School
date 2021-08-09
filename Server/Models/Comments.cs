using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string Theme { get; set; }
        public DateTime Day { get; set; }
        public DateTime Time { get; set; }
        public string Content { get; set; }
        public int StudentsId { get; set; }
    }
}
