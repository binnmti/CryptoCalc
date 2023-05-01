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
        calcTextBox.Text = Calc.Add("Å~");
    }

    private void buttonRemainder_Click(object sender, EventArgs e)
    {
        calcTextBox.Text = Calc.Add("%");
    }

    private void buttonDiv_Click(object sender, EventArgs e)
    {
        calcTextBox.Text = Calc.Add("ÅÄ");
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

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        decimal.TryParse(calcTextBox.Text, out var result);

        if (_comboText == "yen(Japan)")
        {
            if (comboBox1.Text == "eth(Ethereum)")
            {
                calcTextBox.Text = (result / 259517m).ToString();
            }
            if (comboBox1.Text == "matic(Polygon)")
            {
                calcTextBox.Text = (result / 136m).ToString();
            }
        }
        else if (_comboText == "eth(Ethereum)")
        {
            if (comboBox1.Text == "yen(Japan)")
            {
                calcTextBox.Text = (result * 259517m).ToString();
            }
            //TODO
            if (comboBox1.Text == "matic(Polygon)")
            {
                calcTextBox.Text = (result * 136m).ToString();
            }
        }
        else if (_comboText == "matic(Polygon)")
        {
            if (comboBox1.Text == "yen(Japan)")
            {
                calcTextBox.Text = (result * 259517m).ToString();
            }
            //TODO
            if (comboBox1.Text == "eth(Ethereum)")
            {
                calcTextBox.Text = (result * 136m).ToString();
            }
        }
        _comboText = comboBox1.Text;
    }
    //TODO:1ethÇ…Ç∑ÇÈÇ›ÇΩÇ¢Ç»É{É^ÉìÅH
}