namespace finalproject
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textnumber = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            istotal = new TextBox();
            label6 = new Label();
            button2 = new Button();
            button1 = new Button();
            texttotal = new TextBox();
            label5 = new Label();
            textprice = new TextBox();
            label4 = new Label();
            textname = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button13 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            fileSystemWatcher1 = new FileSystemWatcher();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(76, 17);
            label1.TabIndex = 0;
            label1.Text = "รหัสสินค้า : ";
            label1.Click += label1_Click;
            // 
            // textnumber
            // 
            textnumber.Location = new Point(116, 31);
            textnumber.Name = "textnumber";
            textnumber.Size = new Size(143, 23);
            textnumber.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 31);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 2;
            label2.Text = "รายการสินค้า";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MistyRose;
            groupBox1.Controls.Add(istotal);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(texttotal);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textprice);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textname);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textnumber);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(471, 199);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูล";
            // 
            // istotal
            // 
            istotal.Location = new Point(116, 147);
            istotal.Name = "istotal";
            istotal.Size = new Size(88, 23);
            istotal.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(6, 148);
            label6.Name = "label6";
            label6.Size = new Size(104, 17);
            label6.TabIndex = 10;
            label6.Text = "รวมราคาสินค้า : ";
            // 
            // button2
            // 
            button2.Location = new Point(326, 94);
            button2.Name = "button2";
            button2.Size = new Size(75, 54);
            button2.TabIndex = 9;
            button2.Text = "ลบ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(326, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 54);
            button1.TabIndex = 8;
            button1.Text = "บันทึก";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // texttotal
            // 
            texttotal.Location = new Point(116, 118);
            texttotal.Name = "texttotal";
            texttotal.Size = new Size(88, 23);
            texttotal.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 119);
            label5.Name = "label5";
            label5.Size = new Size(92, 17);
            label5.TabIndex = 6;
            label5.Text = "จำนวนสินค้า : ";
            // 
            // textprice
            // 
            textprice.Location = new Point(116, 90);
            textprice.Name = "textprice";
            textprice.Size = new Size(88, 23);
            textprice.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 90);
            label4.Name = "label4";
            label4.Size = new Size(81, 17);
            label4.TabIndex = 4;
            label4.Text = "ราคาสินค้า : ";
            // 
            // textname
            // 
            textname.Location = new Point(116, 60);
            textname.Name = "textname";
            textname.Size = new Size(202, 23);
            textname.TabIndex = 3;
            textname.TextChanged += textname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 61);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 2;
            label3.Text = "ชื่อสินค้า : ";
            label3.Click += label3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(489, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(548, 211);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "รหัสสินค้า";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "ชื่อสินค้า";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "ราคาสินค้า";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "จำนวนสินค้า";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "รวมราคาสินค้า";
            Column5.Name = "Column5";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(button10);
            groupBox2.Controls.Add(button11);
            groupBox2.Controls.Add(button12);
            groupBox2.Controls.Add(pictureBox6);
            groupBox2.Controls.Add(pictureBox7);
            groupBox2.Controls.Add(pictureBox8);
            groupBox2.Controls.Add(pictureBox9);
            groupBox2.Controls.Add(pictureBox10);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(pictureBox5);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(12, 279);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1014, 377);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "รายการสินค้า";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button8
            // 
            button8.Location = new Point(849, 334);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 19;
            button8.Text = "เช็คสินค้า";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(640, 334);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 18;
            button9.Text = "เช็คสินค้า";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(451, 334);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 17;
            button10.Text = "เช็คสินค้า";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(260, 334);
            button11.Name = "button11";
            button11.Size = new Size(75, 23);
            button11.TabIndex = 16;
            button11.Text = "เช็คสินค้า";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(61, 334);
            button12.Name = "button12";
            button12.Size = new Size(75, 23);
            button12.TabIndex = 15;
            button12.Text = "เช็คสินค้า";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.pngegg__9_;
            pictureBox6.Location = new Point(804, 217);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(153, 111);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.pngegg__8_;
            pictureBox7.Location = new Point(606, 217);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(153, 111);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 13;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.pngegg__7_;
            pictureBox8.Location = new Point(414, 217);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(153, 111);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 12;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.pngegg__6_;
            pictureBox9.Location = new Point(221, 217);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(153, 111);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 11;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.pngegg__5_;
            pictureBox10.Location = new Point(22, 217);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(153, 111);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 10;
            pictureBox10.TabStop = false;
            // 
            // button7
            // 
            button7.Location = new Point(849, 160);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 9;
            button7.Text = "เช็คสินค้า";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(640, 160);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 8;
            button6.Text = "เช็คสินค้า";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(451, 160);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 7;
            button5.Text = "เช็คสินค้า";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(260, 160);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = "เช็คสินค้า";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(61, 160);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "เช็คสินค้า";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.pngegg__4_;
            pictureBox5.Location = new Point(804, 43);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(153, 111);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.pngegg__3_;
            pictureBox4.Location = new Point(606, 43);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(153, 111);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pngegg__2_;
            pictureBox3.Location = new Point(414, 43);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(153, 111);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pngegg__1_;
            pictureBox2.Location = new Point(221, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(153, 111);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngegg;
            pictureBox1.Location = new Point(22, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button13
            // 
            button13.Location = new Point(962, 251);
            button13.Name = "button13";
            button13.Size = new Size(75, 23);
            button13.TabIndex = 20;
            button13.Text = "ลบรายการ";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1038, 24);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(1038, 668);
            Controls.Add(button13);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textnumber;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox textprice;
        private Label label4;
        private TextBox textname;
        private Label label3;
        private Button button2;
        private Button button1;
        private TextBox texttotal;
        private Label label5;
        private DataGridView dataGridView1;
        private TextBox istotal;
        private Label label6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private GroupBox groupBox2;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button13;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private FileSystemWatcher fileSystemWatcher1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
    }
}