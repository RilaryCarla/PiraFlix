namespace PiraFlix.Categoria;

public partial class infantil : ContentPage
{
	public infantil()
	{
		InitializeComponent();
	}

    private void osegredodosanimais_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.osegredodosanimais());
    }

    private void aorigemdosguardioes_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.aorigemdosguardioes());
    }

    private void afantasticafabricadechocolate_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.afantasticafabricadechocolate());
    }

    private void beemovie_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.beemovie());
    }
}