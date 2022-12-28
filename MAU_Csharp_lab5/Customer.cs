public class Customer
{
    private ContactInfo contactInfo;
    private static int countingId = 0;   // Counts the number of customers
    private string id;      // String representation of the number of customers, with leading zeros: 0001
    public string Id { get { return id; } }


    // CONSTRUCTOR
    public Customer(ContactInfo contactInfo)
    {
        countingId++;
        string format = "{0:0000}";
        this.id = string.Format(format, Convert.ToInt32(countingId));
        this.contactInfo = contactInfo;
    }


    /// <summary>
    /// Get one contactInfo object from the customer
    /// </summary>
    /// <returns>One ContactInfo -object.</returns>
    public ContactInfo GetContactInfo()
    {
        return this.contactInfo;
    }


    /// <summary>
    /// Assign a ContactInfo -object to the user's contactInfo -variable
    /// </summary>
    /// <param name="contactInfo">The ContactInfo parameter to assign to the Customer.</param>
    public void SetContactInfo(ContactInfo contactInfo)
    {
        this.contactInfo = contactInfo;
    }
}
