using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course27032017
{
    class Binder
    {
        private Dictionary<string, Category> _categories = new Dictionary<string, Category>();

        private bool IsCategoryExist(string newCategoryName)
        {
            return _categories.ContainsKey(newCategoryName);
        }

        private void AddNewCategory(string newCategoryName)
        {
            Category newCategory = new Category(newCategoryName);
            _categories.Add(newCategoryName, newCategory);

        }

        public int AddDocument(string categoryName, string documentContent)
        {
            if (!IsCategoryExist(categoryName))
            {
                AddNewCategory(categoryName);

            }

            var document = new Document(documentContent);
            var category = _categories[categoryName];
            category.AddDocument(document);

            return document.Id;
        }

        public Document GetDocumentContent(int id)
        {
            foreach (var categoriesValue in _categories.Values)
            {
                var doc=categoriesValue.GetDocumentById(id);
                if (doc != null)
                {
                    return doc;
                }
            }
            return null;
        }
    }
}
