using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segregator
{
    class Dokument

    {
        private string Text { get; set; }
        static int totaldoc=0;
        public int Id { get; }




        public Dokument(string text)
        {
            this.Text = text;
            Id = ++totaldoc;
        }


 




    }
}
