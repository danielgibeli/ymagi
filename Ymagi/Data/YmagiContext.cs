using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Ymagi.Models
{
    public class YmagiContext : DbContext
    {
        public YmagiContext (DbContextOptions<YmagiContext> options)
            : base(options)
        {
        }

        public DbSet<Ymagi.Models.Usuario> Usuario { get; set; }
    }
}
