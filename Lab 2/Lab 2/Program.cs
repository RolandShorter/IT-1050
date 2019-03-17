namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.GetUserInfo();
            person1.GetUserSpouseNameAndAge();

            Person person2 = new Person();
            person2.GetUserInfo();
            person2.GetUserSpouseNameAndAge();

            System.Console.WriteLine("Average Age is " + Person.AverageAge());
            System.Console.ReadKey();

        }
    }
}
