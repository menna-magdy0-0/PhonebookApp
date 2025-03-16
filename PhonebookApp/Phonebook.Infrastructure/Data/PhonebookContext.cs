using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phonebook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Phonebook.Infrastructure.Data
{
    public class PhonebookContext : IdentityDbContext<ApplicationUser>
    {
        public PhonebookContext(DbContextOptions<PhonebookContext> options) : base(options)
        {
        }
        public DbSet<Contact> Contact { get; set; }
    }
}
