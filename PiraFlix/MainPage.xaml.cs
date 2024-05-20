namespace PiraFlix
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void aventura_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categoria.aventura());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void comedia_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categoria.comedia());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void drama_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categoria.drama());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void terror_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categoria.terror());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void ficcao_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categoria.ficcao());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void suspense_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categoria.suspense());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void infantil_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categoria.infantil());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void animacao_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categoria.animacao());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void documentario_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categoria.documentario());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void guerra_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categoria.guerra());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void nacional_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categoria.nacional());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void romance_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categoria.romance());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }
    }

}
