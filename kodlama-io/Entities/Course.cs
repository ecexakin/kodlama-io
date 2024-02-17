using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama_io.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Instructor { get; set; }
        public string Description { get; set; }
        public int PercentOfComplete { get; set; }
    }
}
