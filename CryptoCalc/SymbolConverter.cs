namespace CryptoCalc;

public static class SymbolConverter
{
    private static readonly Dictionary<string, decimal> SymbolItems = new()
    {
        {"eth", 259517m },
        {"matic", 136m },
    };

    public static decimal Convert(string nowSymbol, string newSymbol, decimal price)
    {
        if (nowSymbol == "yen")
        {
            SymbolItems.TryGetValue(newSymbol, out decimal newPrice);
            return price / newPrice;
        }
        else
        {
            SymbolItems.TryGetValue(nowSymbol, out decimal nowPrice);
            if (newSymbol == "yen")
            {
                return price * nowPrice;
            }
            else
            {
                SymbolItems.TryGetValue(newSymbol, out decimal newePrice);
                return price * nowPrice / newePrice;
            }
        }
    }
}
