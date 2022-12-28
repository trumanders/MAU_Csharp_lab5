public class ContactInfo
{
    /// <summary>
    /// This class contains the customer's adress information
    /// </summary>
    private string firstName;
    private string lastName;
    private Adress adress;
    private Phone phone;
    private Email email;

    public string FirstName { get { return firstName; } }
    public string LastName { get { return lastName; } }
    public Adress Adress { get { return adress; } }
    public Phone Phone { get { return phone; } }
    public Email Email { get { return email; } }

    public bool isAdded = false;

    public ContactInfo() { }

    // CONSTRUCTOR
    public ContactInfo(string fName, string lName, Adress adress, Phone phone, Email email) 
    {
        this.firstName = fName;
        this.lastName = lName;
        this.adress = adress;
        this.phone = phone;
        this.email = email;
    }

    /// <summary>
    /// Set all contact information (in the case of editing, when the constructor is not used)
    /// </summary>
    /// <param name="firstName">The user entered string from the first name textbox in the UI.</param>
    /// <param name="lastName">The user entered string from the last name textbox in the UI.</param>
    /// <param name="adress">The adress object created from the user entered string from the adress textboxes in the UI.</param>
    /// <param name="phone">The adress object created from the user entered string from the phone textboxes in the UI.</param>
    /// <param name="email">The adress object created from the user entered string from the email textboxes in the UI.</param>
    public void SetAll(string firstName, string lastName, Adress adress, Phone phone, Email email)
    {        
        this.firstName = firstName;
        this.lastName = lastName;
        this.adress = adress;
        this.phone = phone;
        this.email = email;
    }    
}