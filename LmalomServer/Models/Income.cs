using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LmalomServer.Models
{
    public class Income
    {
        [Key]
        public int Id { get; set; }

        public int Date { get; set; }

        [Required]
        public int Amount { get; set; }

        public String Description { get; set; }

        public virtual Category Category { get; set; }
     
    }
}
