// AnimeClient/Anime.cs
using Newtonsoft.Json;

namespace AnimeClient
{
    public class Anime
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
        public float Rating { get; set; }

        [JsonProperty("Genre")]
        public Genre GenreObj { get; set; }

        [JsonProperty("Studio")]
        public Studio StudioObj { get; set; }

        [JsonIgnore]
        public string Genre => GenreObj?.Name ?? "Неизвестно";

        [JsonIgnore]
        public string Studio => StudioObj?.Name ?? "Неизвестно";
    }

    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Studio
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}