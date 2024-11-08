using HW18.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18.Data
{
    public class AppDbContext : DbContext
    {
		public virtual DbSet<Car> Cars => Set<Car>();

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer();
		}
	}
}
