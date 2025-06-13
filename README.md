# 🚦 Trafik Cezası Takip Uygulaması

Bu Windows Forms tabanlı proje, trafikteki sürücülere kesilen cezaların kayıt altına alınmasını, yönetilmesini ve vatandaşların kendi cezalarını kolayca sorgulamasını amaçlayan kullanıcı dostu bir uygulamadır. Hem trafik polisleri hem de sürücüler için pratik bir çözüm sunar.

---

## 🎯 Proje Hedefleri

Uygulamanın temel işlevleri şunlardır:

- **Ceza Kaydı:** Yeni trafik cezalarının sisteme hızlı bir şekilde eklenmesi.  
- **Ödeme Durumu İzleme:** Ceza ödemelerinin yapılma durumlarını (ödenmiş / ödenmemiş) takip etme.  
- **Cezaları Sorgulama:** Vatandaşların plaka numarası veya TC kimlik numarası ile kendi cezalarını görmesi.  
- **Raporlama:** Genel ceza durumu hakkında özet bilgiler sunan görseller veya listeler.

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|----------|----------|
| **C#** | Ana yazılım dili |
| **Windows Forms** | Masaüstü kullanıcı arayüzü |
| **OOP** | Nesne yönelimli programlama yaklaşımı |

---

## 🧱 Yazılım Mimarisi ve OOP Prensipleri

Uygulama, sürdürülebilir ve anlaşılır bir yapı oluşturmak adına aşağıdaki nesne yönelimli tasarım ilkelerine bağlı kalınarak geliştirildi:

- **Kalıtım (Inheritance):** `Ceza` adlı soyut temel sınıf üzerinden `HizCezasi`, `ParkCezasi`, `KirmiziIsikCezasi` gibi sınıflar türetilir.  
- **Arayüzler (Interfaces):** `IOdenecek` arayüzü, cezalara ödeme hesaplama davranışı kazandırır.  
- **Soyutlama (Abstraction):** Ortak olmayan detaylar alt sınıflar tarafından uygulanır.  
- **Kapsülleme (Encapsulation):** Cezalar, `GlobalData` sınıfında merkezi şekilde saklanır ve doğrudan müdahaleye kapalıdır.

---

## 📋 Uygulama Modülleri

### 🔐 Giriş Ekranı
- Polis giriş ekranı (Kullanıcı adı: `12345678910`, Şifre: `7894`)  
- Doğrulama sonrası ceza ekleme ekranına yönlendirme  

### 📝 Ceza Ekleme Paneli
- Sürücü bilgileri (Ad, Soyad, TCKN, Plaka) girişi  
- Ceza türü seçimi ve otomatik toplam hesaplama  
- Ceza kaydının global listeye eklenmesi  

### 🔎 Ceza Sorgulama Paneli *(Geliştirilmeye açık)*  
- Vatandaşlar, TCKN veya plaka numarası ile kendi ceza kayıtlarını görebilir.  
- Ödeme durumlarına göre filtreleme planlanmaktadır.  

### 🌐 Global Veri Yönetimi
- `GlobalData` sınıfı aracılığıyla cezalar tüm uygulama genelinde paylaşılır.  

---

## ⚙️ Kurulum Adımları

1. **Projeyi Klonlayın:**

```bash
git clone https://github.com/Parzel58/Trafik-Cezasi-Yonetim-Sistemi.git
istemi
