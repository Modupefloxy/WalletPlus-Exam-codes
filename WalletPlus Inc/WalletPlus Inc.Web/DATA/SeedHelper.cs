using WalletPlus_Inc.Web.DATA.Entities;

namespace WalletPlus_Inc.Web.DATA
{
    public class SeedHelper
    {
        public static async Task InitializeData(ApplicationDbContext context)
        {
            //1. Check if Clients acontain data
            if (!context.Customers.Any())
            {
                //2. create sample data

                context.Customers.Add(new Customers

                {
                    FirstName = "Adigun",
                    LastName = "Modupe",
                    MiddleName = "Lawson",
                    Gender = GenderEnum.Female,
                    MaritalStatus = StatusEnums.Married,
                    DateOfBirth = DateTime.Now.AddYears(-20),
                    Country = "Nigeria",
                    State = "Lagos",
                    City = "Ikeja",
                    RegistrationDate = DateTime.Now.AddYears(1),
                });


                context.Customers.Add(new Customers

                {
                    FirstName = "Adigun",
                    LastName = "Modupe",
                    MiddleName = "Lawson",
                    Gender = GenderEnum.Female,
                    MaritalStatus = StatusEnums.Married,
                    DateOfBirth = DateTime.Now.AddYears(-20),
                    Country = "Nigeria",
                    State = "Lagos",
                    City = "Ikeja",
                    RegistrationDate = DateTime.Now.AddYears(1),
                });

                context.Customers.Add(new Customers

                {
                    FirstName = "Veronical",
                    LastName = "Martins",
                    MiddleName = "Isabella",
                    Gender = GenderEnum.Female,
                    MaritalStatus = StatusEnums.Married,
                    DateOfBirth = DateTime.Now.AddYears(-30),
                    Country = "Nigeria",
                    State = "Ibadan",
                    City = "Poly Road",
                    RegistrationDate = DateTime.Now.AddYears(4),
                });

                context.Customers.Add(new Customers

                {
                    FirstName = "Adewunmi",
                    LastName = "Mofe",
                    MiddleName = "Wale",
                    Gender = GenderEnum.male,
                    MaritalStatus = StatusEnums.Single,
                    DateOfBirth = DateTime.Now.AddYears(-10),
                    Country = "Nigeria",
                    State = "Lagos",
                    City = "VGC",
                    RegistrationDate = DateTime.Now.AddYears(3),
                });

                context.Customers.Add(new Customers

                {
                    FirstName = "Adeoye",
                    LastName = "Ola",
                    MiddleName = "Lawal",
                    Gender = GenderEnum.male,
                    MaritalStatus = StatusEnums.Single,
                    DateOfBirth = DateTime.Now.AddYears(-15),
                    Country = "Nigeria",
                    State = "Ondo",
                    City = "Island",
                    RegistrationDate = DateTime.Now.AddYears(2),
                });

                await context.SaveChangesAsync();

            }

            
        }
    }
}
