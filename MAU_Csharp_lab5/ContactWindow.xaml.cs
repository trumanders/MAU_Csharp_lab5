namespace MAU_Csharp_lab5;

/// <summary>
/// Interaction logic for ContactWindow.xaml
/// </summary>
public partial class ContactWindow : Window
{
    private ContactInfo contactInfo;
    private bool allRequiredFieldsEntered = false;


    // CONSTRUCTOR FOR ADDING / EDITING
    public ContactWindow(ContactInfo ci, bool isEditing)
    {
        InitializeComponent();
        this.contactInfo = ci;
        if (isEditing)
        {
            SetExistingContactInfo();
            ToggleButtonAndText(true);  // Don't disable buttons as default when editing
        }
        else
        {
            ToggleButtonAndText(false);
        }

        ViewModel vm = new ViewModel();

        // Call the ok-button- and warning text method to set the ok-button to it's
        // default state (disabled button and enabled warning text)
       
    }


    /// <summary>
    /// Actions taken when OK-button is clicked. The contactInfo-object is updated.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btn_ok_click(object sender, RoutedEventArgs e)
    {
        Adress adress = new Adress(tbx_street.Text, tbx_zipCode.Text, tbx_city.Text, cbx_country.SelectedItem.ToString(), cbx_country.SelectedIndex);
        Phone phone = new Phone(tbx_privatePhone.Text, tbx_officePhone.Text);
        Email email = new Email(tbx_privateEmail.Text, tbx_officeEmail.Text);
        MessageBox.Show("" + phone.PrivatePhone);
        contactInfo.SetAll(tbx_firstName.Text, tbx_lastName.Text, adress, phone, email);
        contactInfo.isAdded = true;
        this.Close();
    }


    /// <summary>
    /// Exits the contact form without saving the user input
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btn_cancel_click(object sender, RoutedEventArgs e)
    {
        if (MessageBox.Show("Do you really want to close?", "Close contact window", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
        {
            this.Close();
        }           
    }


    /// <summary>
    /// Set the contact form's text boxes to the existing contact info,
    /// useful when edit-button is clicked
    /// </summary>
    private void SetExistingContactInfo()
    {
        tbx_firstName.Text = contactInfo.FirstName;
        tbx_lastName.Text = contactInfo.LastName;
        tbx_privatePhone.Text = contactInfo.Phone.PrivatePhone;
        tbx_privatePhone.Text = contactInfo.Phone.OfficePhone;
        tbx_privateEmail.Text = contactInfo.Email.PrivateEmail;
        tbx_officeEmail.Text = contactInfo.Email.OfficeEmail;
        tbx_street.Text = contactInfo.Adress.Street;
        tbx_city.Text = contactInfo.Adress.City;
        tbx_zipCode.Text = contactInfo.Adress.Zip;
        cbx_country.SelectedIndex = contactInfo.Adress.CountryIndex;
    }


    /// <summary>
    /// Check whether required info is entered when first name textbox is changed,
    /// and toggle the ok-button based on that
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void tbx_firstName_changed(object sender, TextChangedEventArgs e)
    {
        ToggleButtonAndText(IsAllRequiredInfoEntered());
    }


    /// <summary>
    /// Check whether required info is entered when last name textbox is changed,
    /// and toggle the ok-button based on that
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void tbx_lastName_changed(object sender, TextChangedEventArgs e)
    {
        ToggleButtonAndText(IsAllRequiredInfoEntered());
    }


    /// <summary>
    /// Check whether required info is entered when the city textbox is changed,
    /// and toggle the ok-button based on that
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void tbx_city_changed(object sender, TextChangedEventArgs e)
    {
        ToggleButtonAndText(IsAllRequiredInfoEntered());
    }


    /// <summary>
    /// Check whether required info is entered when the country combobox is changed,
    /// and toggle the ok-button based on that
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void cbx_country_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        ToggleButtonAndText(IsAllRequiredInfoEntered());
    }


    /// <summary>
    /// Check if all required info is entered by the user. Required info is firstName or lastName,
    /// city and country.
    /// </summary>
    /// <param name="fName">The string representing the first name textbox</param>
    /// <param name="lName">The string representing the last name textbox</param>
    /// <param name="city">The string representing the city textbox</param>
    /// <param name="country">The string representing the country textbox</param>
    /// <returns></returns>
    private bool IsAllRequiredInfoEntered()
    {
        // If both first and last name is empty - false
        if ((tbx_firstName.Text == null || tbx_firstName.Text == "") && (tbx_lastName.Text == null || tbx_lastName.Text == ""))
            return false;

        // If city OR country is not entered - return false
        if (cbx_country.SelectedItem == null || (tbx_city.Text == null || tbx_city.Text == ""))
            return false;
        return true;
    }


    /// <summary>
    /// Enable or disable ok-button and warning text based in the data entered by the user.
    /// </summary>
    /// <param name="isEnabled">Boolean that determines if the button should be enabled or not.</param>
    private void ToggleButtonAndText(bool isEnabled)
    {
        if (isEnabled)
        {
            btn_ok.IsEnabled = true;
            lbl_warningText.Content = "";
        }
        else
        {
            btn_ok.IsEnabled = false;
            lbl_warningText.Content = "Please provide at least first or last name, city and country";
        }
    }
}
