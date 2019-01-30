using System;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        public Employee(string name, DateTime birthDate, double salary, string profession) : base(name, birthDate)
        {
            Salary = salary;
            Profession = profession;
        }

        public double Salary { get; set; }
        public string Profession { get; set; }
        public Room Room { get; set; }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }

        public override string ToString()
        {
            return base.ToString() + $" Profession: {Profession}, Salary: {Salary}";
        }
    }
}
