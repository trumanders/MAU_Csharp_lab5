public class Adress
{
    private string street;
    private string zip;
    private string city;
    private string country;
    private int countryIndex;

    public string Street { get { return street; } }
    public string Zip { get { return zip; } }
    public string City { get { return city; } }
    public string Country { get { return country; } }
    public int CountryIndex { get { return countryIndex;  } }


    // CONSTRUCTOR
    public Adress(string street, string zip, string city, string country, int countryIndex)
    {
        this.street = street;
        this.zip = zip;
        this.city = city;
        this.country = country;
        this.countryIndex = countryIndex;
    }
}