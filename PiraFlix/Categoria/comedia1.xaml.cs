namespace PiraFlix.Categoria;

public partial class comedia1 : ContentPage
{
	public comedia1()
	{
		InitializeComponent();
	}

    private void familiadobagulho_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.famnilia());
    }

    private void gentegrande_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.gentegrande());
    }

    private void inatividadeparanormal_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.inatividadeparanormal());
    }

    private void superbad_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.superbad());
    }
}