using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_Auth.Data.Entities;

namespace WinForms_Auth.Data
{
    class AppDbContext : DbContext
    {

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Discount> Discounts { get; set; }

        private string sqlConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\37182\Source\Repos\WinForms_Auth2\DBFiles\Database_Auth.mdf;Integrated Security=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(sqlConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasMany(u => u.Roles)
                .WithMany(r => r.Users)
                .UsingEntity(j => j.ToTable("z_UserRoles"));
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role);

            Role r_admin = new Role { Id = Guid.NewGuid(), Name = "Admin" };
            Role r_guest = new Role { Id = Guid.NewGuid(), Name = "Guest" };

            User admin = new User
            {
                Id = Guid.NewGuid(),
                Name = "Admin",
                Email = "admin@admin.com",
                RoleId = r_admin.Id
            };

            modelBuilder.Entity<User>()
                .Property(u => u.RoleId)
                .HasDefaultValue(r_guest.Id);

            modelBuilder.Entity<Role>().HasData(r_admin);
            modelBuilder.Entity<Role>().HasData(r_guest);
            modelBuilder.Entity<User>().HasData(admin);
        }
    }
}
