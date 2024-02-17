using kodlama_io.DataAccess.Abstracts;
using kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama_io.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        public List<Instructor> instructors;

        public InstructorDal()
        {
            Instructor instructor1 = new Instructor();
            instructor1.Id = 1;
            instructor1.Name = "Engin Demiroğ";

            Instructor instructor2= new Instructor();
            instructor1.Id = 2;
            instructor1.Name = "Halit Enes Kalaycı";
        }


        public void Add(Instructor instructor)
        {

            instructors.Add(instructor);
            Console.WriteLine("Instructor Added");

        }

        public void Delete(Instructor instructor)
        {
            instructors.Remove(instructor);
            Console.WriteLine("Instructor Deletelld");

        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Update(Instructor instructor)
        {
            Console.WriteLine("Instructor Updated");
        }
    }
}
