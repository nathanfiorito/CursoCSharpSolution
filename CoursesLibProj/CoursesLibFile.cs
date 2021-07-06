using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesLibNS
{
    public enum Formation
    {
        None,
        MCSAFormsDev,
        MCSAWebDev,
        MCSADDistribuitedApp
    }
    public struct Course
    {
        public int Code;
        public string Name;
        public Formation Formation;
    }

    public delegate void CourseNotFoundDel(int code);

    public class CoursesLibClass
    {
        Course course;
        ArrayList courses;

        public event CourseNotFoundDel CourseNotFoundEvent;

        public CoursesLibClass()
        {
            course = new Course();
            courses = new ArrayList();

            course.Code = 20486;
            course.Name = "Developing ASPNET Core MVC Applications";
            course.Formation = Formation.MCSAWebDev;

            courses.Add(course);


            course.Code = 20487;
            course.Name = "Developing WCF and Azure Applications";
            course.Formation = Formation.MCSAFormsDev;

            courses.Add(course);


            course.Code = 20483;
            course.Name = "Programing C#";
            course.Formation = Formation.MCSADDistribuitedApp;

            courses.Add(course);


            course.Code = 20480;
            course.Name = "Programming CSS Javascript and HTML5";
            course.Formation = Formation.MCSAWebDev;

            courses.Add(course);
        }

        public string ShowCourseName(string code)
        { 
            course = this.ShowCourse(Convert.ToInt32(code));
            return course.Name;
        }

        public string ShowCourseName(int code)
        {
            course = this.ShowCourse(code);
            return course.Name;
        }

        public Course ShowCourse(int code)
        {
            bool found = false;
            foreach (Course item in courses)
            {
                if (item.Code.Equals(code))
                {
                    course = item;
                    found = true;
                }
            }

            if (!found)
            {
                if (CourseNotFoundEvent != null)
                {
                    CourseNotFoundEvent(code);
                }
                course.Code = code;
                course.Name = "Curso não cadastrado";
                course.Formation = Formation.None;
            }

            return course;
        }
    }
}
