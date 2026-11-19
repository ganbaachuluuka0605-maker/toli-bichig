namespace toli_bichig
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dgvWords = new ComboBox();
            dataGridView1 = new DataGridView();
            ColNumber = new DataGridViewTextBoxColumn();
            ColEnglish = new DataGridViewTextBoxColumn();
            ColRussian = new DataGridViewTextBoxColumn();
            ColMongolian = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            colorDialog1 = new ColorDialog();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(89, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Хайх үг";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 15);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 1;
            label1.Text = "Хайх:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 15);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 2;
            label2.Text = "Хэл:";
            // 
            // dgvWords
            // 
            dgvWords.FormattingEnabled = true;
            dgvWords.Location = new Point(460, 12);
            dgvWords.Name = "dgvWords";
            dgvWords.Size = new Size(143, 28);
            dgvWords.TabIndex = 3;
            dgvWords.Text = "Бүгд";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColNumber, ColEnglish, ColRussian, ColMongolian });
            dataGridView1.Location = new Point(12, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(385, 188);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // ColNumber
            // 
            ColNumber.HeaderText = "№";
            ColNumber.MinimumWidth = 6;
            ColNumber.Name = "ColNumber";
            ColNumber.Width = 40;
            // 
            // ColEnglish
            // 
            ColEnglish.HeaderText = "Англи";
            ColEnglish.MinimumWidth = 6;
            ColEnglish.Name = "ColEnglish";
            ColEnglish.Width = 125;
            // 
            // ColRussian
            // 
            ColRussian.HeaderText = "Орос";
            ColRussian.MinimumWidth = 6;
            ColRussian.Name = "ColRussian";
            ColRussian.Width = 125;
            // 
            // ColMongolian
            // 
            ColMongolian.HeaderText = "Монгол";
            ColMongolian.MinimumWidth = 6;
            ColMongolian.Name = "ColMongolian";
            ColMongolian.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(14, 370);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "+Нэмэх";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(128, 370);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Засах";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(243, 370);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "Устгах";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(360, 370);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 8;
            button4.Text = "Цэвэрлэх";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = Color.PaleGreen;
            button5.Location = new Point(472, 370);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 9;
            button5.Text = "Санах";
            button5.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 76);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 10;
            label3.Text = "toli.db-words";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(418, 76);
            label4.Name = "label4";
            label4.Size = new Size(158, 20);
            label4.TabIndex = 11;
            label4.Text = "saved.db-saved_words";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.PaleGreen;
            textBox2.ForeColor = SystemColors.ActiveCaptionText;
            textBox2.Location = new Point(418, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 27);
            textBox2.TabIndex = 12;
            textBox2.Text = "Санасан үгс";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(418, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(182, 27);
            textBox3.TabIndex = 13;
            textBox3.Text = "Хоосон";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 327);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 14;
            label5.Text = "Англи";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(62, 327);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(203, 330);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 16;
            label6.Text = "Орос";
            label6.Click += label6_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(254, 327);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(403, 330);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 18;
            label7.Text = "Монгол";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(472, 327);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 405);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 20;
            label8.Text = "Нийт: 10 үг ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 450);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(dgvWords);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Гурван хэлний толь бичиг";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private ComboBox dgvWords;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColNumber;
        private DataGridViewTextBoxColumn ColEnglish;
        private DataGridViewTextBoxColumn ColRussian;
        private DataGridViewTextBoxColumn ColMongolian;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private ColorDialog colorDialog1;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
    }
}
