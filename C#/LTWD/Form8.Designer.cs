using System;

namespace LTWD
{
    partial class Form8
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
            this.btLeft = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.btFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLeft
            // 
            this.btLeft.Location = new System.Drawing.Point(191, 342);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(105, 49);
            this.btLeft.TabIndex = 1;
            this.btLeft.Text = "<-";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // btRight
            // 
            this.btRight.Location = new System.Drawing.Point(355, 342);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(104, 49);
            this.btRight.TabIndex = 2;
            this.btRight.Text = "->";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btRight_Click);
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(599, 342);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(140, 49);
            this.btFile.TabIndex = 3;
            this.btFile.Text = "File......";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.btRight);
            this.Controls.Add(this.btLeft);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);

        }

        private void pb1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btFile;
    }
}