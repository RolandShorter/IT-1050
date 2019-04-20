

namespace Lab_Assignment_3
{
    class Student
    {
        public string name;
        public int grade;
        public Student Instructor;

            public Student( string name, int grade, Instructor instructor)
        {
            this.name = name;
            this.grade = grade;
        }
        public void Print(Instructor instructor)
        {
            System.Console.WriteLine(this.name + "has a grade of" + " " + "from" + instructor.teacherName ".");
        }
    }
}
