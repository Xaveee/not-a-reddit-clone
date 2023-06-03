using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_App.Models
{
    public class BlogPost
    {
        public string Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Author { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
