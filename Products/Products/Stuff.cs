using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Stuff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public void Work()
        {
            Console.WriteLine("I am Working");
        }
    }
}
