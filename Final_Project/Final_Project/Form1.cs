namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("กรุณาใส่ชื่อผู้ใช้", "ผิดพลาด");
                }
                else
                {
                    textBox2.Focus();
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("กรุณาใส่ชื่อผู้ใช้", "ผิดพลาด");
                    textBox2.Clear();
                    textBox2.Focus();
                }
                else if (textBox2.Text == "55555")
                {
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("รหัสผิดพลาก", "ผิดพลาด");
                    textBox2.Clear();
                    textBox2.Focus();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}