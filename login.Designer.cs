namespace Курсова_робота
{
    partial class login
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
            login_textbox = new TextBox();
            password_box = new TextBox();
            button_login = new Button();
            login_label = new Label();
            password_label = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // login_textbox
            // 
            login_textbox.Location = new Point(299, 233);
            login_textbox.Name = "login_textbox";
            login_textbox.Size = new Size(377, 27);
            login_textbox.TabIndex = 0;
            // 
            // password_box
            // 
            password_box.Location = new Point(299, 314);
            password_box.Name = "password_box";
            password_box.Size = new Size(377, 27);
            password_box.TabIndex = 1;
            // 
            // button_login
            // 
            button_login.Font = new Font("Segoe UI", 15F);
            button_login.Location = new Point(299, 413);
            button_login.Name = "button_login";
            button_login.Size = new Size(377, 47);
            button_login.TabIndex = 2;
            button_login.Text = "Увійти";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click_3;
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Font = new Font("Segoe UI", 12F);
            login_label.Location = new Point(299, 202);
            login_label.Name = "login_label";
            login_label.Size = new Size(64, 28);
            login_label.TabIndex = 3;
            login_label.Text = "логін:";
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new Font("Segoe UI", 12F);
            password_label.Location = new Point(299, 283);
            password_label.Name = "password_label";
            password_label.Size = new Size(83, 28);
            password_label.TabIndex = 4;
            password_label.Text = "пароль:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(321, 70);
            label1.Name = "label1";
            label1.Size = new Size(324, 57);
            label1.TabIndex = 5;
            label1.Text = "Вхід в систему";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(966, 539);
            Controls.Add(label1);
            Controls.Add(password_label);
            Controls.Add(login_label);
            Controls.Add(button_login);
            Controls.Add(password_box);
            Controls.Add(login_textbox);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox login_textbox;
        private TextBox password_box;
        private Button button_login;
        private Label login_label;
        private Label password_label;
        private Label label1;
    }
}