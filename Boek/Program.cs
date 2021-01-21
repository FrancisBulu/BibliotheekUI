using Bibliotheek.Models;
using Bibliotheek.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotheekUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool vari = false;
            
            //string sSearch;
            Collectie collectie = new Collectie();
            MediaRecordsView mediaRecordsView = MediaObjectFactory.MediaRecordsViewObject(collectie);



            //Console.WriteLine("Who do you want to find?");
            //sSearch = Console.ReadLine();

            while (!vari)
            {
                Console.Clear();
                Console.WriteLine(MediaCommonOutputText.GetApplicationHeading());
                mediaRecordsView.RunRecordsView();
                Console.WriteLine();
                Console.WriteLine(MediaCommonOutputText.GetInstructions());
                ConsoleKey instructionKeys = Console.ReadKey().Key;
                switch (instructionKeys)
                {
                    case ConsoleKey.C:
                        MediaCreateView mediaCreateView = MediaObjectFactory.MediaCreateViewObject(collectie);
                        mediaCreateView.RunCreateView();
                        break;
                    case ConsoleKey.R:
                        break;
                    case ConsoleKey.U:
                        break;
                    case ConsoleKey.D:
                        break;
                    case ConsoleKey.O:
                        MediaSearchView mediaSearchView = MediaObjectFactory.MediaSearchViewObject(collectie);
                        mediaSearchView.RunSearchView();
                        break;
                    default:
                        vari = true;
                        break;
                }
            }
        }
    }
}
