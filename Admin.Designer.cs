namespace Курсова_робота
{
    partial class Admin
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            button10 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            button9 = new Button();
            button8 = new Button();
            button6 = new Button();
            button5 = new Button();
            button7 = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(281, 28);
            button1.Name = "button1";
            button1.Size = new Size(241, 38);
            button1.TabIndex = 0;
            button1.Text = "Середні оцінки";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(34, 28);
            button2.Name = "button2";
            button2.Size = new Size(241, 38);
            button2.TabIndex = 0;
            button2.Text = "Вивеси всіх студентів";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(528, 28);
            button3.Name = "button3";
            button3.Size = new Size(241, 38);
            button3.TabIndex = 0;
            button3.Text = "Оцінки студентів за групою";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(button4);
            groupBox2.Location = new Point(12, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1033, 77);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = " ";
            groupBox2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 34);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 1;
            label1.Text = "Введіть номер групи\r\n";
            // 
            // button4
            // 
            button4.Location = new Point(861, 29);
            button4.Name = "button4";
            button4.Size = new Size(143, 29);
            button4.TabIndex = 0;
            button4.Text = "Переглянути";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1033, 377);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Location = new Point(12, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1033, 77);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(button9);
            groupBox3.Controls.Add(button8);
            groupBox3.Location = new Point(0, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1033, 74);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Visible = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button10);
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(label2);
            groupBox4.Location = new Point(528, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(505, 77);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            // 
            // button10
            // 
            button10.Location = new Point(320, 31);
            button10.Name = "button10";
            button10.Size = new Size(143, 29);
            button10.TabIndex = 0;
            button10.Text = "Переглянути";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(179, 31);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 34);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 1;
            label2.Text = "Введіть номер групи";
            // 
            // button9
            // 
            button9.Location = new Point(269, 30);
            button9.Name = "button9";
            button9.Size = new Size(241, 29);
            button9.TabIndex = 0;
            button9.Text = "Список на стипендію";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(22, 30);
            button8.Name = "button8";
            button8.Size = new Size(241, 29);
            button8.TabIndex = 0;
            button8.Text = " Список на відрахування";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button6
            // 
            button6.Location = new Point(516, 27);
            button6.Name = "button6";
            button6.Size = new Size(241, 34);
            button6.TabIndex = 0;
            button6.Text = "Для кожного студента";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(269, 27);
            button5.Name = "button5";
            button5.Size = new Size(241, 34);
            button5.TabIndex = 0;
            button5.Text = "В кожній групі";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.Location = new Point(775, 28);
            button7.Name = "button7";
            button7.Size = new Size(241, 38);
            button7.TabIndex = 0;
            button7.Text = "Сформувати звіт";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 544);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button button4;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Button button6;
        private Button button5;
        private Button button7;
        private GroupBox groupBox3;
        private Button button9;
        private Button button8;
        private TextBox textBox2;
        private Label label2;
        private Button button10;
        private GroupBox groupBox4;
    }
}