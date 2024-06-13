namespace PiraFlix.Categoria;

public partial class terror : ContentPage
{
	public terror()
	{
		InitializeComponent();
	}

    private void umanoitedecrime_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.umanoitedecrime());
    }

    private void docevinganca_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.docevinganca());
    }

    private void panico_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.panico());
    }

    private void invocacaodomal_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.invocacaodomal());
    }
}