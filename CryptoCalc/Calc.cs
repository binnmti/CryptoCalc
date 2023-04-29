namespace CryptoCalc;

public class Calc
{
    private List<string> CalcStr = new List<string>();

    public decimal Add(string str)
    {
        CalcStr.Add(str);
        return Convert(CalcStr);
    }

    private decimal Convert(IEnumerable<string> strList)
    {
        var resultNumber = "";
        foreach (var str in strList)
        {
            if (str == "+" || str == "-" || str == "÷" || str == "×") resultNumber = "";
            resultNumber += str;
        }
        return decimal.Parse(resultNumber);
    }
}
