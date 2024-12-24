namespace Курсова_робота
{
    partial class professor
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
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button4 = new Button();
            groupBox3 = new GroupBox();
            textBox4 = new TextBox();
            label4 = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(651, 21);
            button3.Name = "button3";
            button3.Size = new Size(250, 38);
            button3.TabIndex = 2;
            button3.Text = "Список студентів за предметом";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1032, 387);
            dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(139, 21);
            button1.Name = "button1";
            button1.Size = new Size(250, 38);
            button1.TabIndex = 4;
            button1.Text = "Вивести всіх учнів";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(395, 21);
            button2.Name = "button2";
            button2.Size = new Size(250, 38);
            button2.TabIndex = 6;
            button2.Text = "Виставити оцінку";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(button4);
            groupBox2.Location = new Point(12, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1033, 73);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(559, 30);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 6;
            label3.Text = "Нова оцінка:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 30);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 5;
            label2.Text = "id класу:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(663, 27);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(364, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 30);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 1;
            label1.Text = "id студента:";
            // 
            // button4
            // 
            button4.Location = new Point(865, 26);
            button4.Name = "button4";
            button4.Size = new Size(138, 29);
            button4.TabIndex = 0;
            button4.Text = "Застосувати";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(button5);
            groupBox3.Location = new Point(13, 65);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1032, 73);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(169, 27);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 30);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 1;
            label4.Text = "Введіть id класу:";
            // 
            // button5
            // 
            button5.Location = new Point(864, 26);
            button5.Name = "button5";
            button5.Size = new Size(138, 29);
            button5.TabIndex = 0;
            button5.Text = "Переглянути";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // professor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 543);
            Controls.Add(groupBox3);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Name = "professor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Professor";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Button button4;
        private GroupBox groupBox3;
        private Button button5;
        private TextBox textBox4;
        private Label label4;
    }
}
