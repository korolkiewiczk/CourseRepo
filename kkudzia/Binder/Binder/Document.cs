using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binder
{
    class Document
    {

        private int ID { get;}
        private string Text { get; set;}


        public Document(string givenText)
        {

            //this.ID = NextID();
            this.Text = givenText;

        }




    }
}
