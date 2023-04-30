namespace CryptoCalc;

public class Calc
{
    private readonly List<string> CalcStr = new();
    private readonly List<decimal> CalcNum = new();

    public decimal CurrentNumber { get; private set; }

    public decimal Add(string str)
    {
        CalcStr.Add(str);
        CurrentNumber = Convert(CalcStr);
        return CurrentNumber;
    }

    private decimal Convert(IEnumerable<string> strList)
    {
        CalcNum.Clear();
        var resultNumber = "";
        foreach (var str in strList)
        {
            if (str == "=")
            {
                CalcNum.Add(decimal.Parse(resultNumber));
                resultNumber = "";
                continue;
            }
            if (str == "+" || str == "-" || str == "÷" || str == "×")
            {
                CalcNum.Add(decimal.Parse(resultNumber));
                resultNumber = "";
                continue;
            }
            resultNumber += str;
        }
        return resultNumber == "" ? CalcNum.Sum(x => x)  : decimal.Parse(resultNumber);
    }
}
