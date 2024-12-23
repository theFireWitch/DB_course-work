namespace Курсова_робота
{
    partial class ERROR
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
            label = new Label();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Gainsboro;
            label.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label.ForeColor = Color.Red;
            label.Location = new Point(30, 67);
            label.Name = "label";
            label.Size = new Size(0, 30);
            label.TabIndex = 0;
            // 
            // ERROR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(370, 186);
            Controls.Add(label);
            Name = "ERROR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ERROR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
    }
}