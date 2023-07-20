using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using server.Models;
using server.Models.Guitar;
using server.Models.Guitar.ConcreateGuitars;

namespace server.Data
{
    public class MaestroContext : DbContext
    {
        public MaestroContext(DbContextOptions<MaestroContext> options)
            : base(options) { }


        public DbSet<AcousticGuitar> AcousticGuitar { get; set; }
        public DbSet<ElectricGuitar> ElectricGuitar { get; set; }
        public DbSet<BassGuitar> BassGuitar { get; set; }
        public DbSet<ClassicGuitar> ClassicGuitar { get; set; }
        public DbSet<ElectroacousticGuitar> ElectroacousticGuitar { get; set; }
        public DbSet<UkuleleGuitar> UkuleleGuitar { get; set; }
    }
}
