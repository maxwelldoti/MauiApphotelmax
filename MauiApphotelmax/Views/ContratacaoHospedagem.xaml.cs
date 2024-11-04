using System.Linq.Expressions;

namespace MauiApphotelmax.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        } 
    }

    private async void OnSobreButtonClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Sobre", "Desenvolvedor: Max Almeida\nAno de Desenvolvimento: 2024", "OK");
    }
}
