
namespace BookStoreVS
{
    partial class restockForm
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
            this.restockbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bookIdtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.amountNumeric = new System.Windows.Forms.NumericUpDown();
            this.checkbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // restockbtn
            // 
            this.restockbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restockbtn.Location = new System.Drawing.Point(164, 97);
            this.restockbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.restockbtn.Name = "restockbtn";
            this.restockbtn.Size = new System.Drawing.Size(79, 30);
            this.restockbtn.TabIndex = 0;
            this.restockbtn.Text = "Restock";
            this.restockbtn.UseVisualStyleBackColor = true;
            this.restockbtn.Click += new System.EventHandler(this.restockbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Id";
            // 
            // bookIdtxt
            // 
            this.bookIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIdtxt.Location = new System.Drawing.Point(134, 27);
            this.bookIdtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookIdtxt.Name = "bookIdtxt";
            this.bookIdtxt.Size = new System.Drawing.Size(110, 23);
            this.bookIdtxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount to add";
            // 
            // amountNumeric
            // 
            this.amountNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountNumeric.Location = new System.Drawing.Point(134, 57);
            this.amountNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.amountNumeric.Name = "amountNumeric";
            this.amountNumeric.Size = new System.Drawing.Size(110, 23);
            this.amountNumeric.TabIndex = 4;
            // 
            // checkbtn
            // 
            this.checkbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbtn.Location = new System.Drawing.Point(20, 97);
            this.checkbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkbtn.Name = "checkbtn";
            this.checkbtn.Size = new System.Drawing.Size(79, 30);
            this.checkbtn.TabIndex = 5;
            this.checkbtn.Text = "Check";
            this.checkbtn.UseVisualStyleBackColor = true;
            this.checkbtn.Click += new System.EventHandler(this.checkbtn_Click);
            // 
            // restockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 157);
            this.Controls.Add(this.checkbtn);
            this.Controls.Add(this.amountNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookIdtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restockbtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "restockForm";
            this.Text = "Restock";
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button restockbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookIdtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown amountNumeric;
        private System.Windows.Forms.Button checkbtn;
    }
}