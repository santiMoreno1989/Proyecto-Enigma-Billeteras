using enigmaBilleteras.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication2.Data
{
    public class ApplicationDbContext : IdentityDbContext<miUsuario>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<billetera> billeteras { get; set; }
        public DbSet<miUsuario> usuarios { get; set; }
    }
}
