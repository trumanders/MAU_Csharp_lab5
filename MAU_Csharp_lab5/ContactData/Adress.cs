public class Adress
{
    private string street;
    private string zip;
    private string city;
    private string country;

    public string Street { get; }
    public string Zip { get; }
    public string City { get; }
    public string Country { get; }

    public Adress(string street, string zip, string city, string country)
    {
        this.street = street;
        this.zip = zip;
        this.city = city;
        this.country = country;
    }
}


