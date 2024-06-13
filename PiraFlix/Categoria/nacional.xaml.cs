namespace PiraFlix.Categoria;

public partial class nacional : ContentPage
{
	public nacional()
	{
		InitializeComponent();
	}

    private void opaio_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.opaio());
    }

    private void tropadeelite_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.tropadeelite());
    }

    private void oautodacompadecida_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.oautodacompadecida());
    }

    private void cidadededeus_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.cidadededeus());
    }
}