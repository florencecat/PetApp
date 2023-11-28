namespace PetApp.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void OnLoginClicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }
}