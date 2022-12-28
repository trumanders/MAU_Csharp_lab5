public class Email
{
    /// <summary>
    /// This class contains the customer's emails.
    /// </summary>
    private string privateEmail;
    private string officeEmail;

    public string PrivateEmail { get { return privateEmail; } }
    public string OfficeEmail { get { return officeEmail; } }

    public Email(string privateEmail, string officeEmail)
    {
        this.privateEmail = privateEmail;
        this.officeEmail = officeEmail;
    }
}
