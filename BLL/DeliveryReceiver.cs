using BLL.Party;

namespace BLL
{
    public class DeliveryReceiver : PartySummary
    {

        public DeliveryReceiver(string name, string address, int telephoneNumber, string emailAddress) : base(name, address, telephoneNumber, emailAddress)
        {
        }
    }
}