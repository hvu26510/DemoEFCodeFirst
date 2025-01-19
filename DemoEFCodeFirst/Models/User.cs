using System.ComponentModel.DataAnnotations;
namespace DemoEFCodeFirst.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public UserProfile Profile { get; set; }
    }
}
