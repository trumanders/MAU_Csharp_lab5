namespace MAU_Csharp_lab5;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private CustomerManager customerManager = new CustomerManager();
    private bool isEditing;
    private int selectedEditIndex;
    public MainWindow()
    {
        InitializeComponent();
        //ViewModel vm = new ViewModel();
    }

    /// <summary>
    /// Actions taken when ADD-button is clicked. An empty contact object is created
    /// and passed to the contactWindow where it is seeded with data.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btn_add_click(object sender, RoutedEventArgs e)
    {
        
        ContactInfo newContactInfo = new ContactInfo();                        
        ContactWindow cw = new ContactWindow(newContactInfo, isEditing=false);
        cw.ShowDialog();

        // Pass in the newly updated contact object and pass it to the addCustomer-method.
        if (newContactInfo.isAdded)
        {
            customerManager.AddCustomer(newContactInfo);
        }            

        // Display the data
        UpdatePeopleList();
    }


    /// <summary>
    /// Actions taken when EDIT-button is clicked. A specific customer's
    /// contactInfo is passed to the contactWindow, which is then updated with new data.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btn_edit_click(object sender, RoutedEventArgs e)
    {
        if (!ListboxSelectedItemIsNull())
        {
            selectedEditIndex = lbx_peopleList.SelectedIndex;

            // Pass the selected customer's contactInfo to ContactWindow plus the country index
            ContactWindow cw = new ContactWindow(customerManager.GetCustomer(selectedEditIndex).GetContactInfo(), isEditing=true);
            cw.ShowDialog();               
        }

        // Display the updated data.
        UpdatePeopleList();
        lbx_peopleList.SelectedIndex = selectedEditIndex;
    }


    /// <summary>
    /// Call the delete method to delete the selected item in the listbox. Also
    /// checks if somehting is selected.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btn_delete_click(object sender, RoutedEventArgs e)
    {
        if (!ListboxSelectedItemIsNull())
        {
            customerManager.DeleteCustomer(lbx_peopleList.SelectedIndex);
        }
        UpdatePeopleList();
    }    


    /// <summary>
    /// Actions to take when something in the listbox is selected
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void lbx_selected(object sender, SelectionChangedEventArgs e)
    {
        MessageBox.Show("" + lbx_peopleList.SelectedIndex);
        int index = lbx_peopleList.SelectedIndex;
        if (index < 0 && customerManager.isCustomerListEmpty())
        {
            lbl_additionalInfo.Content = "";
            return;
        }
        if (index < 0)
            index = selectedEditIndex;        
        lbl_additionalInfo.Content = customerManager.GetAdditionalInfo(index);
    }

    /// <summary>
    /// Set the listbox content to show the customers
    /// </summary>
    private void UpdatePeopleList()
    {
        lbx_peopleList.ItemsSource = null;
        if (customerManager.isCustomerListEmpty())
            return;
        lbx_peopleList.ItemsSource = customerManager.GetCustomerString();
    }


    /// <summary>
    /// Check if something is selected in the Listbox. If not,
    /// show message box.
    /// </summary>
    /// <returns>True if selected listbox item is null, otherwise return false</returns>
    private bool ListboxSelectedItemIsNull()
    {
        if (lbx_peopleList.SelectedItem == null)
        {
            MessageBox.Show("Please select something to edit");
            return true;
        }
        else return false;
    }
}