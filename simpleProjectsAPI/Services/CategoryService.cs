using simpleProjectsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpleProjectsAPI.Services
{
    public class CategoryService
    {
        private List<Category> categories;

        public CategoryService()
        {
            categories = new List<Category>
            {
                 new Category { Id=1, Name="Kredi Kartları"},
                 new Category { Id=2, Name="Bireysel Bankacılık"},
                 new Category { Id=3, Name="Bireysel Krediler"}



            };
        }
        public List<Category> GetCategories()
        {
            return categories;
        }
    }
}
