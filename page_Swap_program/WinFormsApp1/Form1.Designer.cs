namespace WinFormsApp1
{
    partial class Form1 : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            panel2 = new Panel();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel6 = new Panel();
            button43 = new Button();
            button42 = new Button();
            button41 = new Button();
            button40 = new Button();
            button39 = new Button();
            button38 = new Button();
            button37 = new Button();
            button36 = new Button();
            button35 = new Button();
            button34 = new Button();
            panel5 = new Panel();
            button33 = new Button();
            button32 = new Button();
            button31 = new Button();
            button30 = new Button();
            button29 = new Button();
            button28 = new Button();
            button27 = new Button();
            button26 = new Button();
            button25 = new Button();
            button24 = new Button();
            panel4 = new Panel();
            button23 = new Button();
            button22 = new Button();
            button21 = new Button();
            button20 = new Button();
            button19 = new Button();
            button18 = new Button();
            button17 = new Button();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            panel3 = new Panel();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            panel7 = new Panel();
            dataGridView1 = new DataGridView();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            panel8 = new Panel();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label10 = new Label();
            panel9 = new Panel();
            button44 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox11 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 59);
            label1.Name = "label1";
            label1.Size = new Size(234, 32);
            label1.TabIndex = 0;
            label1.Text = "作业指令总数：320";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 140);
            label2.Name = "label2";
            label2.Size = new Size(269, 32);
            label2.TabIndex = 1;
            label2.Text = "每页存放的指令数：10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 219);
            label3.Name = "label3";
            label3.Size = new Size(254, 32);
            label3.TabIndex = 2;
            label3.Text = "作业占用内存页数：4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 301);
            label4.Name = "label4";
            label4.Size = new Size(164, 32);
            label4.TabIndex = 3;
            label4.Text = "页面置换算法";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 382);
            label5.Name = "label5";
            label5.Size = new Size(164, 32);
            label5.TabIndex = 4;
            label5.Text = "指令执行顺序";
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 466);
            panel1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "顺序执行", "随机执行", "混合执行" });
            comboBox2.Location = new Point(185, 386);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(104, 28);
            comboBox2.TabIndex = 11;
            comboBox2.Text = "顺序执行";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "FIFO算法", "LRU算法" });
            comboBox1.Location = new Point(185, 305);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(104, 28);
            comboBox1.TabIndex = 11;
            comboBox1.Text = "FIFO算法";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(221, 0);
            label6.Name = "label6";
            label6.Size = new Size(164, 32);
            label6.TabIndex = 6;
            label6.Text = "内存中的页面";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox10);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(337, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(604, 466);
            panel2.TabIndex = 7;
            // 
            // textBox10
            // 
            textBox10.BackColor = SystemColors.Control;
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox10.Location = new Point(455, 93);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(125, 22);
            textBox10.TabIndex = 14;
            textBox10.Text = "驻留X周期";
            textBox10.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            textBox9.BackColor = SystemColors.Control;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(310, 93);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 22);
            textBox9.TabIndex = 13;
            textBox9.Text = "驻留X周期";
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.Control;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(162, 93);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 22);
            textBox8.TabIndex = 12;
            textBox8.Text = "驻留X周期";
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Control;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(17, 93);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 22);
            textBox7.TabIndex = 11;
            textBox7.Text = "驻留X周期";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(457, 59);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 22);
            textBox4.TabIndex = 10;
            textBox4.Text = "第X页";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(310, 59);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 22);
            textBox3.TabIndex = 9;
            textBox3.Text = "第X页";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(163, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 22);
            textBox2.TabIndex = 8;
            textBox2.Text = "第X页";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(18, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 22);
            textBox1.TabIndex = 7;
            textBox1.Text = "第X页";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel6
            // 
            panel6.Controls.Add(button43);
            panel6.Controls.Add(button42);
            panel6.Controls.Add(button41);
            panel6.Controls.Add(button40);
            panel6.Controls.Add(button39);
            panel6.Controls.Add(button38);
            panel6.Controls.Add(button37);
            panel6.Controls.Add(button36);
            panel6.Controls.Add(button35);
            panel6.Controls.Add(button34);
            panel6.Location = new Point(457, 121);
            panel6.Name = "panel6";
            panel6.Size = new Size(126, 332);
            panel6.TabIndex = 3;
            // 
            // button43
            // 
            button43.BackColor = SystemColors.Window;
            button43.Location = new Point(3, 301);
            button43.Name = "button43";
            button43.Size = new Size(120, 27);
            button43.TabIndex = 31;
            button43.Text = "9";
            button43.UseVisualStyleBackColor = false;
            // 
            // button42
            // 
            button42.BackColor = SystemColors.Window;
            button42.Location = new Point(3, 268);
            button42.Name = "button42";
            button42.Size = new Size(120, 27);
            button42.TabIndex = 30;
            button42.Text = "8";
            button42.UseVisualStyleBackColor = false;
            // 
            // button41
            // 
            button41.BackColor = SystemColors.Window;
            button41.Location = new Point(3, 235);
            button41.Name = "button41";
            button41.Size = new Size(120, 27);
            button41.TabIndex = 29;
            button41.Text = "7";
            button41.UseVisualStyleBackColor = false;
            // 
            // button40
            // 
            button40.BackColor = SystemColors.Window;
            button40.Location = new Point(3, 202);
            button40.Name = "button40";
            button40.Size = new Size(120, 27);
            button40.TabIndex = 28;
            button40.Text = "6";
            button40.UseVisualStyleBackColor = false;
            // 
            // button39
            // 
            button39.BackColor = SystemColors.Window;
            button39.Location = new Point(3, 169);
            button39.Name = "button39";
            button39.Size = new Size(120, 27);
            button39.TabIndex = 27;
            button39.Text = "5";
            button39.UseVisualStyleBackColor = false;
            // 
            // button38
            // 
            button38.BackColor = SystemColors.Window;
            button38.Location = new Point(3, 136);
            button38.Name = "button38";
            button38.Size = new Size(120, 27);
            button38.TabIndex = 26;
            button38.Text = "4";
            button38.UseVisualStyleBackColor = false;
            // 
            // button37
            // 
            button37.BackColor = SystemColors.Window;
            button37.Location = new Point(3, 103);
            button37.Name = "button37";
            button37.Size = new Size(120, 27);
            button37.TabIndex = 25;
            button37.Text = "3";
            button37.UseVisualStyleBackColor = false;
            // 
            // button36
            // 
            button36.BackColor = SystemColors.Window;
            button36.Location = new Point(3, 70);
            button36.Name = "button36";
            button36.Size = new Size(120, 27);
            button36.TabIndex = 24;
            button36.Text = "2";
            button36.UseVisualStyleBackColor = false;
            // 
            // button35
            // 
            button35.BackColor = SystemColors.Window;
            button35.Location = new Point(3, 35);
            button35.Name = "button35";
            button35.Size = new Size(120, 27);
            button35.TabIndex = 23;
            button35.Text = "1";
            button35.UseVisualStyleBackColor = false;
            // 
            // button34
            // 
            button34.BackColor = SystemColors.Window;
            button34.Location = new Point(1, 3);
            button34.Name = "button34";
            button34.Size = new Size(120, 27);
            button34.TabIndex = 22;
            button34.Text = "0";
            button34.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(button33);
            panel5.Controls.Add(button32);
            panel5.Controls.Add(button31);
            panel5.Controls.Add(button30);
            panel5.Controls.Add(button29);
            panel5.Controls.Add(button28);
            panel5.Controls.Add(button27);
            panel5.Controls.Add(button26);
            panel5.Controls.Add(button25);
            panel5.Controls.Add(button24);
            panel5.Location = new Point(310, 121);
            panel5.Name = "panel5";
            panel5.Size = new Size(126, 332);
            panel5.TabIndex = 2;
            // 
            // button33
            // 
            button33.BackColor = SystemColors.Window;
            button33.Location = new Point(3, 302);
            button33.Name = "button33";
            button33.Size = new Size(120, 27);
            button33.TabIndex = 21;
            button33.Text = "9";
            button33.UseVisualStyleBackColor = false;
            // 
            // button32
            // 
            button32.BackColor = SystemColors.Window;
            button32.Location = new Point(3, 269);
            button32.Name = "button32";
            button32.Size = new Size(120, 27);
            button32.TabIndex = 20;
            button32.Text = "8";
            button32.UseVisualStyleBackColor = false;
            // 
            // button31
            // 
            button31.BackColor = SystemColors.Window;
            button31.Location = new Point(3, 236);
            button31.Name = "button31";
            button31.Size = new Size(120, 27);
            button31.TabIndex = 19;
            button31.Text = "7";
            button31.UseVisualStyleBackColor = false;
            // 
            // button30
            // 
            button30.BackColor = SystemColors.Window;
            button30.Location = new Point(3, 203);
            button30.Name = "button30";
            button30.Size = new Size(120, 27);
            button30.TabIndex = 18;
            button30.Text = "6";
            button30.UseVisualStyleBackColor = false;
            // 
            // button29
            // 
            button29.BackColor = SystemColors.Window;
            button29.Location = new Point(3, 171);
            button29.Name = "button29";
            button29.Size = new Size(120, 27);
            button29.TabIndex = 17;
            button29.Text = "5";
            button29.UseVisualStyleBackColor = false;
            // 
            // button28
            // 
            button28.BackColor = SystemColors.Window;
            button28.Location = new Point(3, 136);
            button28.Name = "button28";
            button28.Size = new Size(120, 27);
            button28.TabIndex = 16;
            button28.Text = "4";
            button28.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            button27.BackColor = SystemColors.Window;
            button27.Location = new Point(3, 103);
            button27.Name = "button27";
            button27.Size = new Size(120, 27);
            button27.TabIndex = 15;
            button27.Text = "3";
            button27.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            button26.BackColor = SystemColors.Window;
            button26.Location = new Point(3, 70);
            button26.Name = "button26";
            button26.Size = new Size(120, 27);
            button26.TabIndex = 14;
            button26.Text = "2";
            button26.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            button25.BackColor = SystemColors.Window;
            button25.Location = new Point(3, 37);
            button25.Name = "button25";
            button25.Size = new Size(120, 27);
            button25.TabIndex = 13;
            button25.Text = "1";
            button25.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            button24.BackColor = SystemColors.Window;
            button24.Location = new Point(3, 3);
            button24.Name = "button24";
            button24.Size = new Size(120, 27);
            button24.TabIndex = 12;
            button24.Text = "0";
            button24.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(button23);
            panel4.Controls.Add(button22);
            panel4.Controls.Add(button21);
            panel4.Controls.Add(button20);
            panel4.Controls.Add(button19);
            panel4.Controls.Add(button18);
            panel4.Controls.Add(button17);
            panel4.Controls.Add(button16);
            panel4.Controls.Add(button15);
            panel4.Controls.Add(button14);
            panel4.Location = new Point(162, 121);
            panel4.Name = "panel4";
            panel4.Size = new Size(126, 332);
            panel4.TabIndex = 1;
            // 
            // button23
            // 
            button23.BackColor = SystemColors.Window;
            button23.Location = new Point(3, 302);
            button23.Name = "button23";
            button23.Size = new Size(120, 27);
            button23.TabIndex = 21;
            button23.Text = "9";
            button23.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            button22.BackColor = SystemColors.Window;
            button22.Location = new Point(3, 269);
            button22.Name = "button22";
            button22.Size = new Size(120, 27);
            button22.TabIndex = 20;
            button22.Text = "8";
            button22.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            button21.BackColor = SystemColors.Window;
            button21.Location = new Point(3, 237);
            button21.Name = "button21";
            button21.Size = new Size(120, 27);
            button21.TabIndex = 19;
            button21.Text = "7";
            button21.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            button20.BackColor = SystemColors.Window;
            button20.Location = new Point(3, 203);
            button20.Name = "button20";
            button20.Size = new Size(120, 27);
            button20.TabIndex = 18;
            button20.Text = "6";
            button20.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            button19.BackColor = SystemColors.Window;
            button19.Location = new Point(3, 171);
            button19.Name = "button19";
            button19.Size = new Size(120, 27);
            button19.TabIndex = 17;
            button19.Text = "5";
            button19.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            button18.BackColor = SystemColors.Window;
            button18.Location = new Point(3, 136);
            button18.Name = "button18";
            button18.Size = new Size(120, 27);
            button18.TabIndex = 16;
            button18.Text = "4";
            button18.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            button17.BackColor = SystemColors.Window;
            button17.Location = new Point(3, 103);
            button17.Name = "button17";
            button17.Size = new Size(120, 27);
            button17.TabIndex = 15;
            button17.Text = "3";
            button17.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = SystemColors.Window;
            button16.Location = new Point(3, 70);
            button16.Name = "button16";
            button16.Size = new Size(120, 27);
            button16.TabIndex = 14;
            button16.Text = "2";
            button16.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.Window;
            button15.Location = new Point(3, 37);
            button15.Name = "button15";
            button15.Size = new Size(120, 27);
            button15.TabIndex = 13;
            button15.Text = "1";
            button15.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = SystemColors.Window;
            button14.Location = new Point(3, 3);
            button14.Name = "button14";
            button14.Size = new Size(120, 27);
            button14.TabIndex = 12;
            button14.Text = "0";
            button14.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(button13);
            panel3.Controls.Add(button12);
            panel3.Controls.Add(button11);
            panel3.Controls.Add(button10);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Location = new Point(17, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(126, 332);
            panel3.TabIndex = 0;
            // 
            // button13
            // 
            button13.BackColor = SystemColors.Window;
            button13.Location = new Point(3, 302);
            button13.Name = "button13";
            button13.Size = new Size(120, 27);
            button13.TabIndex = 20;
            button13.Text = "9";
            button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.Window;
            button12.Location = new Point(3, 269);
            button12.Name = "button12";
            button12.Size = new Size(120, 27);
            button12.TabIndex = 19;
            button12.Text = "8";
            button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.Window;
            button11.Location = new Point(3, 236);
            button11.Name = "button11";
            button11.Size = new Size(120, 27);
            button11.TabIndex = 18;
            button11.Text = "7";
            button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.Window;
            button10.Location = new Point(3, 203);
            button10.Name = "button10";
            button10.Size = new Size(120, 27);
            button10.TabIndex = 17;
            button10.Text = "6";
            button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.Window;
            button9.Location = new Point(3, 171);
            button9.Name = "button9";
            button9.Size = new Size(120, 27);
            button9.TabIndex = 16;
            button9.Text = "5";
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.Window;
            button8.Location = new Point(3, 138);
            button8.Name = "button8";
            button8.Size = new Size(120, 27);
            button8.TabIndex = 15;
            button8.Text = "4";
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Window;
            button7.Location = new Point(3, 103);
            button7.Name = "button7";
            button7.Size = new Size(120, 27);
            button7.TabIndex = 14;
            button7.Text = "3";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Window;
            button6.Location = new Point(3, 70);
            button6.Name = "button6";
            button6.Size = new Size(120, 27);
            button6.TabIndex = 13;
            button6.Text = "2";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Window;
            button5.Location = new Point(3, 35);
            button5.Name = "button5";
            button5.Size = new Size(120, 27);
            button5.TabIndex = 12;
            button5.Text = "1";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Window;
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(120, 27);
            button4.TabIndex = 11;
            button4.Text = "0";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(dataGridView1);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(947, 80);
            panel7.Name = "panel7";
            panel7.Size = new Size(408, 466);
            panel7.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4 });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Microsoft YaHei UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.Location = new Point(3, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(402, 373);
            dataGridView1.TabIndex = 1;
            // 
            // DataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle6.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            DataGridViewTextBoxColumn1.HeaderText = "地址";
            DataGridViewTextBoxColumn1.MinimumWidth = 6;
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.ReadOnly = true;
            DataGridViewTextBoxColumn1.Width = 82;
            // 
            // DataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle7.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle7;
            DataGridViewTextBoxColumn2.HeaderText = "缺页";
            DataGridViewTextBoxColumn2.MinimumWidth = 6;
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.ReadOnly = true;
            DataGridViewTextBoxColumn2.Width = 82;
            // 
            // DataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle8.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            DataGridViewTextBoxColumn3.HeaderText = "换出页";
            DataGridViewTextBoxColumn3.MinimumWidth = 6;
            DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            DataGridViewTextBoxColumn3.ReadOnly = true;
            DataGridViewTextBoxColumn3.Width = 82;
            // 
            // DataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle9.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle9;
            DataGridViewTextBoxColumn4.HeaderText = "换入页";
            DataGridViewTextBoxColumn4.MinimumWidth = 6;
            DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            DataGridViewTextBoxColumn4.ReadOnly = true;
            DataGridViewTextBoxColumn4.Width = 82;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(132, 0);
            label7.Name = "label7";
            label7.Size = new Size(139, 32);
            label7.TabIndex = 0;
            label7.Text = "已执行指令";
            // 
            // panel8
            // 
            panel8.Controls.Add(textBox6);
            panel8.Controls.Add(textBox5);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(label8);
            panel8.Location = new Point(947, 552);
            panel8.Name = "panel8";
            panel8.Size = new Size(408, 125);
            panel8.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Control;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(132, 67);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 32);
            textBox6.TabIndex = 2;
            textBox6.Text = "0";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(132, 24);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 32);
            textBox5.TabIndex = 0;
            textBox5.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(25, 69);
            label9.Name = "label9";
            label9.Size = new Size(114, 32);
            label9.TabIndex = 1;
            label9.Text = "缺页率：";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(25, 24);
            label8.Name = "label8";
            label8.Size = new Size(114, 32);
            label8.TabIndex = 0;
            label8.Text = "缺页数：";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("仿宋", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(469, 31);
            label10.Name = "label10";
            label10.Size = new Size(423, 34);
            label10.TabIndex = 10;
            label10.Text = "请求调页存储管理方式模拟";
            // 
            // panel9
            // 
            panel9.Controls.Add(button44);
            panel9.Controls.Add(button3);
            panel9.Controls.Add(button2);
            panel9.Controls.Add(button1);
            panel9.Location = new Point(337, 552);
            panel9.Name = "panel9";
            panel9.Size = new Size(604, 125);
            panel9.TabIndex = 11;
            // 
            // button44
            // 
            button44.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button44.Location = new Point(393, 71);
            button44.Name = "button44";
            button44.Size = new Size(109, 44);
            button44.TabIndex = 3;
            button44.Text = "暂停";
            button44.UseVisualStyleBackColor = true;
            button44.Click += button44_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(99, 71);
            button3.Name = "button3";
            button3.Size = new Size(109, 44);
            button3.TabIndex = 2;
            button3.Text = "重置";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Chartreuse;
            button2.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(393, 21);
            button2.Name = "button2";
            button2.Size = new Size(109, 44);
            button2.TabIndex = 1;
            button2.Text = "连续执行";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(99, 21);
            button1.Name = "button1";
            button1.Size = new Size(109, 44);
            button1.TabIndex = 0;
            button1.Text = "单步执行";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 552);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(319, 125);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += button2_Click;
            // 
            // textBox11
            // 
            textBox11.BackColor = SystemColors.Control;
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox11.Location = new Point(42, 590);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(269, 43);
            textBox11.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 695);
            Controls.Add(textBox11);
            Controls.Add(pictureBox1);
            Controls.Add(panel9);
            Controls.Add(label10);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "请求调页存储管理方式模拟";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Label label6;
        private Panel panel2;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel7;
        private Label label7;
        private Panel panel8;
        private Label label9;
        private Label label8;
        private Label label10;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Panel panel9;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button28;
        private Button button27;
        private Button button26;
        private Button button25;
        private Button button24;
        private Button button23;
        private Button button22;
        private Button button21;
        private Button button20;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button36;
        private Button button35;
        private Button button34;
        private Button button33;
        private Button button32;
        private Button button31;
        private Button button30;
        private Button button29;
        private Button button43;
        private Button button42;
        private Button button41;
        private Button button40;
        private Button button39;
        private Button button38;
        private Button button37;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private TextBox textBox6;
        private TextBox textBox5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox11;
        private Button button44;
    }
}