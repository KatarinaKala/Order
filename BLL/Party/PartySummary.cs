namespace BLL.Party
{
    public class PartySummary
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int TelephoneNumber { get; set; }
        public string EmailAddress { get; set; }
        
        public PartySummary(string name, string address, int telephoneNumber, string emailAddress)
        {
            Name = name;
            Address = address;
            TelephoneNumber = telephoneNumber;
            EmailAddress = emailAddress;
        }
    }
}