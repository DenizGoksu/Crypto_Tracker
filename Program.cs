using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            Console.WriteLine("🚀 Kripto Takip Başlatılıyor... Durdurmak için Ctrl+C tuşlarına basabilirsin.");
            
            // Sonsuz döngü: Sen kapatana kadar devam eder
            while (true) 
            {
                try
                {
                    string url = "https://api.coingecko.com/api/v3/simple/price?ids=bitcoin,ethereum,solana,ripple,binancecoin&vs_currencies=usd";
                    
                    string response = await client.GetStringAsync(url);
                    JObject data = JObject.Parse(response);

                    Console.Clear(); // Her güncellemede ekranı temizle ki alt alta binmesin
                    Console.WriteLine("======================================");
                    Console.WriteLine("      📊 CANLI KRİPTO PANELİ (10s)    ");
                    Console.WriteLine("======================================");
                    Console.WriteLine($" 🕒 Son Güncelleme: {DateTime.Now:HH:mm:ss}");
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine($" 🟡 BTC : ${data["bitcoin"]["usd"]}");
                    Console.WriteLine($" 🔵 ETH : ${data["ethereum"]["usd"]}");
                    Console.WriteLine($" 🟣 SOL : ${data["solana"]["usd"]}");
                    Console.WriteLine($" ⚪ XRP : ${data["ripple"]["usd"]}");
                    Console.WriteLine($" 🔶 BNB : ${data["binancecoin"]["usd"]}");
                    Console.WriteLine("======================================");
                    Console.WriteLine(" Çıkmak için terminali kapat veya Ctrl+C yap.");

                    // 10.000 milisaniye (yani 10 saniye) bekle
                    await Task.Delay(10000); 
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nBağlantı hatası! 10 saniye sonra tekrar denenecek...");
                    await Task.Delay(10000);
                }
            }
        }
    }
}