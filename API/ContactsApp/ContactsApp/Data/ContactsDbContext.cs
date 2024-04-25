using ContactsApp.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ContactsApp.Data
{
    public class ContactsDbContext : DbContext
    {
        public ContactsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
