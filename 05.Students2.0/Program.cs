namespace _05.Students2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();

            string info = Console.ReadLine();

            while (info != "end")
            {
                string[] infoArray = info.Split();

                string firstName = infoArray[0];
                string lastName = infoArray[1];
                int age = int.Parse(infoArray[2]);
                string town = infoArray[3];

                bool studentExist = false;

                foreach (var student in students)
                {
                    if (student.firstName == firstName && student.lastName == lastName)
                    {
                        student.Age = age;
                        student.HomeTown = town;
                        studentExist = true;
                        break;
                    }
                }

                if (!studentExist)
                {
                    Student student = new Student
                    {
                        firstName = firstName,
                        lastName = lastName,
                        Age = age,
                        HomeTown = town
                    };
                    students.Add(student);
                }

                info = Console.ReadLine();
            }
            string homeTown = Console.ReadLine();

            foreach (var currentStudent in students)
            {
                if (currentStudent.HomeTown == homeTown)
                {
                    Console.WriteLine($"{currentStudent.firstName} {currentStudent.lastName} is {currentStudent.Age} years old.");
                }
            }
        }
        public class Student
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        }
    }
}