namespace fukuv0524
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left - 20;
            label1.Text = "���ɍs����";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left + 20;
            label1.Text = "�E�ɍs����";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top - 20;
            label1.Text = "��ɍs����";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top + 20;
            label1.Text = "���ɍs����";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "�����N�l";
            label1.ForeColor = Color.Red;
        }
    }
}