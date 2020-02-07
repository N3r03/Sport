using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportLife.Models
{
    public class PlayersContext : DbContext
    {
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Players> Players { get; set; }
        
    }
}