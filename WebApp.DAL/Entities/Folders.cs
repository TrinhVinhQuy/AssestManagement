using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApp.DAL.Entities
{
    public class Folders
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string FolderName { get; set; }
        public int? ParentFolderId { get; set; }
        public Folders ParentFolder { get; set; }
        public ICollection<Folders> Subfolders { get; set; }
        public ICollection<Files> Files { get; set; }
    }
}
