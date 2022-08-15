namespace WalletPlus_Inc.Web.DATA.Entities
{
    public class Customers
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public GenderEnum Gender { get; set; }
        public StatusEnums MaritalStatus { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public DateTime RegistrationDate { get; set; }


    }
}
