namespace CryptoCalc;

public partial class Form1 : Form
{
    private readonly Calc Calc = new Calc();
    public Form1()
    {
        InitializeComponent();
    }

    private void button0_Click(object sender, EventArgs e)
    {
        numericUpDown.Value = Calc.Add("0");
    }

    private void button1_Click(object sender, EventArgs e)
    {
        numericUpDown.Value = Calc.Add("1");
    }

    private void button2_Click(object sender, EventArgs e)
    {
        numericUpDown.Value = Calc.Add("2");
    }

    private void button3_Click(object sender, EventArgs e)
    {
        numericUpDown.Value = Calc.Add("3");
    }

    private void button44_Click(object sender, EventArgs e)
    {
        numericUpDown.Value = Calc.Add("4");
    }

    private void button5_Click(object sender, EventArgs e)
    {
        numericUpDown.Value = Calc.Add("5");
    }

    private void button66_Click(object sender, EventArgs e)
    {
        numericUpDown.Value = Calc.Add("6");
    }

    private void button7_Click(object sender, EventArgs e)
    {
        numericUpDown.Value = Calc.Add("7");
    }

    private void button8_Click(object sender, EventArgs e)
    {
        numericUpDown.Value = Calc.Add("8");
    }

    private void button9_Click(object sender, EventArgs e)
    {
        numericUpDown.Value = Calc.Add("9");
    }

    private void buttonPlus_Click(object sender, EventArgs e)
    {
        numericUpDown.Value = Calc.Add("+");
    }

    private void buttonMinus_Click(object sender, EventArgs e)
    {
        numericUpDown.Value = Calc.Add("-");
    }

    private void buttonMul_Click(object sender, EventArgs e)
    {
        numericUpDown.Value = Calc.Add("Å~");
    }

    private void buttonRemainder_Click(object sender, EventArgs e)
    {
        numericUpDown.Value = Calc.Add("%");
    }

    private void buttonDiv_Click(object sender, EventArgs e)
    {
        numericUpDown.Value = Calc.Add("ÅÄ");
    }

    private void buttonEqual_Click(object sender, EventArgs e)
    {
        numericUpDown.Value = Calc.Add("=");
    }
}