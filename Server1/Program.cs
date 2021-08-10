using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server1.Models;

namespace Server1
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1 db = new Model1();
            db.Subjects.Add(new Subjects() { Name = "DP" });

            var subjects = db.Subjects.ToList();
            Console.WriteLine(subjects.Count);
            foreach(var subject in subjects)
            {
                Console.WriteLine(subject.Name);
            }

            Console.WriteLine("OK");

        }
    }
}
