namespace HW_1_1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// Sets up the form components.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the button click event and copies the text from textBox1 to textBox2.
        /// </summary>
        /// <param name="sender">The source of the event, typically the button that was clicked.</param>
        /// <param name="e">Event data containing information about the button click.</param>
        private void button_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }
    }
}