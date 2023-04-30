namespace CryptoCalc;

public class Calc
{
    private readonly List<string> StrList = new();

    public decimal CurrentNumber { get; private set; }

    public decimal Add(string str)
    {
        if (StrList.Count == 0 && IsCalc(str))
        {
            foreach (var n in CurrentNumber.ToString())
            {
                StrList.Add(n.ToString());
            }
        }
        if (string.Compare(str, "C", true) == 0)
        {
            StrList.Clear();
            StrList.Add("0");
        }
        else
        {
            StrList.Add(str);
        }
        CurrentNumber = ToDecimal(StrList);
        if(str == "=")
        {
            StrList.Clear();
        }
        return CurrentNumber;
    }

    private static decimal ToDecimal(IEnumerable<string> strList)
    {
        var calcItem = new List<Tuple<decimal, string>>();
        var result = "";
        foreach (var str in strList)
        {
            if (IsCalc(str))
            {
                calcItem.Add(Tuple.Create(decimal.Parse(result), str));
                result = "";
                continue;
            }
            result += str;
        }
        return result == "" ? ToDecimal(calcItem) : decimal.Parse(result);
    }

    private static decimal ToDecimal(List<Tuple<decimal, string>> calcItem)
    {
        string preSymbol = "";
        decimal result = 0;
        foreach (var (num, symbol) in calcItem)
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

    private static bool IsCalc(string str)
        => str == "+" || str == "-" || str == "÷" || str == "×" || str == "=";
}
