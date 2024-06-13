namespace PiraFlix.Categoria;

public partial class aventura : ContentPage
{
	public aventura()
	{
		InitializeComponent();
	}

    private void jumanji_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.jumanji());
    }

    private void interestelar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.interestelar());
    }

    private void mazerunner_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.mazerunner());
    }

    private void ascronicasdespiderwick_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.spiderwick());
    }
}