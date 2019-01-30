namespace CreateClass
{
    public class Person
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }

        public enum Gender { MALE, FEMALE }

        public override string ToString()
        {
            return $"{Name} was born on {BirthDate}";
        }
    }
}
