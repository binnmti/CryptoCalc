namespace CryptoCalc;

public static class YenConverter
{
    private static readonly Dictionary<string, decimal> SymbolRate = new()
    {
        {"eth", 259517m },
        {"matic", 136m },
    };

    public static decimal Convert(string nowSymbol, string newSymbol, decimal value)
    {
        if (nowSymbol == "yen")
        {
            SymbolRate.TryGetValue(newSymbol, out decimal price);
            return value / price;
        }
        else
        {
            SymbolRate.TryGetValue(nowSymbol, out decimal nowPrice);
            if (newSymbol == "yen")
            {
                return value * nowPrice;
            }
            else
            {
                SymbolRate.TryGetValue(newSymbol, out decimal newePrice);
                return value * nowPrice / newePrice;
            }
        }
    }
}
