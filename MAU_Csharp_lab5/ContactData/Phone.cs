public class Phone
{
    /// <summary>
    /// This class contains the customer's phone numbers
    /// </summary>
    private string privatePhone;
    private string officePhone;

    public string PrivatePhone { get { return privatePhone; } }
    public string OfficePhone { get { return officePhone; } }

    public Phone(string privatePhone, string officePhone)
    {
        this.privatePhone = privatePhone;
        this.officePhone = officePhone;
    }
}
