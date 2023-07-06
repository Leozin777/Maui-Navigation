namespace MauiDemo;

public partial class PageModal : ContentPage
{
	public PageModal()
	{
		InitializeComponent();
	}

    private async void RetornarBtn_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync(true);
    }

    protected override bool OnBackButtonPressed()
    {
        return true;
    }
}