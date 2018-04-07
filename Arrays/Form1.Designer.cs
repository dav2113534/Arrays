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
            this.btnTimesTables = new System.Windows.Forms.Button();
            this.btn2DimensionalArray = new System.Windows.Forms.Button();
            this.btnStringArrays = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(26, 44);
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
            this.listBox1.Location = new System.Drawing.Point(175, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(285, 184);
            this.listBox1.TabIndex = 1;
            // 
            // btnSetArraySize
            // 
            this.btnSetArraySize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSetArraySize.Location = new System.Drawing.Point(12, 264);
            this.btnSetArraySize.Name = "btnSetArraySize";
            this.btnSetArraySize.Size = new System.Drawing.Size(281, 37);
            this.btnSetArraySize.TabIndex = 2;
            this.btnSetArraySize.Text = "Set the Array Size at RunTime";
            this.btnSetArraySize.UseVisualStyleBackColor = true;
            this.btnSetArraySize.Click += new System.EventHandler(this.btnSetArraySize_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(329, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 3;
            // 
            // btnTimesTables
            // 
            this.btnTimesTables.Location = new System.Drawing.Point(12, 307);
            this.btnTimesTables.Name = "btnTimesTables";
            this.btnTimesTables.Size = new System.Drawing.Size(281, 38);
            this.btnTimesTables.TabIndex = 4;
            this.btnTimesTables.Text = "Exercise: Times Table";
            this.btnTimesTables.UseVisualStyleBackColor = true;
            this.btnTimesTables.Click += new System.EventHandler(this.btnTimesTables_Click);
            // 
            // btn2DimensionalArray
            // 
            this.btn2DimensionalArray.Location = new System.Drawing.Point(12, 351);
            this.btn2DimensionalArray.Name = "btn2DimensionalArray";
            this.btn2DimensionalArray.Size = new System.Drawing.Size(281, 36);
            this.btn2DimensionalArray.TabIndex = 5;
            this.btn2DimensionalArray.Text = "2-Dimensional Array";
            this.btn2DimensionalArray.UseVisualStyleBackColor = true;
            this.btn2DimensionalArray.Click += new System.EventHandler(this.btn2DimensionalArray_Click);
            // 
            // btnStringArrays
            // 
            this.btnStringArrays.Location = new System.Drawing.Point(12, 393);
            this.btnStringArrays.Name = "btnStringArrays";
            this.btnStringArrays.Size = new System.Drawing.Size(281, 37);
            this.btnStringArrays.TabIndex = 6;
            this.btnStringArrays.Text = "String Arrays";
            this.btnStringArrays.UseVisualStyleBackColor = true;
            this.btnStringArrays.Click += new System.EventHandler(this.btnStringArrays_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 605);
            this.Controls.Add(this.btnStringArrays);
            this.Controls.Add(this.btn2DimensionalArray);
            this.Controls.Add(this.btnTimesTables);
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
        private System.Windows.Forms.Button btnTimesTables;
        private System.Windows.Forms.Button btn2DimensionalArray;
        private System.Windows.Forms.Button btnStringArrays;
    }
}

