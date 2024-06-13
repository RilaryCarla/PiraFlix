namespace PiraFlix.Categoria;

public partial class documentario : ContentPage
{
	public documentario()
	{
		InitializeComponent();
	}

    private void cobain_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.cobain());
    }

    private void madamex_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.madamex());
    }

    private void racionaismc_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.racionais());
    }

    private void selenagomes_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.selenagomes());
    }
}