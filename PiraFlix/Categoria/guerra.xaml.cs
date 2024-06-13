namespace PiraFlix.Categoria;

public partial class guerra : ContentPage
{
	public guerra()
	{
		InitializeComponent();
	}

    private void ateoultimohomem_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.ateoultimohomem());
    }

    private void coracoesdeferro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.coracoesdeferro());
    }

    private void rambo_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.rambo());
    }

    private void troia_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.troia());
    }
}