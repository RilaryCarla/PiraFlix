namespace PiraFlix.Categoria;

public partial class romance : ContentPage
{
	public romance()
	{
		InitializeComponent();
	}

    private void comoeueraantesdevoce_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.comoeueraantesdevoce());
    }

    private void porlugaresincriveis_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.porlugaresincriveis());
    }

    private void asvantagensdeserinvisivel_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.asvantagensdeserinvisivel ());
    }

    private void simplesmenteacontece_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.simplesmenteacontece());
    }
}