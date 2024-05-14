using Logic;
using System.Windows.Forms;

namespace Practicn7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            richTextBox1.Text = (await LogicObj.GenerateText(Convert.ToInt32(textBox1.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += richTextBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += richTextBox2.Text;
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            await LogicObj.SetPhrace(richTextBox2.Text);
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = await LogicObj.GetPhrace();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}