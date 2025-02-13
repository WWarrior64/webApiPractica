using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace webApiPractica.Models
{
	public class equiposContext : DbContext
	{
		public equiposContext(DbContextOptions<equiposContext> options) : base(options) 
		{
			
		}

		public DbSet<equipos> equipos { get; set; }
		public DbSet<marcas> marcas { get; set; }
		public DbSet<tipo_equipo> tipo_equipo { get; set; }
		public DbSet<estados_equipo> estados_equipo { get; set; }
	}
}
