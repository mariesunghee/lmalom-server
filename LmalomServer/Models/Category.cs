using System.ComponentModel.DataAnnotations;

namespace LmalomServer.Models
{
    public class Category
    {
        public enum CategoryGroup {Expense,Income}

        [Key]
        public int Id { get; set; }

        public string Names { get; set; }

        public CategoryGroup Group { get; set; }

    }
}
