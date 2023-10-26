using BashForum.Areas.Identity.Data;

namespace BashForum.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public BashForumUser Author { get; set; }
    }
}
