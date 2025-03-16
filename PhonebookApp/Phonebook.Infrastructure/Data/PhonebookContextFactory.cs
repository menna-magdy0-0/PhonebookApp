using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Infrastructure.Data
{
    public class PhonebookContextFactory : IDesignTimeDbContextFactory<PhonebookContext>
    {
        public PhonebookContext CreateDbContext(string[] args)
        {
        
            var configuration = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json")
             .Build();

            var builder = new DbContextOptionsBuilder<PhonebookContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");


           builder.UseNpgsql(connectionString, b =>
                b.MigrationsAssembly(typeof(PhonebookContext).Assembly.FullName));

            return new PhonebookContext(builder.Options);
        }
    
    }
}
