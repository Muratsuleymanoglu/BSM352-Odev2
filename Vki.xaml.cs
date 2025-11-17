namespace Odev2;

public partial class Vki : ContentPage
{
    public Vki()
    {
        InitializeComponent();

     
    }

    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
      
        Hesap();
    }

    private void Hesap()
    {
        double kilo = KiloSec.Value;
        double boyCm = BoySec.Value;

        Kilosu.Text = kilo.ToString("F1");
        Boyu.Text = boyCm.ToString("F1");

        double boyToMetre = boyCm / 100;
        double vki = kilo / (boyToMetre * boyToMetre);

        Sonuc.Text = $"VKİ: {vki:F2}"; 

        if (vki < 16)
            Obezlik.Text = "İleri Düzeyde Zayıf";
        else if (vki < 17)
            Obezlik.Text = "Orta Düzeyde Zayıf";
        else if (vki < 18.5)
            Obezlik.Text = "Hafif Düzeyde Zayıf";
        else if (vki < 25)
            Obezlik.Text = "Normal Kilolu";
        else if (vki < 30)
            Obezlik.Text = "Hafif Şişman / Fazla Kilolu";
        else if (vki < 35)
            Obezlik.Text = "1. Derecede Obez";
        else if (vki < 40)
            Obezlik.Text = "2. Derecede Obez";
        else
            Obezlik.Text = "3. Derecede Obez / Morbid Obez";
    }
}