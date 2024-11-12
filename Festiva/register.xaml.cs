namespace Festiva;

public partial class register : ContentPage
{
    public register()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        string Firstname = EntryFirstname.Text;
        string Lastname = EntryLastname.Text;
        string Tel = EntryTel.Text;
        string Email = EntryEmail.Text;
        string Password = EntryPassword.Text;
    }

}