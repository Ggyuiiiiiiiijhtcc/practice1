namespace CountClickButton
{
    public partial class Form1 : Form
    {
        int countClick = 0;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var temp = sender as Button;
            temp.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            countClick++;
            label1.Text = "Count: " + countClick;
        }
    }
}