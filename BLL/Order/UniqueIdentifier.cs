using System;

namespace BLL
{
    public abstract class UniqueIdentifier
    {
        private string _identifier = new Random().Next(10000, 100000).ToString();

        public UniqueIdentifier(string identifier)
        {
            _identifier = identifier;
        }

        public string GetIdentifier()
        {
            return _identifier;
        }
    }
}