using Dapper;
using System;
using System.Data.SqlClient;
using static CryptoCalc.Coin;

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

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        decimal.TryParse(calcTextBox.Text, out var result);
        calcTextBox.Text = SymbolConverter.Convert(_comboText, comboBox1.Text, result).ToString();

        _comboText = comboBox1.Text;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        //using var sqlConnection = new SqlConnection(connectionString);
        //var yens = sqlConnection.Query<Yen>($"select * from Yen Where");
        //var dic = yens.ToDictionary(x => x.Id, x => x.Price);

        //private static readonly Dictionary<string, decimal> SymbolItems = new()
        //{
        //    {"eth", 259517m },
        //    {"matic", 136m },
        //};

    }
    //TODO:1ethにするみたいなボタン？
    //TODO:テキストを直接入力できるようにする。
}

public class Yen
{
    public string Id { get; set; }
    public float Price { get; set; }
}
