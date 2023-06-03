using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_App.Models
{
    public class Comment
    {
        public string Id { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Author { get; set; }
        public string BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}
