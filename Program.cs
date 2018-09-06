using System;

namespace ConsoleApp.SQLite
{
    public class Program
    {
        public static void Main()
        {
            using (var db = new SchoolContext())

            {

                var students = new Student[]
            {
            new Student{FirstMidName="Carson",LastName="Alexander"},
            new Student{FirstMidName="Meredith",LastName="Alonso"},
            new Student{FirstMidName="Arturo",LastName="Anand"},
            
            new Student{FirstMidName="Nino",LastName="Olivetto"}
            };

             foreach (Student s in students)
            {
                db.Student.Add(s);
            }
            db.SaveChanges();


             var courses = new Course[]
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
            new Course{CourseID=1045,Title="Calculus",Credits=4},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4},
            new Course{CourseID=2021,Title="Composition",Credits=3},
            new Course{CourseID=2042,Title="Literature",Credits=4}
            };

            foreach (Course c in courses)
            {
                db.Course.Add(c);
            }
            db.SaveChanges();

             var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            };

                  foreach (Enrollment e in enrollments)
            {
                db.Enrollment.Add(e);
            }
            db.SaveChanges();




            
                Console.WriteLine("{0} records saved to database", students.Length);
                
                Console.WriteLine("{0} records saved to database", courses.Length);
                
                Console.WriteLine("{0} records saved to database", enrollments.Length);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var student in db.Student)
                {
                    Console.WriteLine(" - {0}", student.FirstMidName);
                }
            }
        }
    }
}