using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace S2SBookstore.Server.Data
{
    public class AppDBContext:DbContext
    {
        public DbSet<S2SBookstore.Shared.Book> Books { get; set; }
        public AppDBContext(DbContextOptions<AppDBContext> optionsBuilder) : base(optionsBuilder){}
    }
}
