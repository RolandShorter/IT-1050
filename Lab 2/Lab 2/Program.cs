﻿namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.GetUserInfo();
            person1.GetUserSpouseNameAndAge();
            person1.PrintNameAndAge();
            person1.Spouse.PrintNameAndAge();
            
            Person person2 = new Person();
            person2.GetUserInfo();
            person2.GetUserSpouseNameAndAge();
            person2.PrintNameAndAge();
            person2.Spouse.PrintNameAndAge();

            
            System.Console.WriteLine(" Average Age for everyone is " + Person.AverageAge());
            System.Console.ReadKey();

        }
    }
}
