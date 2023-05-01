using System.Net;
using System.Web;

namespace CryptoCalc;

public static class CoinMarketCapApiUtility
{
    public static string MakeAPICall()
    {
        var URL = new UriBuilder("https://sandbox-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

        var queryString = HttpUtility.ParseQueryString(string.Empty);
        queryString["start"] = "1";
        queryString["limit"] = "1";
        queryString["convert"] = "JPY";

        URL.Query = queryString.ToString();

        var client = new WebClient();
        client.Headers.Add("X-CMC_PRO_API_KEY", "010b01d1-0366-42ab-8fd6-26019eda6895");
        client.Headers.Add("Accepts", "application/json");
        return client.DownloadString(URL.ToString());

        //    string url = "https://pro-api.coinmarketcap.com/v1/cryptocurrency/info";

    }
}
