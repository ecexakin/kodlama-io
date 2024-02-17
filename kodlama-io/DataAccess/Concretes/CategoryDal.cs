using kodlama_io.DataAccess.Abstracts;
using kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama_io.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        public List<Category> categories;

        public CategoryDal()
        {
            Category category1 = new Category();
            category1.Name = "Programlama";
            category1.Id = 1;

            Category category2 = new Category();
            category1.Name = "Tümü";
            category1.Id = 2;

        }


        public void Add(Category category)
        {
            Console.WriteLine("Category Added");
            categories.Add(category);
        }

        public void Delete(Category category)
        {
            categories.Remove(category);
            Console.WriteLine("Category Deleted");

        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public void Update(Category category)
        {
            Console.WriteLine("Category Updated");

        }
    }
}
