using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek.Models
{
    public class MediaCommonOutputText
    {
        //methodes
        public static string GetColumnHeadings()
        {
            string id = "id";
            string title = "title";
            string author = "author";
            string genre = "genre";
            string status = "status";
            string heading = $"{id.PadRight(6)}\t{title.PadRight(30)}\t{author.PadRight(20)}\t{genre.PadRight(30)}\t{status.PadRight(10)}";
            return heading;
        }
        private static string GetUnderlineForHeadings(string heading)
        {
            return new string('-', heading.Length - 1);
        }
        public static string GetApplicationHeading()
        {
            string heading = "Media items uit de collectie zijn:\n";
            string underline = GetUnderlineForHeadings(heading);
            return $"{heading}{underline}";
        }
        // methodes --> instructies
        public static string GetInstructions()
        {
            return $"[C] Create, [R] Read, [U] Update, [D] Delete, [O] Search, press any key to end";
        }
    }
}
