namespace CryptoCalc;

public class Calc
{
    private readonly List<string> StrList = new();
    private readonly List<Tuple<decimal,string>> CalcNum = new();

    public decimal CurrentNumber { get; private set; }

    public decimal Add(string str)
    {
        StrList.Add(str);
        CurrentNumber = ToDecimal(StrList);
        return CurrentNumber;
    }

    private decimal ToDecimal(IEnumerable<string> strList)
    {
        CalcNum.Clear();
        var result = "";
        foreach (var str in strList)
        {
            if (str == "+" || str == "-" || str == "÷" || str == "×" || str == "=")
            {
                CalcNum.Add(Tuple.Create(decimal.Parse(result), str));
                result = "";
                continue;
            }
            result += str;
        }
        return result == "" ? ToDecimal(CalcNum) : decimal.Parse(result);
    }

    private static decimal ToDecimal(List<Tuple<decimal, string>> CalcNum)
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
