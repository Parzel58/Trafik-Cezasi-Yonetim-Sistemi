🚦 Trafik Cezası Yönetim Sistemi
Bu proje, sürücülere kesilen trafik cezalarının yönetimini kolaylaştıran bir Windows Forms uygulamasıdır. Hem polis memurlarının yeni cezaları eklemesini hem de vatandaşların kendi cezalarını sorgulamasını sağlayan pratik bir sistem sunar.

🎯 Amaç ve Özellikler
Sistemin temel hedefleri şunlardır:

✅ Ceza Kaydı: Polis memurları, sürücülere kesilen cezaları hızlı ve kolay bir şekilde sisteme ekleyebilir. 💳 Ödeme Takibi: Cezaların ödeme durumları görüntülenebilir ve takip edilebilir. 🔎 Sorgulama: Vatandaşlar, kimlik veya plaka numarasıyla cezalarını sorgulayabilir. 📊 Raporlama: Genel ceza istatistikleri ve ödeme durumları hakkında bilgi sunar.

🛠️ Kullanılan Teknolojiler
Bu proje aşağıdaki teknolojilerle geliştirilmiştir:

C# – Ana programlama dili.

Windows Forms (WinForms) – Kullanıcı arayüzü için kullanılan framework.

Nesne Yönelimli Programlama (OOP) – Kodun düzenli ve genişletilebilir olmasını sağlar.

🚀 OOP Yaklaşımı
Proje, temiz ve modüler bir yapı oluşturmak için temel OOP prensiplerini uygular:

Kalıtım (Inheritance): Tüm ceza türleri (Hız, Park, Kırmızı Işık) ortak özelliklerini Ceza adlı soyut sınıftan miras alır.

Arayüz (Interface): IOdenecek arayüzü, ödeme ile ilgili ortak davranışları tanımlar.

Soyutlama (Abstraction): Ceza sınıfı, tüm ceza türlerinin ortak özelliklerini belirlerken, her alt sınıf kendine özgü uygulamalar içerir.

Kapsülleme (Encapsulation): Verilere doğrudan erişimi sınırlandırarak güvenli bir yapı oluşturur.

🏗️ Modüller ve İşleyiş
Uygulamanın temel bileşenleri şunlardır:

📌 Ana Ekran
Kullanıcılar, polis paneline veya ceza sorgulama ekranına buradan erişebilir.

👮 Polis Paneli
Polis memurları, kullanıcı adı: polis ve şifre: 123 ile giriş yaparak ceza ekleme ekranına ulaşabilir.

📝 Ceza Ekleme Formu
Sürücü bilgileri (ad, soyad, plaka, kimlik no) girilerek farklı ceza türleri eklenebilir. Ceza tutarı otomatik hesaplanır ve GlobalData listesine kaydedilir.

🔍 Ceza Sorgulama Formu
Vatandaşlar, kimlik veya plaka numarasıyla cezalarını sorgulayabilir.

🌍 Global Veri Yönetimi
Tüm cezalar GlobalData sınıfında saklanır ve uygulamanın farklı bölümleri bu verilere erişebilir.# Trafik-Cezasi-Yonetim-Sistemi
