using BashForum.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace BashForum.Models
{
    public partial class Thread
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Text { get; set; }

        [ForeignKey("CategoryInfoKey")]
        public BashForumUser Author { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
