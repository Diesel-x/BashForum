namespace BashForum.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public int Id_thread { get; set; }
        public int Id_author { get; set; }
    }
}
