namespace lab4 {
    partial class Question {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSupplier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(28, 42);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(130, 22);
            this.textName.TabIndex = 3;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(83, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
           
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Count";
            // 
            // textCount
            // 
            this.textCount.Location = new System.Drawing.Point(164, 42);
            this.textCount.Name = "textCount";
            this.textCount.Size = new System.Drawing.Size(122, 22);
            this.textCount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Supplier";
            // 
            // textSupplier
            // 
            this.textSupplier.Location = new System.Drawing.Point(292, 42);
            this.textSupplier.Name = "textSupplier";
            this.textSupplier.Size = new System.Drawing.Size(158, 22);
            this.textSupplier.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date";
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(456, 42);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(130, 22);
            this.textDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(592, 42);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(129, 22);
            this.textPrice.TabIndex = 11;
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 148);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSupplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCount);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.button1);
            this.Name = "Question";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPrice;
    }
}