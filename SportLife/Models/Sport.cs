using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace SportLife.Models
{
    [Table("tblSport")]
    public class Sport
    {       
        public int id { get; set; }
        public string Name { get; set; }

        public List<Players> Players { get; set; }
    }
}