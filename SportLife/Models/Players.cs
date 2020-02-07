using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SportLife.Models
{
    [Table("tblPlayers")]
    public class Players
    {
        [Key]
        public int playerID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; } 
        
        public int SportID { get; set; }

        
        
    }
}