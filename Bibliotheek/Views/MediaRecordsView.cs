using Bibliotheek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek.Views
{
    public class MediaRecordsView
    {
        private Collectie _collectie = null;
        public MediaRecordsView(Collectie collectie)
        {
            _collectie = collectie;
        }
        public void RunRecordsView()
        {
            Console.WriteLine(MediaCommonOutputText.GetColumnHeadings());
            Console.WriteLine();
            foreach (Media item in _collectie)
            {
                Console.WriteLine(item.GetMediaInformation());
            }
        }
    }
}