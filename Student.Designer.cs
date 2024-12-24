namespace Курсова_робота
{
    partial class Student
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            statusTextBox = new TextBox();
            groupBox2 = new GroupBox();
            button4 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1033, 379);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(88, 27);
            button1.Name = "button1";
            button1.Size = new Size(285, 38);
            button1.TabIndex = 1;
            button1.Text = "Переглянути всі оцінки";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(379, 27);
            button2.Name = "button2";
            button2.Size = new Size(285, 38);
            button2.TabIndex = 2;
            button2.Text = "Перевірити стипендію";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(670, 27);
            button3.Name = "button3";
            button3.Size = new Size(285, 38);
            button3.TabIndex = 3;
            button3.Text = "Змінити свої параметри";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(statusTextBox);
            groupBox1.Location = new Point(12, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1033, 75);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(303, 29);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(407, 27);
            statusTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1033, 75);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Visible = false;
            // 
            // button4
            // 
            button4.Location = new Point(849, 28);
            button4.Name = "button4";
            button4.Size = new Size(153, 29);
            button4.TabIndex = 4;
            button4.Text = "Застосувати";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(685, 29);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(103, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(294, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(94, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(422, 32);
            label2.Name = "label2";
            label2.Size = new Size(257, 20);
            label2.TabIndex = 1;
            label2.Text = "Проживання в гуртожитку (0 або 1)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 32);
            label1.Name = "label1";
            label1.Size = new Size(267, 20);
            label1.TabIndex = 0;
            label1.Text = "Участь в громадській роботі (0 або1)";
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 543);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private TextBox statusTextBox;
        private GroupBox groupBox2;
        private Button button4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}