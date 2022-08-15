using Microsoft.EntityFrameworkCore;
using WalletPlus_Inc.Web.DATA.Entities;

namespace WalletPlus_Inc.Web.DATA.Configuration
{
    public static class CustomersConfigurations
    {
        public static ModelBuilder Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>().Property(c => c.FirstName).IsRequired(true).HasMaxLength(100).HasColumnName("First_Name");
            modelBuilder.Entity<Customers>().Property(c => c.LastName).IsRequired(true).HasMaxLength(100);
            modelBuilder.Entity<Customers>().Property(c => c.MiddleName).HasMaxLength(50);
            modelBuilder.Entity<Customers>().Property(c =>c.City).IsRequired(true).HasMaxLength(50);
            modelBuilder.Entity<Customers>().Property(c=> c.Country).IsRequired(true).HasMaxLength(50);
            modelBuilder.Entity<Customers>().Property(c => c.MaritalStatus);
            modelBuilder.Entity<Customers>().Property(c => c.DateOfBirth).IsRequired(true).HasMaxLength(15);
            modelBuilder.Entity<Customers>().Property(c => c.RegistrationDate).IsRequired(true).HasMaxLength(15);
            modelBuilder.Entity<Customers>().Property(c => c.Gender).IsRequired();
            modelBuilder.Entity<Customers>().Property(c => c.State).IsRequired();
            return modelBuilder;


        }
    }
}
