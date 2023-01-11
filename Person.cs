using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class Person
    {
        int x = 21;
        protected int Age;
        
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
        public void SetAge(int n)
        {
            Age = n;
        }
        
    }
}
