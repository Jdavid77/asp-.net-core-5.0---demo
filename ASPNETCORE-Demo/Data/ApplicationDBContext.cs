using ASPNETCORE_Demo.Models;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;


namespace ASPNETCORE_Demo.Data
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }

        public DbSet<Expenses> Expenses { get; set; }



    }
}