using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using src.Models;

namespace src.API
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext() : base("name=ApplicationDbContext")
		{ }

		public DbSet<Todo> Todoes { get; set; }
	}
}
