
namespace BookStoreVS
{
    partial class addClient
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
            this.AddClientButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddClientName = new System.Windows.Forms.TextBox();
            this.AddClientPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddClientButton
            // 
            this.AddClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClientButton.Location = new System.Drawing.Point(108, 111);
            this.AddClientButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(63, 28);
            this.AddClientButton.TabIndex = 0;
            this.AddClientButton.Text = "Add";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone number";
            // 
            // AddClientName
            // 
            this.AddClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClientName.Location = new System.Drawing.Point(132, 24);
            this.AddClientName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddClientName.Name = "AddClientName";
            this.AddClientName.Size = new System.Drawing.Size(126, 23);
            this.AddClientName.TabIndex = 3;
            // 
            // AddClientPhone
            // 
            this.AddClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClientPhone.Location = new System.Drawing.Point(132, 57);
            this.AddClientPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddClientPhone.Name = "AddClientPhone";
            this.AddClientPhone.Size = new System.Drawing.Size(126, 23);
            this.AddClientPhone.TabIndex = 4;
            // 
            // addClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 149);
            this.Controls.Add(this.AddClientPhone);
            this.Controls.Add(this.AddClientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddClientButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "addClient";
            this.Text = "addClient";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BtnClose_Click);


        }

        #endregion

        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddClientName;
        private System.Windows.Forms.TextBox AddClientPhone;
    }
}