using System.ComponentModel.DataAnnotations;
using MAU_Csharp_lab5.ContactData;

public class ContactInfo
{
    private string firstName;
    private string lastName;
    private Adress adress;
    private Phone phone;
    private Email email;

    public bool isAdded = false;

    public ContactInfo() { }

    public ContactInfo(string fName, string lName, Adress adress, Phone phone, Email email) 
    {
        this.firstName = fName;
        this.lastName = lName;
        this.adress = adress;
        this.phone = phone;
        this.email = email;
    }

    public void SetAll(string firstName, string lastName, Adress adress, Phone phone, Email email)
    {
        isAdded = true; 
        this.firstName = firstName;
        this.lastName = lastName;
        this.adress = adress;
        this.phone = phone;
        this.email = email;
    }

    public string GetFirstName()
    {
        return firstName;
    }

    public string GetLastName()
    {
        return lastName;
    }

    public Adress GetAdress()
    {
        return this.adress;
    }


    public Phone GetPhone()
    {
        return this.phone;
    }


    public Email GetEmail()
    {
        return this.email;
    }
}
