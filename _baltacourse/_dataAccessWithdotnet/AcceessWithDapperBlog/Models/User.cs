using System.ComponentModel.DataAnnotations.Schema;

namespace AccessWithDapperBlog.Models
{

    [Table("[User]")]
    public class User
    {
        public int ID { get; set; }
        public string? Name { get; set; }
    
        public string? Email { get; set; }

        public string? PasswordHash { get; set; }

        public string? Bio { get; set; }

        public string? Image { get; set; }

        public string? Slug { get; set; }
    }
}