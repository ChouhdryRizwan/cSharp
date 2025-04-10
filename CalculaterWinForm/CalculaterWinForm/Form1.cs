namespace CalculaterWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 + num2;

                //MessageBox.Show("The result is: " + result.ToString(), "Result");
                label4.Text = "Addition result is: " + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in both text boxes.", "Error");
            }
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 - num2;

                //MessageBox.Show("The result is: " + result.ToString(), "Result");
                label4.Text = "Subtract result is: " + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in both text boxes.", "Error");
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 * num2;

                //MessageBox.Show("The result is: " + result.ToString(), "Result");
                label4.Text = "Multiply result is: " + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in both text boxes.", "Error");
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 / num2;

                //MessageBox.Show("The result is: " + result.ToString(), "Result");
                label4.Text = "Division result is: " + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in both text boxes.", "Error");
            }
        }
    }
}
