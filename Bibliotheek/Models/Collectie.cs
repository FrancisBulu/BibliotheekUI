using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek.Models
{
    public class Collectie : IEnumerable, IEquatable<Media>
    {
        //list
        List<Media> _lstMedia = null;
        //constructor
        public Collectie()
        {
            _lstMedia = new List<Media>();
            SeedData();


        }
        //indexer
        public Media this[int index]
        {
            get
            {
                return _lstMedia[index];
            }
        }
        //methodes
        private void SeedData()
        {
            this.Add(MediaObjectFactory.CreateNewMedia("Star Wars", "Kirk Douglas", "Science fiction", "beschikbaar"));
            this.Add(MediaObjectFactory.CreateNewMedia("Star Trek", "Michael Jordan", "Science fiction", "beschikbaar"));
            this.Add(MediaObjectFactory.CreateNewMedia("C# Master", "Kevin Durant", "Informatica", "niet beschikbaar"));
            this.Add(MediaObjectFactory.CreateNewMedia("Waterfalls", "Bob Harley", "Music", "beschikbaar"));
            this.Add(MediaObjectFactory.CreateNewMedia("Macbook Pro", "Lars Von Breidt", "Construction", "niet beschikbaar"));
        }

        public void Add(Media media)
        {
            _lstMedia.Add(media);
        }
        public void SearchWord(Media media)
        {
            _lstMedia.Contains(media);
        }
        public IEnumerator GetEnumerator()
        {
            return _lstMedia.GetEnumerator();
        }

        public bool Equals(Media other) // nog verder zoeken
        {
            return false;
        }
    }
}
