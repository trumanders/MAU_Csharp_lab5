using MAU_Csharp_lab5.ContactData;

namespace MAU_Csharp_lab5;

/// <summary>
/// Interaction logic for ContactWindow.xaml
/// </summary>
public partial class ContactWindow : Window
{
    private ContactInfo contactInfo;


    // CONSTRUCTOR FOR ADDING / EDITING
    public ContactWindow(ContactInfo ci, bool isEditing)
    {
        InitializeComponent();
        this.contactInfo = ci;
        if (isEditing)
            SetExistingContactInfo();
    }

    /// <summary>
    /// Actions taken when OK-button is clicked. The contactInfo-object is updated.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void btn_ok_click(object sender, RoutedEventArgs e)
    {
        Adress adress = new Adress(tbx_street.Text, tbx_city.Text, tbx_zipCode.Text, cbx_country.Text);
        Phone phone = new Phone(tbx_privatePhone.Text, tbx_officePhone.Text);
        Email email = new Email(tbx_privateEmail.Text, tbx_officeEmail.Text);
        contactInfo.SetAll(tbx_firstName.Text, tbx_lastName.Text, adress, phone, email);       
        this.Close();
    }


    public void btn_cancel_click(object sender, RoutedEventArgs e)
    {
        if (MessageBox.Show("Do you really want to close?", "Close contact window", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
        {
            this.Close();
        }           
    }

    /// <summary>
    /// Set the contact form's text boxes to the existing contact info when edititng
    /// </summary>
    private void SetExistingContactInfo()
    {
        tbx_firstName.Text = contactInfo.GetFirstName();
        tbx_lastName.Text = contactInfo.GetLastName();
        tbx_privatePhone.Text = contactInfo.GetPhone().GetPrivatePhone();
        tbx_privatePhone.Text = contactInfo.GetPhone().GetOfficePhone();
        tbx_privateEmail.Text = contactInfo.GetEmail().GetPrivateEmail();
        tbx_officeEmail.Text = contactInfo.GetEmail().GetOfficeEmail();
        tbx_street.Text = contactInfo.GetAdress().Street;
        tbx_city.Text = contactInfo.GetAdress().City;
        tbx_zipCode.Text = contactInfo.GetAdress().Zip;         
    }
}
