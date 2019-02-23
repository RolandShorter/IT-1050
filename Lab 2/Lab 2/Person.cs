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

    
    }
}
