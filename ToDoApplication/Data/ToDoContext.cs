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
        //creates a table caleed Blogs
        public DbSet<ToDo> Blogs => Set<ToDo>();

    }
}


