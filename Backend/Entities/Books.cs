namespace Backend.Entities
{
    public class Books
    {
        public int Books_id { get; set; }
        public string Title { get; set; }
        public string Descriptions { get; set; }
        public string Isbn { get; set; }
        public int Publisher_id { get; set; }
        public int Genre_id { get; set; }
        public string Cover_image_url { get; set; }
        public string Book_Language { get; set; }
        public string Book_length { get; set; }
        public int File_size { get; set; }
        public string noteworthy { get; set; }
        public int Sales_count { get; set; }
        public int View_count { get; set; }
        public int Promotion_id { get; set; }

    }
}
