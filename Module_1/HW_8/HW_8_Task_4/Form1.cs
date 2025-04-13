namespace HW_8_Task_4;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string input1 = textBox1.Text;
        string input2 = textBox2.Text;
        string result = "";

        // Modulo operation
        if (radioButton1.Checked)
        {
            int a = int.Parse(input1);
            int b = int.Parse(input2);
            result = (a % b).ToString();
        }
        // Power operation
        else if (radioButton2.Checked)
        {
            double a = double.Parse(input1);
            double b = double.Parse(input2);
            result = Math.Pow(a, b).ToString();
        }
        // Concatenation operation
        else if (radioButton3.Checked)
        {
            result = input1 + input2;
        }
        // Division operation
        else if (radioButton4.Checked)
        {
            double a = double.Parse(input1);
            double b = double.Parse(input2);

            if (b == 0)
                result = "Error: Division by zero.";
            else
                result = (a / b).ToString();
        }

        textBox3.Text = result;
    }
}
