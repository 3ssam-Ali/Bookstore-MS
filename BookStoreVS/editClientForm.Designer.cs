
namespace BookStoreVS
{
    partial class editClientForm
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
            this.ClientPhoneText = new System.Windows.Forms.TextBox();
            this.ClientNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ClientIdTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientPhoneText
            // 
            this.ClientPhoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientPhoneText.Location = new System.Drawing.Point(144, 146);
            this.ClientPhoneText.Margin = new System.Windows.Forms.Padding(2);
            this.ClientPhoneText.Name = "ClientPhoneText";
            this.ClientPhoneText.Size = new System.Drawing.Size(126, 23);
            this.ClientPhoneText.TabIndex = 9;
            // 
            // ClientNameTxt
            // 
            this.ClientNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNameTxt.Location = new System.Drawing.Point(144, 109);
            this.ClientNameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ClientNameTxt.Name = "ClientNameTxt";
            this.ClientNameTxt.Size = new System.Drawing.Size(126, 23);
            this.ClientNameTxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "phone number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(90, 188);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientIdTxt
            // 
            this.ClientIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientIdTxt.Location = new System.Drawing.Point(144, 28);
            this.ClientIdTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ClientIdTxt.Name = "ClientIdTxt";
            this.ClientIdTxt.Size = new System.Drawing.Size(126, 23);
            this.ClientIdTxt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Client ID";
            // 
            // checkbtn
            // 
            this.checkbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbtn.Location = new System.Drawing.Point(90, 65);
            this.checkbtn.Margin = new System.Windows.Forms.Padding(2);
            this.checkbtn.Name = "checkbtn";
            this.checkbtn.Size = new System.Drawing.Size(112, 28);
            this.checkbtn.TabIndex = 12;
            this.checkbtn.Text = "Fill Fields";
            this.checkbtn.UseVisualStyleBackColor = true;
            this.checkbtn.Click += new System.EventHandler(this.checkbtn_Click);
            // 
            // editClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 262);
            this.Controls.Add(this.checkbtn);
            this.Controls.Add(this.ClientIdTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClientPhoneText);
            this.Controls.Add(this.ClientNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "editClientForm";
            this.Text = "edit client";
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion

        private System.Windows.Forms.TextBox ClientPhoneText;
        private System.Windows.Forms.TextBox ClientNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ClientIdTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button checkbtn;
    }
}