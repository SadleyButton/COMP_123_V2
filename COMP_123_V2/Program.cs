using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_123_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("------------");
            Console.WriteLine();

            Person person = new Person("Brad", 33);
            person.Talks();

            Student student = new Student("John", 19, "123456789A");
            student.Studies();
            student.Talks();
        }
    }
}
