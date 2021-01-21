using Bibliotheek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek.Views
{
    public class MediaSearchView
    {
        //variable 
        string sSearch;
        private Collectie _collectie = null;
        //constructor
        public MediaSearchView(Collectie collectie)
        {
            _collectie = collectie;
        }
        //methode
        public void RunSearchView()
        {

            string title = null;
            string author = null;
            string genre = null;
            string status = null;

            Console.Clear();
            Console.WriteLine("Enter a word to search");
            sSearch = Console.ReadLine();
            
            Console.WriteLine(sSearch);
        }
    }
}
