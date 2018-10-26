using System;
namespace CIDM4360_PA1
{
    public class Student
    {
        public string StudName;
        public DateTime DateOfBirth;
        public long StudId;
        public string Major;
        public float GPA;

        public Student(string name, DateTime birthDate, long studentId, string major, float gpa){
            StudName = name;
            DateOfBirth = birthDate;
            StudId = studentId;
            Major = major;
            GPA = gpa;
        }

        protected static Student addStudent(bool holder){
            string name; 
            DateTime birthDate; 
            long studentId; 
            string major; 
            float gpa;

            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("BirthDate: ");
            birthDate = DateTime.Parse(Console.ReadLine());
            Console.Write("StudentID: ");
            studentId = long.Parse(Console.ReadLine());
            Console.Write("Major: ");
            major = Console.ReadLine();
            Console.Write("GPA: ");
            gpa = float.Parse(Console.ReadLine());

            return new Student(name, birthDate, studentId, major, gpa);
        }
    }

    public class UndergradStudent : Student{
        protected string previousHighSchool;
        Classification stdClass;
        public UndergradStudent(string name, DateTime birthDate, long studentId, string major, 
            float gpa, string prevHighSchool, Classification studentClassification)
            :base(name, birthDate, studentId, major,gpa)
        {
            previousHighSchool = prevHighSchool;
            stdClass = studentClassification;
        }
        public static UndergradStudent addStudent(){
            Student s = addStudent(true);
            string prevHighSchool;
            Classification studentClassification;
            Console.Write("Previous HighSchool: ");
            prevHighSchool = Console.ReadLine();
            foreach(Classification c in (Classification[])Enum.GetValues(typeof(Classification)))
            {
                Console.WriteLine($"\t{(int)c}. {c.ToString()}");
            }
            Console.Write("Student Classification: ");
            studentClassification = (Classification)int.Parse(Console.ReadLine());
            return new UndergradStudent(s.StudName, s.DateOfBirth, s.StudId, s.Major, s.GPA, prevHighSchool, studentClassification);
        }
    }

    public class GradStudent : Student{
        protected string previousDegree,
                         previousUniversity,
                         undergradMajor;
        float undergradGPA;
        
        public GradStudent(string name, DateTime birthDate, long studentId, string major, float gpa,
                string previousDegree, string previousUniversity, string undergradMajor, float undergradGPA)
            :base(name,birthDate,studentId,major,gpa)
        {
        }    
        public static GradStudent addStudent(){
            Student s = addStudent(true);
            string previousDegree,  previousUniversity,  undergradMajor; 
            float undergradGPA;

            Console.Write("previousDegree: ");
            previousDegree = Console.ReadLine();
            Console.Write("previousUniversity: ");
            previousUniversity = Console.ReadLine();
            Console.Write("undergradMajor: ");
            undergradMajor = Console.ReadLine();
            Console.Write("undergradGPA: ");
            undergradGPA = float.Parse(Console.ReadLine());
            return new GradStudent(s.StudName, s.DateOfBirth, s.StudId, s.Major, s.GPA, 
                previousDegree, previousUniversity,undergradMajor,undergradGPA);
        }    
    }
    public enum Classification
    {
        Freshman = 1,
        Sophmore = 2,
        Junior = 3,
        Senior = 4
    }
}