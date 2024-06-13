namespace PiraFlix.Categoria;

public partial class animacao : ContentPage
{
	public animacao()
	{
		InitializeComponent();
	}

    private void anoivacadaver_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.anoivacadaver());
    }

    private void poraguaabaixo_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.poraguaabaixo());
    }

    private void walle_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.walle());
    }

    private void up_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.up());
    }
}