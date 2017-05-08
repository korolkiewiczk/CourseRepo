using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binder
{
    class Binder
    {

        private Dictionary<string, Category> _categories { get; set; }

        // roznica pomiedzy properta a fieldem;



        public Binder()
        {
            _categories = new Dictionary<string, Category>();
        }



        private bool IsCategoryExist(string givenCategoryName)
        {
            return _categories.ContainsKey(givenCategoryName);
        }

        private void AddNewCategory(string givenCategoryName)
        {
            Category _category = new Category(givenCategoryName);
            this._categories.Add(givenCategoryName, _category);
        }

        public void AddNewDocument(string givenCategoryName, string givenDocumentContent)
        {

            if (!IsCategoryExist(givenCategoryName))
            {
                AddNewCategory(givenCategoryName);
            }
            _categories[givenCategoryName].AddNewDocument(new Document(givenDocumentContent));

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
