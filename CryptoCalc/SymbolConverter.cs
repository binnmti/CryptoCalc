namespace CryptoCalc;

public static class SymbolConverter
{
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
}
