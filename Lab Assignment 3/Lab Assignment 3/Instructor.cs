

namespace Lab_Assignment_3
{
    class Instructor
    {
        public string teacherName;
        public string courseName;
        

        public Instructor(string teacherName, string courseName)
        {
            this.teacherName = teacherName;
            this.courseName = courseName;
        }

        public void SetStudentGrade(Student student, int setGrade)
        {
            student.grade += setGrade;
            System.Console.WriteLine(this.teacherName + " has set " + student.name + " grade to " + setGrade);
        }

        public void Print()
        {
            System.Console.WriteLine(teacherName + " " + courseName);
                
        }

    }
}
