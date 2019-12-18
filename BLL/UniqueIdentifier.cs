using System;

namespace BLL
{
    public abstract class UniqueIdentifier
    {
        private string _identifier;

        public UniqueIdentifier(string identifier)
        {
            _identifier = identifier;
        }

        public string GetIdentifier()
        {
            return _identifier;
        }

        public override string ToString()
        {
            return _identifier;
        }
    }
}