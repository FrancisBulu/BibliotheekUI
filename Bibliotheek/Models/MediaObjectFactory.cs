using Bibliotheek.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek.Models
{
    public class MediaObjectFactory
    {
        private static MediaCreateView _mediaCreateView = null;
        private static MediaSearchView _mediaSearchView = null;
        public static Media CreateNewMedia(string titel, string author, string genre, string status)//static -> geen instantie aanmaken
        {
            return new Media //object initializer
            {
                Title = titel,
                Author = author,
                Genre = genre,
                Status = status
            };
            
        }
        
        public static MediaRecordsView MediaRecordsViewObject(Collectie collectie)
        {
            return new MediaRecordsView(collectie);
        }
        public static MediaCreateView MediaCreateViewObject(Collectie collectie)
        {
            if (_mediaCreateView == null)
            {
                _mediaCreateView = new MediaCreateView(collectie);
            }
            return _mediaCreateView;
        }
        public static MediaSearchView MediaSearchViewObject(Collectie collectie)
        {
            if (_mediaSearchView == null)
            {
                _mediaSearchView = new MediaSearchView(collectie);
            }
            //return new MediaSearchView(collectie);
            return _mediaSearchView;
        }
    }
}
