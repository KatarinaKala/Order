namespace BLL.Order
{
    public class OrderLineIdentifier : UniqueIdentifier
    {
        public OrderLineIdentifier(string identifier) : base(identifier)
        {
        }
    }
}