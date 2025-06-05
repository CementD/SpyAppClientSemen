namespace AppClientInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "admin" && password == "1234")
            {
                label2.ForeColor = Color.Green;
                label2.Text = "Successfully logged in!";
            }
            else if (username == "" || password == "")
            {
                label2.ForeColor = Color.OrangeRed;
                label2.Text = "Enter username and password!";
            }
            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Incorrect username or password!";
            }
        }
    }
}
