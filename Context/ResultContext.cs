using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bigbang.Listener.Models;


namespace Bigbang.Listener.Context {
    public class ResultContext : DbContext {
        public ResultContext(DbContextOptions options)
            : base(options) {

        }

        public DbSet<BigResult> result { get; set; }
    }
}
