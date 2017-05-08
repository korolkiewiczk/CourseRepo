using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segregator
{
    class Category
    {
        public string CategoryName { get; set; }
        public List<Dokument> _documents { get; set; }

        public Category(string categoryName)
        {
            CategoryName = categoryName;
            _documents = new List<Dokument>();
        }




        public int AddDocumentToCategory(String content)
        {
            Dokument temp = new Dokument(content);
            _documents.Add(temp);
            return temp.Id;
        }


    }

}
