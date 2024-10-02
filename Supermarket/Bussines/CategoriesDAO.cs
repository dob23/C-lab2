using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.Model;

namespace Supermarket.Bussines
{
    internal class CategoriesDAO
    {
        private readonly Dictionary<int, Categories> CategoriesList;
        private static int categoriesSecuencial;

        public CategoriesDAO()
        {
            CategoriesList = new Dictionary<int, Categories>();
            categoriesSecuencial = 0;
        }

        public bool AddCategory(Categories category)
        {
            try
            {
                category.Id = ++categoriesSecuencial;
                CategoriesList.Add((int)category.Id, category);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }

        public bool RemoveCategory(int id)
        {
            bool idExists = CategoriesList.ContainsKey(id);
            if (idExists)
            {
                CategoriesList.Remove(id);
                return true;
            }
            return false;
        }

        public Categories GetCategory(int id)
        {
            bool idExists = CategoriesList.ContainsKey(id);
            if (idExists)
            {
                Categories category = CategoriesList[id];
                return category;
            }
            return null;
        }

        public bool UpdateCategory(int id, Categories category)
        {
            bool idExists = CategoriesList.ContainsKey(id);
            if (idExists)
            {
                try
                {
                    CategoriesList[id] = category;
                    return true;
                }
                catch (KeyNotFoundException)
                {
                    return false;
                }
            }
            return false;
        }

        public Dictionary<int, Categories> GetCategoryList()
        {
            return CategoriesList;
        }
    }
}
