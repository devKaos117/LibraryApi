namespace Application.Entitys;

public class Book
{
    public int Id { get; set; }
    public string Isbn13 { get; set; }
    public string Title { get; set; }
    public string SubTitle { get; set; }
    public string Language { get; set; }
    public DateTime Release { get; set; }
    public string Descritption { get; set; }

    class PhysicalProperties
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth{ get; set; }
        public int Pages { get; set; }
        public bool Hardcover { get; set; }
    }

    public ICollection<Genre> Genres { get; set; } = new List<Genre>();
    public ICollection<Author> Authors { get; set; } = new List<Author>();
}