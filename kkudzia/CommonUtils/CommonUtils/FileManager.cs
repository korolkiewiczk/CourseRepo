using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtils
{
    class FileManager
    {


        private bool IsFileExist(string givenFilename)
        {

            return false;


        }




        public void WriteToFile(string givenFilename)
        {

            if (!IsFileExist(givenFilename))
            {
                CreateNewFile();

            }



        }


    }
}
