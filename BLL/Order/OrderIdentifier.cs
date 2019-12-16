namespace BLL.Order
{
    public class OrderIdentifier : UniqueIdentifier
    {
        public OrderIdentifier(string identifier) : base(identifier)
        {
        }
    }
}