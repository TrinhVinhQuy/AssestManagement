using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.DAL.Entities
{
    public class Drives
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string DriveName { get; set; }
        public int DriveOwnerId { get; set; }
        public Users DriveOwner { get; set; }
        public ICollection<Folders> Folders { get; set; }
    }
}
