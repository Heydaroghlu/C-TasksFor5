using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Branch
    {
        //Overloading
        public Branch()
        {
            
        }
        public Branch(string Ad,string unvan)
        {
            Name = Ad;
            Address = unvan;
        }
        public string Name { get; set; }    
        public string Address { get; set; }
    }
}
