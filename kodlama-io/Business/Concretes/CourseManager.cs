using kodlama_io.DataAccess.Abstracts;
using kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama_io.Business.Concretes
{
    
    public class CourseManager
    {
        private readonly ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }
        public void Add(Course course)
        {
            _courseDal.Add(course);
        }
        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }
        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
