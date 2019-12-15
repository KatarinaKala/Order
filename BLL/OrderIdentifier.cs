namespace Order
{
    //Section 9.3    
    public class OrderIdentifier
    {
        public string Identifier { get; set; }

        public string GetIdentifier()
        {
            //Return unique identifier for the Order
            return Identifier;
        }
    }
}