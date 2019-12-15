namespace Order
{
    public class PartySummary
    {
        public PartyIdentifier Identifier { get; set; }
        public PartyRoleIdentifier RoleIdentifier { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}