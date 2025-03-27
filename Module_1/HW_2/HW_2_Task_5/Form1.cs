namespace HW_2_Task_5;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"Byte range: from {byte.MinValue} to {byte.MaxValue}", "Info");
    }

    private void button2_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"Sbyte range: from {sbyte.MinValue} to {sbyte.MaxValue}", "Info");
    }

    private void button3_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"Short range: from {short.MinValue} to {short.MaxValue}", "Info");
    }

    private void button4_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"Ushort range: from {ushort.MinValue} to {ushort.MaxValue}", "Info");
    }

    private void button5_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"Int range: from {int.MinValue} to {int.MaxValue}", "Info");
    }

    private void button6_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"Uint range: from {uint.MinValue} to {uint.MaxValue}", "Info");
    }

    private void button7_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"Long range: from {long.MinValue} to {long.MaxValue}", "Info");
    }

    private void button8_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"Ulong range: from {ulong.MinValue} to {ulong.MaxValue}", "Info");
    }
}
