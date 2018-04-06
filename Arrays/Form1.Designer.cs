namespace Arrays
{
    partial class Form1
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
            this.btnClear = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSetArraySize = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(40, 86);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 32);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Arrays One";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(191, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 184);
            this.listBox1.TabIndex = 1;
            // 
            // btnSetArraySize
            // 
            this.btnSetArraySize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSetArraySize.Location = new System.Drawing.Point(12, 324);
            this.btnSetArraySize.Name = "btnSetArraySize";
            this.btnSetArraySize.Size = new System.Drawing.Size(281, 37);
            this.btnSetArraySize.TabIndex = 2;
            this.btnSetArraySize.Text = "Set the Array Size at RunTime";
            this.btnSetArraySize.UseVisualStyleBackColor = true;
            this.btnSetArraySize.Click += new System.EventHandler(this.btnSetArraySize_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(332, 324);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 522);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSetArraySize);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnClear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSetArraySize;
        private System.Windows.Forms.TextBox textBox1;
    }
}

