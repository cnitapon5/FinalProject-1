using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{
    public partial class Form1 : Form
    {
        Archlogobrushedhoodie archlogobrushedhoodie;
        Archlogohoodzip_up archlogohoodzip_Up;
        NesticKickFleece nesticKickFleece;
        Fadepatterncardigan fadepatterncardigan;
        Splitbrushedhoodie splitbrushedhoodie;



        Hoodie[] hoodiedex;

        public Form1()
        {
            InitializeComponent();
            hoodiedex = new Hoodie[7];

            archlogobrushedhoodie = new Archlogobrushedhoodie();
            archlogohoodzip_Up = new Archlogohoodzip_up();
            nesticKickFleece = new NesticKickFleece();
            fadepatterncardigan = new Fadepatterncardigan();
            splitbrushedhoodie = new Splitbrushedhoodie();




            hoodiedex[0] = archlogobrushedhoodie;
            hoodiedex[0] = archlogohoodzip_Up;
            hoodiedex[0] = nesticKickFleece;
            hoodiedex[0] = fadepatterncardigan;
            hoodiedex[0] = splitbrushedhoodie;
        }

        private void displayHoodie()
        {
            this.textName.Text = hoodiedex[0].getName();
            this.textColor.Text = hoodiedex[0].getColor();
            this.textPrice.Text = hoodiedex[0].getPrice();
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
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV(*.csv)|*.csv";
                bool fileError = false;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string column = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                column += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += column;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(saveFileDialog.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textPrice.Text);
            int total = Convert.ToInt32(textTotal.Text);
            int a = price * total;
            textBoxGetprice.Text = a.ToString();


            string Name = textName.Text;
            string Color = textColor.Text;
            string Price = textPrice.Text;
            string Total = textTotal.Text;
            string Getprice = textBoxGetprice.Text;


            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = Name;
            dataGridView1.Rows[n].Cells[1].Value = Color;
            dataGridView1.Rows[n].Cells[2].Value = Price;
            dataGridView1.Rows[n].Cells[3].Value = Total;
            dataGridView1.Rows[n].Cells[4].Value = Getprice;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            //if (radioButton5.Checked == true)
            //{
            //    string hoodie5 = "split brushed hoodie";
            //    string Color5 = "blk";
            //    string price5 = "1600";
            //    textName.Text = hoodie5;
            //    textColor.Text = Color5;
            //    textPrice.Text = price5;
            //}
            //if (radioButton6.Checked == true)
            //{
            //    string hoodie6 = "Paint Play Raised";
            //    string Color6 = "blk";
            //    string price6 = "1530";
            //    textName.Text = hoodie6;
            //    textColor.Text = Color6;
            //    textPrice.Text = price6;

            //}
            //if (radioButton7.Checked == true)
            //{
            //    string hoodie7 = "snug overfit fleece ";
            //    string Color7 = "blk";
            //    string price7 = "1230";
            //    textName.Text = hoodie7;
            //    textColor.Text = Color7;
            //    textPrice.Text = price7;
            //}
            //if (radioButton8.Checked == true)
            //{
            //    string hoodie8 = "blocking windbreaker";
            //    string Color8 = "Navy";
            //    string price8 = "1830";
            //    textName.Text = hoodie8;
            //    textColor.Text = Color8;
            //    textPrice.Text = price8;
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hoodie a1 = hoodiedex[0];
            Hoodie a2 = hoodiedex[1];
            Hoodie a3 = hoodiedex[2];

            displayHoodie();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hoodie b1 = hoodiedex[0];
            Hoodie b2 = hoodiedex[1];
            Hoodie b3 = hoodiedex[2];

            displayHoodie();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hoodie c1 = hoodiedex[0];
            Hoodie c2 = hoodiedex[1];
            Hoodie c3 = hoodiedex[2];

            displayHoodie();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hoodie d1 = hoodiedex[0];
            Hoodie d2 = hoodiedex[1];
            Hoodie d3 = hoodiedex[2];

            displayHoodie();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hoodie f1 = hoodiedex[0];
            Hoodie f2 = hoodiedex[1];
            Hoodie f3 = hoodiedex[2];

            displayHoodie();
        }
    }
}
