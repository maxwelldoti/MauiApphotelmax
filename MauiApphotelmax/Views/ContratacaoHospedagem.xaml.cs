namespace MauiApphotelmax.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

    private async void OnSobreButtonClicked(object sender, EventArgs e)
	{

        await DisplayAlert("Sobre", "Desenvolvedor: Max Almeida\nAno de Desenvolvimento: 2024", "OK");
    }
}