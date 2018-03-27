using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {

            string result = "";

            List<Student> students = new List<Student>()
            {
                new Student { Name = "Kevin" },
                new Student { Name = "Reece" }
            };

            List<Course> courses = new List<Course>
            {
                new Course { CourseId = 1, Name = "Physics", Students = students },
                new Course { CourseId = 2, Name = "PE", Students = students },
                new Course { CourseId = 3, Name = "Math", Students = students}
            };

            foreach (Course course in courses)
            {
                result += String.Format("CourseID: {0}, Course Name: {1}, ", course.CourseId, course.Name);
                foreach (Student student in students)
                {
                    result += String.Format("Student Name: {0} ", student.Name);
                }
                result += "<br />";
            }

            resultLabel.Text = result;
            
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */ 


        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */

            string result = "";

            List<Student> students = new List<Student>()
            {
                new Student { Name = "Kevin" },
                new Student { Name = "Reece" }
            };

            /*
            Dictionary<string, Student> students = new Dictionary<string, Student>()
            {
                { "ID1", new Student {Name = "Kevin"} },
                { "ID2", new Student {Name = "Reece"} }
            };
            */

            Dictionary<string, Course> courses = new Dictionary<string, Course>()
            {
                {"Course1", new Course { Name = "Physics", Students = students} },
                {"Course2", new Course { Name = "PE", Students = students} },
                {"Course3", new Course { Name = "Math", Students = students} }
            };


            foreach (var course in courses)
            {
                result += String.Format("CourseID: {0}, Course Name: {1}, ", course.Key, course.Value.Name);
                foreach (Student student in students)
                {
                    result += String.Format("Student Name: {0} ", student.Name);
                }
                result += "<br />";
            }

            resultLabel.Text = result;

        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */

            string result = "";

            List<Student> students = new List<Student>()
            {
                new Student { Name = "Kevin" },
                new Student { Name = "Reece" }
            };

            Dictionary<string, Course> courses = new Dictionary<string, Course>()
            {
                {"Course1", new Course { Name = "Physics", Students = students} },
                {"Course2", new Course { Name = "PE", Students = students} },
                {"Course3", new Course { Name = "Math", Students = students} }
            };

            Dictionary<string, Grades> grades = new Dictionary<string, Grades>()
            {
                {"1", new Grades { StudentName = "Kevin", CourseName = "Physics", Grade = 80  } },
                {"2", new Grades { StudentName = "Kevin", CourseName = "Math", Grade = 90} },
                {"3", new Grades { StudentName = "Reece", CourseName = "Math", Grade = 50} },
                {"4", new Grades { StudentName = "Reece", CourseName = "Physics", Grade = 60} }
            };

            for (int i = 0; i < students.Count; i++)
            {
                result += "<h2>" + students.ElementAt(i).Name + ":</h2><br />";

                for (int j = 0; j < grades.Count; j++)
                {
                    if (students.ElementAt(i).Name == grades.ElementAt(j).Value.StudentName)
                    {
                        result += String.Format("{0} : {1} <br />", grades.ElementAt(j).Value.CourseName, grades.ElementAt(j).Value.Grade);
                    }
                }

            }

            resultLabel.Text = result;
        }
    }
}