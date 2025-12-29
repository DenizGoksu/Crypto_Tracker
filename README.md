# Crypto Tracker - Real Time Dashboard

Bu uygulama, C# ve .NET kullanılarak geliştirilmiş, popüler kripto para birimlerinin (BTC, ETH, SOL vb.) anlık fiyatlarını 10 saniyede bir güncelleyerek terminal üzerinden takip etmenizi sağlayan bir dashboard uygulamasıdır. 🚀

# Öne Çıkan Özellikler
- Canlı Veri: Veriler, güvenilir bir kaynak olan **CoinGecko API** üzerinden anlık çekilir.
- Otomatik Güncelleme: `while(true)` döngüsü ve `Task.Delay` ile program 10 saniyede bir kendini tazeler.
- Asenkron Mimari: `HttpClient` ve `async/await` kullanılarak donma yapmayan akıcı bir veri akışı sağlanır.
- JSON Yönetimi: Gelen veriler `Newtonsoft.Json` (Json.NET) ile profesyonelce işlenir.

# Kullanılan Teknolojiler
- Dil: C# (.NET 8.0)
- Kütüphane: `Newtonsoft.Json`
- API: CoinGecko V3 API

# Kurulum ve Çalıştırma

1. Repoyu bilgisayarınıza indirin:
   ```bash
   git clone [https://github.com/DenizGoksu/CryptoTracker.git](https://github.com/DenizGoksu/CryptoTracker.git)
