namespace CryptoCalc;

public static class SymbolConverter
{
    private static readonly Dictionary<string, decimal> SymbolItems = new()
    {
        {"eth", 259517m },
        {"matic", 136m },
    };

    public static float Convert(this Dictionary<string, float> symbolItems, string nowSymbol, string newSymbol, float price)
    {
        if (nowSymbol == "yen")
        {
            symbolItems.TryGetValue(newSymbol, out float newPrice);
            return price / newPrice;
        }
        else
        {
            symbolItems.TryGetValue(nowSymbol, out float nowPrice);
            if (newSymbol == "yen")
            {
                return price * nowPrice;
            }
            else
            {
                symbolItems.TryGetValue(newSymbol, out float newePrice);
                return price * nowPrice / newePrice;
            }
        }
    }

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
