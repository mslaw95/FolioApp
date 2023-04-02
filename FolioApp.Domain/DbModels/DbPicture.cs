using System.ComponentModel.DataAnnotations.Schema;

namespace FolioApp.Domain.DbModels
{
    public class DbPicture
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Uri Uri { get; set; }
    }
}
