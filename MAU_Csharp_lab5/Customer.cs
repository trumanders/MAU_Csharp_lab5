using System;

public class Customer
{
    private ContactInfo contactInfo;
    private static int countingId = 0000;
    private string id;
    public string Id { get { return id; } }


    public Customer(ContactInfo contactInfo)
    {
        countingId++;
        string format = "{0:0000}";
        this.id = string.Format(format, Convert.ToInt32(countingId));

        this.contactInfo = contactInfo;
    }


    public ContactInfo GetContactInfo()
    {
        return this.contactInfo;
    }
    public void SetContactInfo(ContactInfo contactInfo)
    {
        this.contactInfo = contactInfo;
    }
}
