namespace kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        double a = 0, b = 0, c = 0;
        char belgi = '+';


        private void button18_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            belgi = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            b = Convert.ToInt32(textBox1.Text);
            switch (belgi)
            {
                case '+':
                    c = b + a; break;
                case '-':
                    c = a - b; break;
                case 'x':
                    c = a * b; break;
                case '÷':
                    c = a / b; break;

            }
            textBox1.Text = c.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text[0] == '-')
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                else textBox1.Text = '-' + textBox1.Text;


            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);

            }
        }
    }
}