namespace Application.Models;

class Publisher
{
    public int Id { get; set; }
    public string Tin { get; set; }
    public string FtidCode { get; set; }
    public string Name { get; set; }
    public DateTime Foundation { get; set; }

    public ICollection<PublisherAddress> Addresses { get; set; } = new List<PublisherAddress>();
}