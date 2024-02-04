using System;
using System.Collections.Generic;

namespace CSharp_420_413.POO.Classes.ClassesIntro
{
    internal class AccessByIndexer
    {
        HttpCookie cookie = new HttpCookie();
        public AccessByIndexer(string name)
        {
            cookie["name"] = name;
        }

        public void PrintCookie()
        {
            Console.WriteLine(cookie["name"]);
        }
    }

    internal class HttpCookie
    {
        public DateTime Expiry { get; set; }
        private readonly Dictionary<string, string> _dictionary;

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
            Expiry = DateTime.Today.AddDays(2);
        }

        public void GetItem(string key) { }

        public void SetItem(string key, string value) { }

        public string this[string key]          // Indexer
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
