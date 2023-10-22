using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class Human
    {
        public string FinCode { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string FatherName { get; set; }
        public virtual void sayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
