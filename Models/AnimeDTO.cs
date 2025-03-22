namespace AnimeClient.Models
{
    public class AnimeDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
        public float Rating { get; set; }
        public string Genre { get; set; }
        public string Studio { get; set; }
        public string ImageUrl { get; set; } // Добавьте это свойство
    }
}