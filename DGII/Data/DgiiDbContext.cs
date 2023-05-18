using Microsoft.EntityFrameworkCore;
using DGII.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGII.Data
{
    public class DgiiDbContext:DbContext
    {
       
        public DgiiDbContext(DbContextOptions<DgiiDbContext> options): base(options)
        {

        }

        public DbSet<Contribuyente> Contribuyentes { get; set; }
        public DbSet<ComprobanteFiscal> ComprobantesFiscales { get; set; }
    }
}
