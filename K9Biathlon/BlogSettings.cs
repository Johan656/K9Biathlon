namespace K9Biathlon
{
    public class BlogSettings
    {
        public string Owner { get; set; } = "The Owner";
        public int PostsPerPage { get; set; } = 4;
        public int CommentsCloseAfterDays { get; set; } = 365;
    }
}