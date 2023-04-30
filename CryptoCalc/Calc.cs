namespace CryptoCalc;

public class Calc
{
    private readonly List<string> CalcStr = new();
    private readonly List<Tuple<decimal,string>> CalcNum = new();

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
                CalcNum.Add(Tuple.Create(decimal.Parse(resultNumber), str));
                resultNumber = "";
                continue;
            }
            if (str == "+" || str == "-" || str == "÷" || str == "×")
            {
                CalcNum.Add(Tuple.Create(decimal.Parse(resultNumber), str));
                resultNumber = "";
                continue;
            }
            resultNumber += str;
        }
        return resultNumber == "" ? Convert(CalcNum) : decimal.Parse(resultNumber);
    }

    private static decimal Convert(List<Tuple<decimal, string>> CalcNum)
    {
        string preSymbol = "";
        decimal result = 0;
        foreach (var (num, symbol) in CalcNum)
        {
            result = preSymbol switch
            {
                "+" => result + num,
                "-" => result - num,
                "×" => result * num,
                "÷" => result / num,
                "%" => result % num,
                _ => result + num,
            };
            preSymbol = symbol;
        }
        return result;
    }
}
