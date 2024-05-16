using ClienteApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClienteApi.Context
{
    public class AppDbContext: DbContext
    {
        //Configure la Conexion de mi modelo a la base de datos
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }
        //Especifique cual de todos mis modelos se enviara a la base de datos por EF
        public DbSet<Empleados>Empleados { get; set;}
    }
}
