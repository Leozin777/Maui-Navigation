namespace MauiDemo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private async void Button_Page2(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Page2(), true);
    }

    private async void Button_PageModal(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new PageModal(), true);
    }
}

