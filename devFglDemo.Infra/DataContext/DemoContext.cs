using System;
using devDemo.Infra.Mappings;
using devFglDemo.Domain.Entities;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;

namespace devDemo.Infra.DataContext
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions options)
        : base(options) { }


        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserMap());

            modelBuilder.Ignore<Notification>();
        }
    }
}
