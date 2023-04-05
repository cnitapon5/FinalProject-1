using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace finalproject
{
    public partial class Form2 : Form
    {
        picturelogocar1 Picturelogocar1 = new picturelogocar1();
        picturelocar2 picturelocar2 = new picturelocar2();
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string Number7 = picturelocar2.getnumber7();
            textnumber.Text = Number7;

            string name7 = picturelocar2.getName7();
            textname.Text = name7;

            string Price7 = picturelocar2.getPrice7();
            textprice.Text = Price7;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Number = Picturelogocar1.getnumber();
            textnumber.Text = Number;

            string name = Picturelogocar1.getName();
            textname.Text = name;

            string Price = Picturelogocar1.getPrice();
            textprice.Text = Price;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Number1 = Picturelogocar1.getnumber1();
            textnumber.Text = Number1;

            string name1 = Picturelogocar1.getName1();
            textname.Text = name1;

            string Price1 = Picturelogocar1.getPrice1();
            textprice.Text = Price1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Number3 = Picturelogocar1.getnumber3();
            textnumber.Text = Number3;

            string name3 = Picturelogocar1.getName3();
            textname.Text = name3;

            string Price3 = Picturelogocar1.getPrice3();
            textprice.Text = Price3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string Number4 = Picturelogocar1.getnumber4();
            textnumber.Text = Number4;

            string name4 = Picturelogocar1.getName4();
            textname.Text = name4;

            string Price4 = Picturelogocar1.getPrice4();
            textprice.Text = Price4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string Number5 = Picturelogocar1.getnumber5();
            textnumber.Text = Number5;

            string name5 = Picturelogocar1.getName5();
            textname.Text = name5;

            string Price5 = Picturelogocar1.getPrice5();
            textprice.Text = Price5;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string Number6 = Picturelogocar1.getnumber();
            textnumber.Text = Number6;

            string name6 = Picturelogocar1.getName6();
            textname.Text = name6;

            string Price6 = Picturelogocar1.getPrice6();
            textprice.Text = Price6;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string Number8 = picturelocar2.getnumber8();
            textnumber.Text = Number8;

            string name8 = picturelocar2.getName8();
            textname.Text = name8;

            string Price8 = Picturelogocar1.getPrice();
            textprice.Text = Price8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string Number9 = picturelocar2.getnumber9();
            textnumber.Text = Number9;

            string name9 = picturelocar2.getName9();
            textname.Text = name9;

            string Price9 = Picturelogocar1.getPrice();
            textprice.Text = Price9;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string Number10 = picturelocar2.getnumber10();
            textnumber.Text = Number10;

            string name10 = picturelocar2.getName10();
            textname.Text = name10;

            string Price10 = picturelocar2.getPrice10();
            textprice.Text = Price10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textprice.Text);
            int total = Convert.ToInt32(texttotal.Text);
            int a = price * total;
            istotal.Text = a.ToString();

            string number = textnumber.Text;
            string name = textname.Text;
            string price1 = textprice.Text;
            string total1 = texttotal.Text;
            string istotal1 = istotal.Text;

            //เข้าตาราง
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = number;
            dataGridView1.Rows[n].Cells[1].Value = name;
            dataGridView1.Rows[n].Cells[2].Value = price1;
            dataGridView1.Rows[n].Cells[3].Value = total1;
            dataGridView1.Rows[n].Cells[4].Value = istotal1;
            //เคลีย
            textnumber.Clear();
            textname.Clear();
            textprice.Clear();
            texttotal.Clear();
            istotal.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int rowIndax = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndax);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);

                string readAllText = File.ReadAllText(openFileDialog.FileName);
                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string allDATARAW = readAllLine[i];
                    string[] allDATASplited = allDATARAW.Split(',');
                    this.dataGridView1.Rows.Add(allDATASplited[0], allDATASplited[1], allDATASplited[2], allDATASplited[3], allDATASplited[4]);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null && dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV(.csv)|.csv";
                if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
                {
                    try
                    {
                        int columnCount = dataGridView1.Columns.Count;
                        string columnNames = "";
                        string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                        for (int i = 0; i < columnCount; i++)
                        {
                            columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                        }
                        outputCSV[0] += columnNames;
                        for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < columnCount; j++)
                            {
                                var cellValue = dataGridView1.Rows[i - 1].Cells[j].Value;
                                outputCSV[i] += cellValue != null ? cellValue.ToString() + "," : ",";
                            }
                        }
                        File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);
                        MessageBox.Show("Exported to CSV successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textnumber.Clear();
            textname.Clear();
            textprice.Clear();
            texttotal.Clear();
            istotal.Clear();
        }
    }
}
