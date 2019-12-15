namespace Order
{
    public class OrderLineIdentifier
    {
        public string Identifier { get; set; }

        public string GetIdentifier()
        {
            return Identifier;
        }
    }
}