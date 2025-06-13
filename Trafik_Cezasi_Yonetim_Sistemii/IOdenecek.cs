﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Trafik_Cezasi_Yonetim_Sistemii
{
    // Tüm formlar arasında paylaşılacak ceza listesi
    public static class GlobalData
    {
        public static List<Ceza> Cezalar = new List<Ceza>();
    }

    // Ceza miktarı hesaplama arayüzü
    public interface IOdenecek
    {
        decimal HesaplaCezaTutari();
    }

    // Tüm ceza türleri için temel soyut sınıf
    public abstract class Ceza : IOdenecek
    {
        public string AdSoyad { get; set; }
        public string Plaka { get; set; }
        public string ID { get; set; }
        public DateTime CezaTarihi { get; set; }
        public string CezaTuru { get; set; }
        public decimal Tutar { get; set; }
        public bool OdendiMi { get; set; } = false; // Ödeme durumu eklendi

        public abstract decimal HesaplaCezaTutari(); // Her ceza türü kendi tutarını hesaplayacak

        // Ceza bilgilerini okunabilir bir string olarak döndürür
        public override string ToString()
        {
            return $"ID: {ID}, Ad Soyad: {AdSoyad}, Plaka: {Plaka}, Ceza Türü: {CezaTuru}, Tutar: {Tutar:C}, Tarih: {CezaTarihi.ToShortDateString()}, Ödendi Mi: {(OdendiMi ? "Evet" : "Hayır")}";
        }
    }

    
    public class KirmiziIsikCezasi : Ceza                                  // Kırmızı Işık Cezası 
    {
        public KirmiziIsikCezasi()
        {
            CezaTuru = "Kırmızı Işık İhlali";
        }
        public override decimal HesaplaCezaTutari()
        {
            return 600m; // 600 TL
        }
    }

    
    public class HizCezasi : Ceza                                           // Hız Cezası 
    {
        public HizCezasi()
        {
            CezaTuru = "Hız İhlali";
        }
        public override decimal HesaplaCezaTutari()
        {
            return 1100m; // 1100 TL
        }
    }

    
    public class ParkCezasi : Ceza                                       // Park Cezası 
    {
        public ParkCezasi()
        {
            CezaTuru = "Park İhlali";
        }
        public override decimal HesaplaCezaTutari()
        {
            return 400m; // 400 TL
        }
    }

}   