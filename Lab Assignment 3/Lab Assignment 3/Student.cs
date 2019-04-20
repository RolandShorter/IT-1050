

namespace Lab_Assignment_3
{
    class Student
    {
        public string name;
        public int grade;
        public Instructor instructor;

            public Student( string name, int grade, Instructor instructor)
        {
            this.name = name;
            this.grade = grade;
            this.instructor = instructor; 
        }
        public void Print()
        {
            System.Console.WriteLine(this.name + " has a grade of "  + this.grade + " " + "from " + instructor.teacherName + ".");
        }
    }
}
