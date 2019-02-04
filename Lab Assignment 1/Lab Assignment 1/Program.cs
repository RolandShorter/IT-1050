namespace Lab_Assignment_1
{
    class Program
    {
 

        static void Main(string[] args)
        {
            // Declaring variables with unknown quanities.

            string firstName;
            string middleInitial;
            string lastName;
            string fullName;

            int age;

            bool isCitizen;
            bool canVote;

            int heightFeet;
            double heightInches;
            double totalHeightInches;
            double totalHeightCM;

            // Collect data to find variable values

            System.Console.Write("Hello can you please tell me your first name? ");
            firstName = System.Console.ReadLine();

            System.Console.Write("And your middle initial? ");
            middleInitial = System.Console.ReadLine();

            System.Console.Write("And your last name? ");
            lastName = System.Console.ReadLine();

            fullName = (  firstName  +  middleInitial  +   lastName   );



            System.Console.Write("How tall are you in feet? ");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("How tall in inches beyond your height in feet are you? ");
            heightInches = double.Parse(System.Console.ReadLine());

            totalHeightInches = heightFeet + heightInches;

            totalHeightCM = ((heightFeet * 12) + totalHeightInches) * 2.54;

            System.Console.Write("How old are you? ");
            age = int.Parse(System.Console.ReadLine());

           // System.Console.Write("Are you a citizen? (yes/no)");
           // if  (isCitizen == true)
           // {
              //  canVote = true;
           // }
           // else
           // {
             //   isCitizen = false;
           // }

            System.Console.WriteLine(fullName);
            System.Console.WriteLine(totalHeightCM = ((heightFeet * 12) + totalHeightInches) * 2.54);
            System.Console.ReadKey();





        }
    }
}
