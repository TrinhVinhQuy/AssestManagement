using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApp.Common.Enums;

namespace WebApp.DAL.Entities
{
    public class Permissions
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public Role Role { get; set; }
        [ForeignKey(nameof(Users))]
        public int UserId { get; set; }
        public Users Users { get; set; }
        [ForeignKey(nameof(Folders))]
        public int FolderId { get; set; }
        public Folders Folders { get; set; }
    }
}
