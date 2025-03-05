using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dekstopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Welcome to our App");
           int mydate =  datepicker.Value.Year;
            label2.Text = mydate.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
