using System;
using System.Collections.Generic;

namespace ET.Infrastructure.Indexers
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; } = DateTime.Now.AddDays(1);

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get => _dictionary[key];
            set => _dictionary[key] = value;
        }

        public bool IsExpired()
        {
            return Expiry > DateTime.Now;
        }
    }
}
