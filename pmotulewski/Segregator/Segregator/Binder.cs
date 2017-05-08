using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segregator
{
    class Binder
    {
        private List<Category> _categories;
        private StringBuilder commandInLine;

        public Binder()
        {
            _categories = new List<Category>();
            Menu();
        }


        private bool IsCategoryExists(string category)
        {
            return _categories.Contains(category);
        }


        private void AddNewCategory(string category)
        {
            _categories.Add(category);
        }

        public int AddDocument(string category, string content)
        {
            if (!IsCategoryExists(category))
            {
                AddNewCategory(category);
            }

            return _categories[category].AddDocumentToCategory(content);

        }

        public void Menu()
        {
            Console.WriteLine("Binder 1.0");
            Console.WriteLine("+ <kategoria> <tekst> - dodaje tekst w zadanej kategorii, zwraca id tekstu \n"+
                "- < id_tekstu > -usuwa tekst o podanym id \n"+
                "# <kategoria> - wyświetla teksty i ich id-ki w zadanej kategorii \n" +
                "# - wyświetla wszystkie teksty wraz z ich idkami i podaną kategorią (kategorie w kolejności alfabetycznej) \n" +
                "@ < id_tekstu > < nowy_tekst - edytuje tekst\n" +
                "> < nazwa_pliku > - zapis do pliku \n" +
                "< < nazwa_pliku > - odczyt z pliku \n");
            Console.ReadLine();

        }






    }
}
