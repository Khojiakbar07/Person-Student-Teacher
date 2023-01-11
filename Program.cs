using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Greet();

            Student student = new Student();
            student.Greet();
            student.ShowAge();
            student.SetAge(21);
            student.Study();
            

            Teacher teacher = new Teacher();
            teacher.Greet();
            teacher.Explain();


            Console.ReadLine();

        }
    }
}
