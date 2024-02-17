

using kodlama_io.Business.Concretes;
using kodlama_io.DataAccess.Concretes;
using kodlama_io.Entities;

//CourseManager courseManager = new(new CourseDal());

//List<Course> courses2 = courseManager.GetAll();
//for (int i = 0; i < courses2.Count; i++)
//{
//    Console.WriteLine(courses2[i].Description + " / " + courses2[i].Instructor);
//}

CourseManager courseManager = new CourseManager(new CourseDal());
List<Course> courses;
courses = courseManager.GetAll();

for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Id + "/" + courses[i].Instructor);
}
