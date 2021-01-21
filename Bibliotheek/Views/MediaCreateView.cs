using Bibliotheek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek.Views
{
    public class MediaCreateView
    {
        private Collectie _collectie = null;
        //constructor
        public MediaCreateView(Collectie collectie)
        {
            _collectie = collectie;
        }
        public void RunCreateView()
        {
            string title = null;
            string author = null;
            string genre = null;
            string status = null;

            Console.Clear();
            Console.WriteLine("C cliked");
            Console.WriteLine(MediaCommonOutputText.GetColumnHeadings());
            Console.WriteLine();
            Console.WriteLine(MediaCommonOutputText.GetColumnHeadings());
            Console.WriteLine();
            Console.Write("Title : ");
            title = Console.ReadLine();
            Console.Write("Author : ");
            author = Console.ReadLine();
            Console.Write("Genre : ");
            genre = Console.ReadLine();
            Console.Write("Status : ");
            status = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Press S to save");

            ConsoleKey consoleKey = Console.ReadKey().Key;
            if (consoleKey == ConsoleKey.S)
            {
                _collectie.Add(MediaObjectFactory.CreateNewMedia(title, author, genre, status));
            }
        }
    }
}
