using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public class Person
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }

        public enum String { Male, Female}

        public override string ToString()
        {
            return $"{Name} was born on {BirthDate}.";
        }
    }
}
