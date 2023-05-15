namespace BestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowMessage();
        }

        private void ShowMessage()
            => MessageBox.Show(DateTime.Now.ToLongTimeString(), "Data");

        private void button2_Click(object sender, EventArgs e)
            => ShowMessage();
    }
}