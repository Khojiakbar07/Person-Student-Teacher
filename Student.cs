using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class Student : Person
    {
        int x = 21;
        public void Study ()
        {
            Console.WriteLine("I'm studing");  
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is " + x +"years old");
        }
    }
}
