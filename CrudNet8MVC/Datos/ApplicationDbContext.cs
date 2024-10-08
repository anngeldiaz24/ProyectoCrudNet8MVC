﻿using CrudNet8MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudNet8MVC.Datos
{
    // CONSTRUCTOR PARA CREAR CONTEXTO Y TRABAJAR CON LA DATABASE
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        // Agregar los modelos aquí (Cada modelo corresponde a una tabla en la BD)
        public DbSet<Contacto> Contacto { get; set; }
    }
}
