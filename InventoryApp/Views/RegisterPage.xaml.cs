using InventoryApp.AppCore.Interfaces;

namespace InventoryApp.Views;

public partial class RegisterPage : ContentPage
{
	private readonly IUserService userService;
	public RegisterPage(IUserService userService)
	{
		this.userService = userService;
		InitializeComponent();
	}

	private async void OnRegisterClicked(object sender, EventArgs e)
	{
		string result = await userService.RegisterAsync("reduhq@gmail.cpom", "1234678");
		Console.WriteLine("resultadoooooooooooo" + result);
	}
}