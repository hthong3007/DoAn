namespace LTWD
{
    partial class Form7
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
            this.cb_Faculty = new System.Windows.Forms.ComboBox();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Faculty
            // 
            this.cb_Faculty.FormattingEnabled = true;
            this.cb_Faculty.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Kế toán",
            "Cơ khí",
            "Điện",
            "Hóa"});
            this.cb_Faculty.Location = new System.Drawing.Point(243, 65);
            this.cb_Faculty.Name = "cb_Faculty";
            this.cb_Faculty.Size = new System.Drawing.Size(277, 28);
            this.cb_Faculty.TabIndex = 0;
            this.cb_Faculty.SelectedIndexChanged += new System.EventHandler(this.cb_Faculty_SelectedIndexChanged);
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(243, 110);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(277, 182);
            this.tbDisplay.TabIndex = 1;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(364, 299);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 32);
            this.btClear.TabIndex = 2;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(445, 299);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 32);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.cb_Faculty);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Faculty;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btOK;
    }
}