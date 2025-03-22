using System;

public class ReviewDto
{
    public int Id { get; set; }
    public int AnimeId { get; set; }
    public int UserId { get; set; }
    public string Text { get; set; }
    public string Username { get; set; }
    public DateTime CreatedAt { get; set; }
}