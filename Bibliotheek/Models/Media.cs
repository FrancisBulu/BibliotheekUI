using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek.Models
{
    public class Media
    {
        //fields
        private static int _NextRef = 0;
        private int _Ref = 0;
        //properties
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Status { get; set; }
        public int Reference
        {
            get { return _Ref; }
        }
        //constructors
        public Media()
        {
            _NextRef++;
            _Ref = _NextRef;
        }
        public Media(string title, string author, string genre, string status) : this()
        {
            Title = title;
            Author = author;
            Genre = genre;
            Status = status;
        }
        //methode
        public string GetMediaInformation()
        {
            string mediaInformation = $"{_Ref.ToString().PadRight(6)}\t{Title.PadRight(25)}\t{Author.PadRight(20)}\t{Genre.PadRight(30)}\t{Status.PadRight(15)}";
            return mediaInformation;
        }

    }
}
