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
        }
    }
}
