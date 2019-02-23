namespace Lab_2
{
    class Person
    { 
        public string FirstName;
        public string LastName;
        public int Age;
        public string Spouse;
   
        public static int SumOfAllAges;

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.GetFullName());
            System.Console.WriteLine(this.Age);
        }
        public void GetInformation()
        {
            System.Console.Write("What is your First Name  ");
            this.FirstName = System.Console.ReadLine();

            System.Console.Write("What is your Last Name  ");
            this.LastName = System.Console.ReadLine();

            System.Console.Write("What is your Age  ");
            this.Age = int.Parse (System.Console.ReadLine());

        }

    
    }
}
