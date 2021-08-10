using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Server.Models
{
    public class Students
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Passw { get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }

        public int GroupsId { get; set; }
        public virtual Group Group { get; set; }
    }
}
