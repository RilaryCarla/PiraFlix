namespace PiraFlix.Categoria;

public partial class drama : ContentPage
{
	public drama()
	{
		InitializeComponent();
	}

    private void acincopassosdevoce_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.acincopassosdevoce());
    }

    private void oppenheimer_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.oppenheimer());
    }

    private void omundodepoisdenos_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.omundodepoisdenos());
    }

    private void umolhardoparaiso_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.umolhardoparaiso());
    }
}