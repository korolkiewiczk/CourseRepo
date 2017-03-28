using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binder
{
    class Binder
    {

        public List<Category> Categories { get; set; }

        private bool IsCategoryExist(Category givenCategory)
        {
            return Categories.Contains(givenCategory);
        }

        private void AddNewCategory(Category givenCategory)
        {
            Categories.Add(givenCategory);
        }

        public void AddNewDocument(Category givenCategory, Document givenDocument)
        {
            if (!IsCategoryExist(givenCategory))
            {
                AddNewCategory(givenCategory);
            }

            givenCategory.AddNewDocument(givenDocument);
        }

        public void RemoveDocumentWithId()
        { }


        public void ShowDoumentsFromCategory(Category givenCategory)
        {


        }




        public void SaveToFile()
        { }


        public void ReadFromFile()
        { }








    }
}
