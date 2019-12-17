namespace BLL.Party
{
    public class PartySummary
    {
        private string _name;
        private string _address;
        private int _telephoneNumber;
        private string _emailAddress;
        
        public PartySummary(string name, string address, int telephoneNumber, string emailAddress)
        {
            _name = name;
            _address = address;
            _telephoneNumber = telephoneNumber;
            _emailAddress = emailAddress;
        }
    }
}