using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCo.ConsultaVeiculos.WebAPI.Models
{
    public class VeiculosContext:DbContext
    {
        public VeiculosContext(DbContextOptions<VeiculosContext> options) : base(options)
        {

        }

        public DbSet<Veiculos> Veiculos { get; set; }
    }
}
