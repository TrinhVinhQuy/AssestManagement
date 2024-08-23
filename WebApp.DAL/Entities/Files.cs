using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.DAL.Entities
{
    public class Files
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }

        [ForeignKey(nameof(Folders))]
        public int FolderId { get; set; }
        public Folders Folder { get; set; }
    }
}
