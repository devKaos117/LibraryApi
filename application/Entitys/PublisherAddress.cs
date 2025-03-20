namespace Application.Entitys;

public class PublisherAddress 
{
    public int Id { get; set; }
    public string ZipCode { get; set; }
    public string StreetName { get; set; }
    public string Number { get; set; }
    public string Complement { get; set; }
    public string district { get; set; }
    public string city { get; set; }
    public string state { get; set; }

    public ICollection<PublisherContact> Contacts { get; set; } = new List<PublisherContact>();
}
