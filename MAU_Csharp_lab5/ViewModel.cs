namespace MAU_Csharp_lab5;
public class ViewModel
{
    public string[] Countries { get; private set; }

    /// <summary>
    /// Pupulate the country combobox.
    /// </summary>
    public ViewModel()
    {
        Countries = new string[] { "Denmark", "Finland", "Iceland", "Norway", "Sweden" };
    }
}
