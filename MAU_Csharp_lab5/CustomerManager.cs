
public class CustomerManager
{
    private List<Customer> allCustomers = new List<Customer>();


    /// <summary>
    /// Add a new customer with contact info
    /// </summary>
    /// <param name="contactInfo"></param>
    public void AddCustomer(ContactInfo contactInfo)
    {
        allCustomers.Add(new Customer(contactInfo));
    }


    /// <summary>
    /// Edit existing customer's contact info.
    /// </summary>
    /// <param name="index">The index of the customer to be edited.</param>
    /// <param name="ci">The contact info object.</param>
    public void EditCustomer(int index, ContactInfo ci)
    {
        allCustomers[index].SetContactInfo(ci);
    }

    /// <summary>
    /// Get one customer object from the list.
    /// </summary>
    /// <param name="index">The index of the custumer to get.</param>
    /// <returns>The customer at the specified index.</returns>
    public Customer GetCustomer(int index)
    {
        return allCustomers[index];
    }


    /// <summary>
    /// Get the customer information as a string.
    /// ID, Names, OfficePhone, OfficeEmail.
    /// </summary>
    /// <returns>The customer information as a string.</returns>
    public string[] GetCustomerString()
    {
        string[] customerString = new string[allCustomers.Count];
        
        for (int i = 0; i < allCustomers.Count; i++)
        {
            Customer c = allCustomers[i];
            string names = allCustomers[i].GetContactInfo().GetLastName().ToUpper() + ", " + allCustomers[i].GetContactInfo().GetFirstName();
            customerString[i] = $"{c.Id,-5}{names,-31}{c.GetContactInfo().GetPhone().GetOfficePhone(),-14}{c.GetContactInfo().GetEmail().GetOfficeEmail(),-15}";
        }
        return customerString;
    }


    public string GetAdditionalInfo(int index)
    {
        Customer c = allCustomers[index];
        string fullName = c.GetContactInfo().GetFirstName() + " " + c.GetContactInfo().GetLastName();
        string street = c.GetContactInfo().GetAdress().Street;
        string zipAndCity = c.GetContactInfo().GetAdress().Zip + " " + c.GetContactInfo().GetAdress().City;
        string country = c.GetContactInfo().GetAdress().Country;
        string emails = $"Emails\n Private\t{c.GetContactInfo().GetEmail().GetPrivateEmail()}\n Office\t\t{c.GetContactInfo().GetEmail().GetOfficeEmail()}";
        string phones = $"Phone numbers\n Private\t{c.GetContactInfo().GetPhone().GetPrivatePhone()}\n Office\t\t{c.GetContactInfo().GetPhone().GetOfficePhone()}";

        return $"{fullName}\n{street}\n{zipAndCity}\n{country}\n\n{emails}\n\n{phones}";
    }


    public void DeleteCustomer(int index)
    {
        allCustomers.RemoveAt(index);
    }
}
