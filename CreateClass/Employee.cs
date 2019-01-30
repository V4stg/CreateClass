namespace CreateClass
{
    class Employee : Person
    {
        public double Salary { get; set; }
        public string Profession { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" Profession: {Profession}, Salary: {Salary}";
        }
    }
}
