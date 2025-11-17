namespace Odev2;

public partial class KrediHesaplama : ContentPage
{
    public KrediHesaplama()
    {
        InitializeComponent();
     
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        // Hata
        if (string.IsNullOrWhiteSpace(Tutar.Text) ||
            string.IsNullOrWhiteSpace(FaizOran.Text))
        {
            hataLabel.Text = "Lütfen tüm alanları doldurun.";
            AylikTaksit.Text = "";
            ToplamOdenecekTutar.Text = "";
            return;
        }

       
        double yillikFaizOrani = Convert.ToDouble(FaizOran.Text);
        double tutar = Convert.ToDouble(Tutar.Text);

        if (yillikFaizOrani == null || tutar == null)
        {
            hataLabel.Text = "Lütfen tutar ve faiz için geçerli sayılar girin.";
            AylikTaksit.Text = "";
            ToplamOdenecekTutar.Text = "";
            return;
        }
        else if (yillikFaizOrani ==0)
            {
            hataLabel.Text = "Faiz oranınızı kontrol edin.";
            AylikTaksit.Text = "";
            ToplamOdenecekTutar.Text = "";
            return;
        }

            int vade = (int)Vade.Value;
        string krediTuru = KrediTuru.SelectedItem.ToString();

        double bsmv = 0.0;
        double kkdf = 0.0;

        if (krediTuru == "İhtiyaç Kredisi")
        {
            bsmv = 0.10;
            kkdf = 0.15;
        }
        else if (krediTuru == "Taşıt Kredisi")
        {
            bsmv = 0.05;
            kkdf = 0.15;
        }
        else if (krediTuru == "Konut Kredisi")
        {
            bsmv = 0.0;
            kkdf = 0.0;
        }
        else if (krediTuru == "Ticari Kredisi")
        {
            bsmv = 0.05;
            kkdf = 0.0;
        }

       
        double aylikFaizOrani = (yillikFaizOrani / 100.0) / 12.0;

        double brutFaiz = aylikFaizOrani + (aylikFaizOrani * bsmv) + (aylikFaizOrani * kkdf);

        double taksit = ((Math.Pow(1 + brutFaiz, vade) * brutFaiz) / (Math.Pow(1 + brutFaiz, vade) - 1)) * tutar;

        double toplamOdeme = taksit * vade;

        //Faiz 0 hatası
        if (double.IsNaN(taksit) || double.IsInfinity(taksit))
        {
            taksit = tutar / vade;
            toplamOdeme = tutar;
        }

        AylikTaksit.Text = $"Aylık Taksit: {taksit:C2}";
        ToplamOdenecekTutar.Text = $"Toplam Ödeme: {toplamOdeme:C2}";

        hataLabel.Text = "";
    }
}