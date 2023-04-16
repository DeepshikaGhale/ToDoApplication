using System;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using ToDoApplication.Data;
using ToDoApplication.Models;

namespace ToDoApplication.Data
{
	public class ToDoContext : DbContext
	{
        public ToDoContext(DbContextOptions<ToDoContext> options)
           : base(options) //sends the options to the db context , this makes the configuration works externally
        {

        }
        //creates a table called ToDos
        public DbSet<ToDo> ToDos => Set<ToDo>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add data to table with Todo model.
            modelBuilder.Entity<ToDo>().HasData(new ToDo {ID=1, Title = "Prepare Breakfast", IsComplete = false });
            modelBuilder.Entity<ToDo>().HasData(new ToDo {ID=2, Title = "Eat", IsComplete = false });
            modelBuilder.Entity<ToDo>().HasData(new ToDo {ID=3, Title = "Clean Room", IsComplete = false });
        }
    }
}