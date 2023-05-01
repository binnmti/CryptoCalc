namespace CryptoCalc;

public partial class Form1 : Form
{
    private readonly Calc Calc = new();
    private string _comboText;
    public Form1()
    {
        InitializeComponent();
        _comboText = comboBox1.Text;
    }

    private void button0_Click(object sender, EventArgs e)
    {
        calcTextBox.Text = Calc.Add("0");
    }

    private void button1_Click(object sender, EventArgs e)
    {
        calcTextBox.Text = Calc.Add("1");
    }

    private void button2_Click(object sender, EventArgs e)
    {
        calcTextBox.Text = Calc.Add("2");
    }

    private void button3_Click(object sender, EventArgs e)
    {
        calcTextBox.Text = Calc.Add("3");
    }

    private void button44_Click(object sender, EventArgs e)
    {
        calcTextBox.Text = Calc.Add("4");
    }

    private void button5_Click(object sender, EventArgs e)
    {
        calcTextBox.Text = Calc.Add("5");
    }

    private void button66_Click(object sender, EventArgs e)
    {
        calcTextBox.Text = Calc.Add("6");
    }

    private void button7_Click(object sender, EventArgs e)
    {
        calcTextBox.Text = Calc.Add("7");
    }

    private void button8_Click(object sender, EventArgs e)
    {
        calcTextBox.Text = Calc.Add("8");
    }

    private void button9_Click(object sender, EventArgs e)
    {
        calcTextBox.Text = Calc.Add("9");
    }

    private void buttonPlus_Click(object sender, EventArgs e)
    {
        calcTextBox.Text = Calc.Add("+");
    }

    private void buttonMinus_Click(object sender, EventArgs e)
    {
        calcTextBox.Text = Calc.Add("-");
    }

    private void buttonMul_Click(object sender, EventArgs e)
    {
        calcTextBox.Text = Calc.Add("×");
    }

    private void buttonRemainder_Click(object sender, EventArgs e)
    {
        calcTextBox.Text = Calc.Add("%");
    }

    private void buttonDiv_Click(object sender, EventArgs e)
    {
        calcTextBox.Text = Calc.Add("÷");
    }

    private void buttonEqual_Click(object sender, EventArgs e)
    {
        calcTextBox.Text = Calc.Add("=");
    }

    private void buttonReset_Click(object sender, EventArgs e)
    {
        calcTextBox.Text = Calc.Add("C");
    }

    private void buttonDot_Click(object sender, EventArgs e)
    {
        calcTextBox.Text = Calc.Add(".");
    }

    //Dictionary<string,decimal> YenConverter = new Dictionary<string, decimal>()
    //{
    //    {"eth", 259517m },
    //    {"matic", 136m },
    //};

    //private string ToConvertString(string nowSymbol, string newSymbol, decimal value)
    //{
    //    if (nowSymbol == "yen")
    //    {
    //        YenConverter.TryGetValue(newSymbol, out decimal price);
    //        return (value / price).ToString();
    //    }
    //    else
    //    {
    //        YenConverter.TryGetValue(nowSymbol, out decimal nowPrice);
    //        if (newSymbol == "yen")
    //        {
    //            return (value * nowPrice).ToString();
    //        }
    //        else
    //        {
    //            YenConverter.TryGetValue(newSymbol, out decimal newePrice);
    //            return (value * nowPrice / newePrice).ToString();
    //        }
    //    }
    //}


    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        decimal.TryParse(calcTextBox.Text, out var result);
        calcTextBox.Text = YenConverter.Convert(_comboText, comboBox1.Text, result).ToString();

        //if (_comboText == "yen")
        //{
        //    if (comboBox1.Text == "eth")
        //    {
        //        calcTextBox.Text = (result / 259517m).ToString();
        //    }
        //    if (comboBox1.Text == "matic")
        //    {
        //        calcTextBox.Text = (result / 136m).ToString();
        //    }
        //}
        //else if (_comboText == "eth")
        //{
        //    if (comboBox1.Text == "yen")
        //    {
        //        calcTextBox.Text = (result * 259517m).ToString();
        //    }
        //    if (comboBox1.Text == "matic")
        //    {
        //        calcTextBox.Text = (result * 259517m / 136m).ToString();
        //    }
        //}
        //else if (_comboText == "matic")
        //{
        //    if (comboBox1.Text == "yen")
        //    {
        //        calcTextBox.Text = (result * 136m).ToString();
        //    }
        //    if (comboBox1.Text == "eth")
        //    {
        //        calcTextBox.Text = (result * 136m / 259517m).ToString();
        //    }
        //}
        _comboText = comboBox1.Text;
    }
    //TODO:1ethにするみたいなボタン？
    //TODO:テキストを直接入力できるようにする。
}