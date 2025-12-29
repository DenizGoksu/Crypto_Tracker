using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
//Kütüphaneler 

class Program
{
    static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // CoinGecko API'sinden popüler coinleri çekiyoruz
                string url = "https://api.coingecko.com/api/v3/simple/price?ids=bitcoin,ethereum,solana,ripple,binancecoin&vs_currencies=usd";

                Console.WriteLine("🌐 Kripto borsasına bağlanılıyor...");
                string response = await client.GetStringAsync(url);
                JObject data = JObject.Parse(response);

                Console.Clear(); // Ekranı temizle ki sadece liste görünsün
                Console.WriteLine("======================================");
                Console.WriteLine("         CANLI KRİPTO TAKİP           ");
                Console.WriteLine("======================================");
                Console.WriteLine($" 🕒 Güncelleme: {DateTime.Now:HH:mm:ss}");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($" 🟡 BTC (Bitcoin)  : ${data["bitcoin"]["usd"]}");
                Console.WriteLine($" 🔵 ETH (Ethereum) : ${data["ethereum"]["usd"]}");
                Console.WriteLine($" 🟣 SOL (Solana)   : ${data["solana"]["usd"]}");
                Console.WriteLine($" ⚪ XRP (Ripple)   : ${data["ripple"]["usd"]}");
                Console.WriteLine($" 🔶 BNB (Binance)  : ${data["binancecoin"]["usd"]}");
                Console.WriteLine("======================================");
                Console.WriteLine("\nKapatmak için 'Enter' tuşuna basın...");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }
        }
    }
}