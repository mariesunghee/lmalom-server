using System;
using System.ComponentModel.DataAnnotations;

namespace LmalomServer.Models
{
    public class Account
    {   
        public enum AccountType { Cash, Loan, credit }
        
        [Key]
        public int Id { get; set; }

        [Required]//Not Null
        public String Name { get; set; }

        public AccountType Type { get; set; }

        public int Balance { get; set; }

        public int? Limit { get; set; }

        public DateTime? DueDate { get; set; }
    }
}
