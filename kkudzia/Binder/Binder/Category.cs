using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binder
{
    class Category
    {

        private string CategoryName { get; set; }
        private List<Document> Documents { get; set; }

        
        public void AddNewDocument(Document givenDocument)
        {
            Documents.Add(givenDocument);
        }

    }
}
