namespace Email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metn = textBox1.Text;
            if (metn.Contains("@") && metn.Contains("."))
            {
               if(metn.IndexOf("@")-metn.IndexOf(".")==1 ||
                    metn.IndexOf("@") - metn.IndexOf(".") == -1)
                {
                    label2.Text = "Email ünvanı yanlışdır!";
                }
                else
                {
                    label2.Text = "Email ünvanı doğrudur!";
                }
            }
            else
            {
                label2.Text = "Email ünvanı yanlışdır!";
            }

        }
    }
}