

namespace Lab_Assignment_3
{
    class Instructor
    {
        public string teacherName;
        public string courseName;
        public int setGrade;

        public Instructor(string teacherName, string courseName)
        {
            this.teacherName = teacherName;
            this.courseName = courseName;
        }

        public void SetStudentGrade(Student student, int setGrade)
        {
            student.grade += setGrade;
            System.Console.WriteLine("The Instructor has set " + student.name + "grade to" + setGrade);
        }

        public void Print( Instructor instructor, string courseName)
        {
            System.Console.WriteLine(instructor.teacherName + " " + courseName);
                
        }

    }
}
