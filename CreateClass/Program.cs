using System;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person secondPerson = new Person("Laci", DateTime.Now);
            Console.WriteLine(secondPerson.ToString());

            Employee secondEmployee = new Employee("Laci", DateTime.Now, 1000.0, "Engineer");
            Console.WriteLine(secondEmployee.ToString());

            Employee Kovacs = new Employee("Géza", DateTime.Now, 1000, "léhűtő");
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.Number = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }
}
