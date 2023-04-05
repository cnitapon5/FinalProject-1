using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace finalproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            panel1.Controls.Clear();
            f1.TopLevel = false;
            panel1.Controls.Add(f1);
            f1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f3 = new Form4();
            panel1.Controls.Clear();
            f3.TopLevel = false;
            panel1.Controls.Add(f3);
            f3.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f3.Dock = DockStyle.Fill;
            f3.Show();
        }
    }
}