namespace PetApp.Views;

public partial class Calendar : ContentPage
{
	private readonly ViewModels.Calendar viewModel;
	public Calendar()
	{
		InitializeComponent();
		viewModel = new ViewModels.Calendar();
		BindingContext = viewModel;
	}
}