namespace MauiDemo;

public partial class Page3 : ContentPage
{
    public Page3()
    {
        InitializeComponent();
        LabelText.Text = "Bem vindo a terceira pagina";
    }
    public Page3(string p_nome)
    {
        InitializeComponent();
        TextBox2.Text = p_nome;
        LabelText.Text = p_nome;
    }

    private async void Button_Page2(object sender, EventArgs e)
    {
        await Navigation.PopAsync(true);
    }

    private async void Button_MainPage(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync(true);
    }
}