using kodlama_io.DataAccess.Abstracts;
using kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama_io.Business.Concretes
{
    public class InstructorManager
    {
        private readonly IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }
        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }
        public void Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
        }
        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }

    }
}
