namespace MauiDemo;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private async void Button_MainPage(object sender, EventArgs e)
    {
        await Navigation.PopAsync(true);
    }

    private async void Button_Page3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page3(), true);
    }

    private async void Button_Text(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page3(TextBox.Text), true);
    }
}