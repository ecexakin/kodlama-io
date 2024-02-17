using kodlama_io.DataAccess.Abstracts;
using kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama_io.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;

        public CourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Description = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)";
            course1.Instructor = "Engin Demiroğ";
            course1.PercentOfComplete = 0;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Description = "Yazılım Geliştirici Yetiştirme Kampı (C# + Angular)";
            course2.Instructor = "Engin Demiroğ";
            course2.PercentOfComplete = 0;

            courses = new List<Course> { course1, course2 };
        }
        public void Add(Course course)
        {
            courses.Add(course);
            Console.WriteLine("Course Added");

        }

        public void Delete(Course course)
        {
            courses.Remove(course);
            Console.WriteLine("Course Deleted");

        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Update(Course course)
        {
            Console.WriteLine("Course Updated");
        }
    }
}
