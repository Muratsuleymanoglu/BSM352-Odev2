# BSM352 Görsel Programlama Ödev 2

## 👤 Öğrenci Bilgileri

* **Ad Soyad:** `Murat Süleymanoğlu`
* **Öğrenci No:** `22010310067`
* **Ders Sorumlusu:** Dr.Öğr.Üyesi Bayram Akgül 

---

## 🚀 Proje Hakkında

Bu uygulama, 4 farklı araç içeren çok sayfalı bir mobil/masaüstü uygulamasıdır. Uygulama .NET MAUI ve XAML kullanılarak geliştirilmiştir. Uygulama mimarisi, yandan açılır menü (Flyout) ile gezilebilen 4 ana sayfadan oluşmaktadır.

---

## 🛠️ Uygulama Özellikleri

### 1. Ana Sayfa
Benim adımı, soyadımı, ve bir profil resmini gösteren karşılama sayfası.

### 2. Kredi Hesaplama
* `Picker` kontrolü ile (İhtiyaç, Taşıt, Konut, Ticari) kredi türü seçimi.
Kredi tutarı ve **aylık** faiz oranı için `Entry` (giriş) alanları.
* `Slider` kontrolü ile 1-120 ay arası vade seçimi.
*Ödevde belirtilen BSMV ve KKDF oranlarına göre aylık taksit ve toplam geri ödeme hesaplaması.

### 3. Vücut Kitle İndeksi (VKE)
*Kilo ve boy (cm) seçimi için iki ayrı `Slider` kullanımı.
*Slider'lar değiştikçe **dinamik (anlık)** olarak VKE hesaplaması.
*Hesaplanan VKE sonucuna göre "Normal Kilolu", "1. Derecede Obez" gibi sağlık durumunun anlık olarak gösterilmesi.

### 4. Renk Seçici
*Kırmızı (R), Yeşil (G) ve Mavi (B) değerlerini belirlemek için 3 ayrı `Slider`.
*Seçilen renge göre alt bölümdeki `BoxView` (veya sayfa) **arka planının dinamik olarak değişmesi**.
*Oluşturulan rengin HEX kodunu (`#RRGGBB`) bir `Label`'da gösterme.
***Kopyala** butonu ile renk kodunu cihazın panosuna kopyalama.
***Rastgele Renk** butonu ile rastgele bir renk oluşturma.

---

## 💻 Kullanılan Teknolojiler

* .NET MAUI
* C#
* XAML

---

## Videolu Anlatım Linki

**https://youtu.be/FnHGU6CNInQ**
