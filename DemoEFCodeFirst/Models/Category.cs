using System.ComponentModel.DataAnnotations;

namespace DemoEFCodeFirst.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Product> products { get; set; }
    }
}
