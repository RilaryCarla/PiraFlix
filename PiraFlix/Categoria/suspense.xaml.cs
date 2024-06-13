namespace PiraFlix.Categoria;

public partial class suspense : ContentPage
{
	public suspense()
	{
		InitializeComponent();
	}

    private void opoco_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.opoco());
    }

    private void ondeestasegunda_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.ondeestasegunda());
    }

    private void expressodoamanha_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.expressodoamanha());
    }

    private void lucy_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.lucy());
    }
}