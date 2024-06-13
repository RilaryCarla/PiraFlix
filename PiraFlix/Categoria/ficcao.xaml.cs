namespace PiraFlix.Categoria;

public partial class ficcao : ContentPage
{
	public ficcao()
	{
		InitializeComponent();
	}

    private void aquintaonda_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.aquintaonda());
    }

    private void shazam_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.shazam());
    }

    private void deadpool_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.deadpool());
    }

    private void homemaranha_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.homemaranha());
    }
}