using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.Level = Level.Boss;
            Console.WriteLine(person.Level);
            Console.WriteLine((int)person.Level);
            Console.ReadKey();
        }
    }

    enum Level { 
        Employee = 1,
        Manager  = 2,
        Boss = 3,
        BigBoss = 4,
    }


    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Level Level { get; set; }
    }
}
