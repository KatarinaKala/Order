using System;

namespace BLL
{
    public class Discount
    {
        private string _reason;
        private int _amount;
        
        public Discount(string reason, int amount)
        {
            _reason = reason;
            _amount = amount;
        }
    }
}