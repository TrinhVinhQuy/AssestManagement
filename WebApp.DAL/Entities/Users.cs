using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApp.DAL.Entities
{
    public class Users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public ICollection<Drives> Drives { get; set; }
        public ICollection<Permissions> Permissions { get; set; }
    }

}
