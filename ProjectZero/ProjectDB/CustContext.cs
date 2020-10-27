using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectDB.Models;

namespace ProjectDB
{
    public class CustContext : DbContext
    {
        public DbSet<Customer> Customer {get;set;}
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

            if(!optionsBuilder.IsConfigured){

                var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

                var connectionString = configuration.GetConnectionString("KahlerJacob-Project0");
                optionsBuilder.UseNpgsql(connectionString);
            }
        }
    }
}