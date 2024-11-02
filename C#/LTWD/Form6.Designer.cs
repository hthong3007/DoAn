namespace LTWD
{
    partial class Form6
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
            this.tbKetQua = new System.Windows.Forms.TextBox();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btCham = new System.Windows.Forms.Button();
            this.btEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // tbKetQua
            this.tbKetQua.Location = new System.Drawing.Point(237, 80);
            this.tbKetQua.Multiline = true;
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.Size = new System.Drawing.Size(278, 40);
            this.tbKetQua.TabIndex = 0;

            // bt0
            this.bt0.Location = new System.Drawing.Point(237, 135);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(64, 43);
            this.bt0.TabIndex = 1;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);

            // bt1
            this.bt1.Location = new System.Drawing.Point(309, 135);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(64, 43);
            this.bt1.TabIndex = 2;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;

            // bt2
            this.bt2.Location = new System.Drawing.Point(379, 135);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(64, 42);
            this.bt2.TabIndex = 3;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;

            // bt3
            this.bt3.Location = new System.Drawing.Point(451, 135);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(64, 42);
            this.bt3.TabIndex = 4;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;

            // btMul
            this.btMul.Location = new System.Drawing.Point(237, 184);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(64, 42);
            this.btMul.TabIndex = 5;
            this.btMul.Text = "*";
            this.btMul.UseVisualStyleBackColor = true;

            // btPlus
            this.btPlus.Location = new System.Drawing.Point(309, 184);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(64, 41);
            this.btPlus.TabIndex = 6;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;

            // btCham
            this.btCham.Location = new System.Drawing.Point(380, 184);
            this.btCham.Name = "btCham";
            this.btCham.Size = new System.Drawing.Size(63, 41);
            this.btCham.TabIndex = 7;
            this.btCham.Text = ".";
            this.btCham.UseVisualStyleBackColor = true;

            // btEquals
            this.btEquals.Location = new System.Drawing.Point(451, 184);
            this.btEquals.Name = "btEquals";
            this.btEquals.Size = new System.Drawing.Size(64, 41);
            this.btEquals.TabIndex = 8;
            this.btEquals.Text = "=";
            this.btEquals.UseVisualStyleBackColor = true;

            // Gán sự kiện click cho các nút sau khi khởi tạo
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            this.btMul.Click += new System.EventHandler(this.btMul_Click);
            this.btCham.Click += new System.EventHandler(this.btCham_Click);
            this.btEquals.Click += new System.EventHandler(this.btEquals_Click);

            // Form6
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEquals);
            this.Controls.Add(this.btCham);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.tbKetQua);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion

        private System.Windows.Forms.TextBox tbKetQua;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btMul;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btCham;
        private System.Windows.Forms.Button btEquals;
    }
}