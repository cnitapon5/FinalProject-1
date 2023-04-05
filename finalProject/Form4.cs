using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBox4.Text);
            int total = Convert.ToInt32(textBox5.Text);
            int a = price * total;
            textBox6.Text = a.ToString();

            string name = listBox1.Text;
            string date = dateTimePicker1.Text;
            string dateout = dateTimePicker2.Text;
            string pricetotal = textBox4.Text;
            string total1 = textBox5.Text;
            string istotal1 = textBox6.Text;

            //เข้าตาราง
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = name;
            dataGridView1.Rows[n].Cells[1].Value = date;
            dataGridView1.Rows[n].Cells[2].Value = dateout;
            dataGridView1.Rows[n].Cells[3].Value = pricetotal;
            dataGridView1.Rows[n].Cells[4].Value = total1;
            dataGridView1.Rows[n].Cells[5].Value = istotal1;

            //เคลีย
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndax = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndax);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}