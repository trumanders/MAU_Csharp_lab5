public class CustomerManager
{
    private List<Customer> allCustomers = new List<Customer>();

    /// <summary>
    /// Check if the list of customers contains customers.
    /// </summary>
    /// <returns>Boolean that determines whether the list is empty or not. True = empty</returns>
    public bool isCustomerListEmpty()
    {
        if (allCustomers.Count == 0)
            return true;
        return false;
    }


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
            string names = c.GetContactInfo().LastName.ToUpper() + ", " + c.GetContactInfo().FirstName;
            customerString[i] = $"{c.Id,-5}{names,-31}{c.GetContactInfo().Phone.OfficePhone,-14}{c.GetContactInfo().Email.OfficeEmail,-15}";
        }
        return customerString;
    }


    /// <summary>
    /// Gather all info for a customer and return it as a formatted string.
    /// </summary>
    /// <param name="index">The integer representing the index of the
    /// selected customer in the list.</param>
    /// <returns>A formatted string containing all info on a customer to be displayd in the UI.</returns>
    public string GetAdditionalInfo(int index)
    {
        ContactInfo ci = allCustomers[index].GetContactInfo();        
        string fullName = ci.FirstName + " " + ci.LastName;
        string street = ci.Adress.Street;
        string zipAndCity = ci.Adress.Zip + " " + ci.Adress.City;
        string country = ci.Adress.Country;
        string emails = $"Emails\n Private\t{ci.Email.PrivateEmail}\n Office\t\t{ci.Email.OfficeEmail}";
        string phones = $"Phone numbers\n Private\t{ci.Phone.PrivatePhone}\n Office\t\t{ci.Phone.OfficePhone}";
        return $"{fullName}\n{street}\n{zipAndCity}\n{country}\n\n{emails}\n\n{phones}";
    }


    /// <summary>
    /// Delete one customer with the specified index.
    /// </summary>
    /// <param name="index">The index of the selected customer</param>
    public void DeleteCustomer(int index)
    {
        allCustomers.RemoveAt(index);
    }
}
