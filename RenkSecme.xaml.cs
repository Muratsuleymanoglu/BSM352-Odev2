namespace Odev2;

public partial class RenkSecme : ContentPage
{
    private Random _random = new Random();

    public RenkSecme()
    {
        InitializeComponent();


    }

    private void OnColorChanged(object sender, ValueChangedEventArgs e)
    {
       

        int red = (int)Kirmizi.Value;
        int green = (int)Yesil.Value;
        int blue = (int)Mavi.Value;

        Color secilenRenk = Color.FromRgb(red, green, blue);

        ColorBox.BackgroundColor = secilenRenk;

        HexLabel.Text = secilenRenk.ToHex();
    }
    private async void KopyalaButton_Clicked(object sender, EventArgs e)
    {
        string renkKodu = HexLabel.Text;
        await Clipboard.SetTextAsync(renkKodu);
        await DisplayAlert("Kopyalandı", $"{renkKodu} panoya kopyalandı!", "OK");
    }

    private void RastgeleButton_Clicked(object sender, EventArgs e)
    {
        Kirmizi.Value = _random.Next(256);
        Yesil.Value = _random.Next(256);
        Mavi.Value = _random.Next(256);

    }
}