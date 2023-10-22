using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class Teacher:Human
    {
        //override
        public override void sayHello()
        {
            Console.WriteLine("Hello Children");
        }
        public string SubjectName { get; set; }
        public int WorkingSchool { get; set; }
    }
}
