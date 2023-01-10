﻿using Microsoft.EntityFrameworkCore;
using WebApi.DAL.Entities;

namespace WebApi.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-MC9V08U\\SQLEXPRESS;initial catalog=ApiDb;integrated security=true");
        }
        public DbSet<Category> Categories  { get; set; }
    }
}
