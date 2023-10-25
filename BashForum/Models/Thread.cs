namespace BashForum.Models
{
    public partial class Thread
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Text { get; set; }

        public int Id_author { get; set; }
    }
}
