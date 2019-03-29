namespace Lab_2
{
    class Person
    { 
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;
   
        public static int SumOfAllAges;
        public static int Count;

        public static double AverageAge()
        {
            return (double)Person.SumOfAllAges / (double)Person.Count;
        }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.GetFullName());
            System.Console.WriteLine(this.Age);
        }
        public void GetUserInfo()
        {
            System.Console.Write("What is your First Name  ");
            this.FirstName = System.Console.ReadLine();

            System.Console.Write("What is your Last Name  ");
            this.LastName = System.Console.ReadLine();

            System.Console.Write("What is your Age  ");
            this.Age = int.Parse (System.Console.ReadLine());

            Person.Count++;
            Person.SumOfAllAges += this.Age;
           
            

        }
        public void GetUserSpouseNameAndAge()
        {
            System.Console.Write("Are you married? y/n");
            
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
           this.Spouse = new Person();
            this.Spouse.GetUserInfo();
            this.Spouse.Spouse = this;

            }
        }
        
         

    
    }
};
