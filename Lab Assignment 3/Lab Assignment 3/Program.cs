

namespace Lab_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor John = new Instructor("John","English");
            Instructor Mike = new Instructor("Mike","English");
            Student Jane = new Student("Jane",0,"John");
            Student Joe = new Student("Joe", 0, "John");
            Student Melissa = new Student("Melissa", 0, "Mike");
            Student Matt = new Student("Matt", 0, "Mike");

            John.SetStudentGrade(Jane, 95);
            John.SetStudentGrade(Joe, 85);
            John.SetStudentGrade(Melissa,90);
            John.SetStudentGrade(Matt, 92);

            Jane.Print(John);
            Joe.Print(John);
            Melissa.Print(John);
            Matt.Print(John);
        }
    }
}
