using System;

namespace CreateClass
{
    public class Person
    {
        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public enum Gender { Male, Female }

        public override string ToString()
        {
            return $"{Name} was born on {BirthDate}";
        }
    }
}
