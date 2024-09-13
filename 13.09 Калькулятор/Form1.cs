namespace _13._09_Калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {



            }
            else
            {
                int asd = int.Parse(textBox1.Text), dsa = int.Parse(textBox2.Text), fasd;
                fasd = asd + dsa;
                string txt = Convert.ToString(fasd);
                this.textBox3.Text = txt;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {



            }
            else
            {
                int asd = int.Parse(textBox1.Text), dsa = int.Parse(textBox2.Text), fasd;
                fasd = asd - dsa;
                string txt = Convert.ToString(fasd);
                this.textBox3.Text = txt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {



            }
            else
            {
                int asd = int.Parse(textBox1.Text), dsa = int.Parse(textBox2.Text), fasd;
                fasd = asd * dsa;
                string txt = Convert.ToString(fasd);
                this.textBox3.Text = txt;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {



            }
            else
            {
                int asd = int.Parse(textBox1.Text), dsa = int.Parse(textBox2.Text), fasd;
                fasd = asd / dsa;
                string txt = Convert.ToString(fasd);
                this.textBox3.Text = txt;
            }
        }
    }
}
