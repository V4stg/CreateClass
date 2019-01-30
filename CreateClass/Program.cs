namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();
            System.Console.WriteLine("Enter your name:");
            firstPerson.Name = System.Console.ReadLine();
            System.Console.WriteLine("Enter your birth date:");
            firstPerson.BirthDate = System.Console.ReadLine();

            System.Console.WriteLine(firstPerson.ToString());
            System.Console.ReadKey(); // to wait for user to quit

            Employee firstEmlpoyee = new Employee();
            System.Console.WriteLine("Enter your name:");
            firstEmlpoyee.Name = System.Console.ReadLine();
            System.Console.WriteLine("Enter your birth date:");
            firstEmlpoyee.BirthDate = System.Console.ReadLine();
            System.Console.WriteLine("Enter your profession:");
            firstEmlpoyee.Profession = System.Console.ReadLine();
            System.Console.WriteLine("Enter your salary:");
            try
            {
                firstEmlpoyee.Salary = double.Parse(System.Console.ReadLine());
            }
            catch
            {
                System.Console.WriteLine("That is not a number!");
            }

            System.Console.WriteLine(firstEmlpoyee.ToString());
            System.Console.ReadKey(); // to wait for user to quit
        }
    }
}
