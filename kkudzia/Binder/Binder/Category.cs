using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binder
{
    class Category
    {
        private string CategoryName;
        private List<Document> Documents { get; set; }

        public Category(string givenCategoryName)
        {
            this.CategoryName = givenCategoryName;
        }

        

        
        public void AddNewDocument(Document givenDocument)
        {
            Documents.Add(givenDocument);
        }

    }
}
