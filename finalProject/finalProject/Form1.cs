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
        Archlogobrushedhoodie archlogobrushedhoodie = new Archlogobrushedhoodie();
        Archlogohoodzip_up archlogohoodzip_Up = new Archlogohoodzip_up();
        NesticKickFleece nesticKickFleece = new NesticKickFleece();
        Fadepatterncardigan fadepatterncardigan = new Fadepatterncardigan();
        Splitbrushedhoodie splitbrushedhoodie = new Splitbrushedhoodie();
        PaintPlayRaised paintPlayRaised = new PaintPlayRaised();
        Snugoverfitfleece snugoverfitfleece = new Snugoverfitfleece();
        Blockingwindbreaker blockingwindbreaker = new Blockingwindbreaker();
        public Form1()
        {
            InitializeComponent();
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

            textName.Text = "";
            textColor.Text = "";
            textPrice.Text = "";
            textTotal.Text = "";
            textBoxGetprice.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string Name = archlogobrushedhoodie.getName();
            textName.Text = Name;

            string Color = archlogobrushedhoodie.getColor();
            textColor.Text = Color;

            string Price = archlogobrushedhoodie.getPrice();
            textPrice.Text = Price;
        } 
        private void button4_Click(object sender, EventArgs e)
        {
            string Name = archlogohoodzip_Up.getName();
            textName.Text = Name;

            string Color = archlogohoodzip_Up.getColor();
            textColor.Text = Color;

            string Price = archlogohoodzip_Up.getPrice();
            textPrice.Text = Price;
        }
       

        private void button7_Click_1(object sender, EventArgs e)
        {
            string Name = splitbrushedhoodie.getName();
            textName.Text = Name;

            string Color = splitbrushedhoodie.getColor();
            textColor.Text = Color;

            string Price = splitbrushedhoodie.getPrice();
            textPrice.Text = Price;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string Name = paintPlayRaised.getName();
            textName.Text = Name;

            string Color = paintPlayRaised.getColor();
            textColor.Text = Color;

            string Price = paintPlayRaised.getPrice();
            textPrice.Text = Price;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string Name = snugoverfitfleece.getName();
            textName.Text = Name;

            string Color = snugoverfitfleece.getColor();
            textColor.Text = Color;

            string Price = snugoverfitfleece.getPrice();
            textPrice.Text = Price;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string Name = blockingwindbreaker.getName();
            textName.Text = Name;

            string Color = blockingwindbreaker.getColor();
            textColor.Text = Color;

            string Price = blockingwindbreaker.getPrice();
            textPrice.Text = Price;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string Name = nesticKickFleece.getName();
            textName.Text = Name;

            string Color = nesticKickFleece.getColor();
            textColor.Text = Color;

            string Price = nesticKickFleece.getPrice();
            textPrice.Text = Price;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string Name = fadepatterncardigan.getName();
            textName.Text = Name;

            string Color = fadepatterncardigan.getColor();
            textColor.Text = Color;

            string Price = fadepatterncardigan.getPrice();
            textPrice.Text = Price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndax = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndax);
        }
    }
}
