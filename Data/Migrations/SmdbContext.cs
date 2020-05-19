using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
	public class SmdbContext : IdentityDbContext
	{
		public SmdbContext(DbContextOptions<SmdbContext> options)
			: base(options)
		{
		}
		public DbSet<StudentLiteModel> Students { get; set; }
	}
}
