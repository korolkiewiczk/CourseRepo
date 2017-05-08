using System.Collections.Generic;
using System.Linq;

namespace Course27032017
{
    class Category
    {
        public string CategoryName { get; set; }
        private List<Document> _documents;
        
        public Category(string newCategoryName)
        {
            _documents=new List<Document>();
            this.CategoryName = newCategoryName;
        }

        public void AddDocument(Document document)
        {
            _documents.Add(document);
        }

        public Document GetDocumentById(int id)
        {
            return _documents.FirstOrDefault(x => x.Id == id);
        }
    }
}
