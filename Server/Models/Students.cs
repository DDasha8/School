using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Passw { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public int GroupsId { get; set; }
    }
}
