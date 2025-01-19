using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoEFCodeFirst.Models
{
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        [ForeignKey("User")]
        public int UserID {  get; set; }

        public User User { get; set; }
    }
}
