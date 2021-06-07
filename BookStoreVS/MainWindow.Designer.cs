
namespace BookStoreVS
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.opbtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.stockbtn = new System.Windows.Forms.Button();
            this.clientbtn = new System.Windows.Forms.Button();
            this.reportbtn = new System.Windows.Forms.Button();
            this.controlsbtn = new System.Windows.Forms.Button();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.oppanel1 = new BookStoreVS.Oppanel();
            this.stockpanel1 = new BookStoreVS.Stockpanel();
            this.clientspanel1 = new BookStoreVS.Clientspanel();
            this.controlspanel1 = new BookStoreVS.Controlspanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 70);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.BackColor = System.Drawing.Color.Transparent;
            this.usernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.ForeColor = System.Drawing.Color.White;
            this.usernamelabel.Location = new System.Drawing.Point(92, 86);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(102, 25);
            this.usernamelabel.TabIndex = 1;
            this.usernamelabel.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "BookStore Management System";
            // 
            // opbtn
            // 
            this.opbtn.BackColor = System.Drawing.Color.Transparent;
            this.opbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.opbtn.FlatAppearance.BorderSize = 0;
            this.opbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.opbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.opbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.opbtn.ImageKey = "coins.png";
            this.opbtn.ImageList = this.imageList1;
            this.opbtn.Location = new System.Drawing.Point(0, 194);
            this.opbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.opbtn.Name = "opbtn";
            this.opbtn.Size = new System.Drawing.Size(211, 53);
            this.opbtn.TabIndex = 3;
            this.opbtn.Text = "Operations";
            this.opbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.opbtn.UseVisualStyleBackColor = false;
            this.opbtn.Click += new System.EventHandler(this.opbtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "logout.png");
            this.imageList1.Images.SetKeyName(1, "gear-option.png");
            this.imageList1.Images.SetKeyName(2, "business-report.png");
            this.imageList1.Images.SetKeyName(3, "user.png");
            this.imageList1.Images.SetKeyName(4, "coins.png");
            this.imageList1.Images.SetKeyName(5, "packages.png");
            this.imageList1.Images.SetKeyName(6, "power-off.png");
            // 
            // stockbtn
            // 
            this.stockbtn.BackColor = System.Drawing.Color.Transparent;
            this.stockbtn.FlatAppearance.BorderSize = 0;
            this.stockbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.stockbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.stockbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stockbtn.ImageKey = "packages.png";
            this.stockbtn.ImageList = this.imageList1;
            this.stockbtn.Location = new System.Drawing.Point(-7, 273);
            this.stockbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stockbtn.Name = "stockbtn";
            this.stockbtn.Size = new System.Drawing.Size(211, 58);
            this.stockbtn.TabIndex = 4;
            this.stockbtn.Text = "Stock";
            this.stockbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stockbtn.UseVisualStyleBackColor = false;
            this.stockbtn.Click += new System.EventHandler(this.stockbtn_Click);
            // 
            // clientbtn
            // 
            this.clientbtn.BackColor = System.Drawing.Color.Transparent;
            this.clientbtn.FlatAppearance.BorderSize = 0;
            this.clientbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.clientbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.clientbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clientbtn.ImageKey = "user.png";
            this.clientbtn.ImageList = this.imageList1;
            this.clientbtn.Location = new System.Drawing.Point(0, 351);
            this.clientbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientbtn.Name = "clientbtn";
            this.clientbtn.Size = new System.Drawing.Size(211, 58);
            this.clientbtn.TabIndex = 5;
            this.clientbtn.Text = "Clients";
            this.clientbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clientbtn.UseVisualStyleBackColor = false;
            this.clientbtn.Click += new System.EventHandler(this.clientbtn_Click);
            // 
            // reportbtn
            // 
            this.reportbtn.BackColor = System.Drawing.Color.Transparent;
            this.reportbtn.FlatAppearance.BorderSize = 0;
            this.reportbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.reportbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.reportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reportbtn.ImageKey = "business-report.png";
            this.reportbtn.ImageList = this.imageList1;
            this.reportbtn.Location = new System.Drawing.Point(0, 434);
            this.reportbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportbtn.Name = "reportbtn";
            this.reportbtn.Size = new System.Drawing.Size(197, 58);
            this.reportbtn.TabIndex = 6;
            this.reportbtn.Text = "Reports";
            this.reportbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportbtn.UseVisualStyleBackColor = false;
            this.reportbtn.Click += new System.EventHandler(this.reportbtn_Click);
            // 
            // controlsbtn
            // 
            this.controlsbtn.BackColor = System.Drawing.Color.Transparent;
            this.controlsbtn.FlatAppearance.BorderSize = 0;
            this.controlsbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.controlsbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.controlsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.controlsbtn.ImageKey = "gear-option.png";
            this.controlsbtn.ImageList = this.imageList1;
            this.controlsbtn.Location = new System.Drawing.Point(0, 519);
            this.controlsbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlsbtn.Name = "controlsbtn";
            this.controlsbtn.Size = new System.Drawing.Size(197, 58);
            this.controlsbtn.TabIndex = 7;
            this.controlsbtn.Text = "Controls";
            this.controlsbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.controlsbtn.UseVisualStyleBackColor = false;
            this.controlsbtn.Click += new System.EventHandler(this.controlsbtn_Click);
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.BackColor = System.Drawing.Color.Transparent;
            this.Logoutbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logoutbtn.FlatAppearance.BorderSize = 0;
            this.Logoutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Logoutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logoutbtn.ImageKey = "logout.png";
            this.Logoutbtn.ImageList = this.imageList1;
            this.Logoutbtn.Location = new System.Drawing.Point(11, 642);
            this.Logoutbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(156, 46);
            this.Logoutbtn.TabIndex = 8;
            this.Logoutbtn.Text = "Logout";
            this.Logoutbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Logoutbtn.UseVisualStyleBackColor = false;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.exitbtn.FlatAppearance.BorderSize = 0;
            this.exitbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.exitbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitbtn.ImageKey = "power-off.png";
            this.exitbtn.ImageList = this.imageList1;
            this.exitbtn.Location = new System.Drawing.Point(9, 706);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(156, 46);
            this.exitbtn.TabIndex = 9;
            this.exitbtn.Text = "Exit";
            this.exitbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // oppanel1
            // 
            this.oppanel1.BackColor = System.Drawing.Color.Transparent;
            this.oppanel1.Location = new System.Drawing.Point(345, 33);
            this.oppanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oppanel1.Name = "oppanel1";
            this.oppanel1.Size = new System.Drawing.Size(923, 722);
            this.oppanel1.TabIndex = 13;
            // 
            // stockpanel1
            // 
            this.stockpanel1.BackColor = System.Drawing.Color.Transparent;
            this.stockpanel1.Location = new System.Drawing.Point(345, 33);
            this.stockpanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stockpanel1.Name = "stockpanel1";
            this.stockpanel1.Size = new System.Drawing.Size(923, 722);
            this.stockpanel1.TabIndex = 12;
            // 
            // clientspanel1
            // 
            this.clientspanel1.BackColor = System.Drawing.Color.Transparent;
            this.clientspanel1.Location = new System.Drawing.Point(345, 33);
            this.clientspanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientspanel1.Name = "clientspanel1";
            this.clientspanel1.Size = new System.Drawing.Size(923, 722);
            this.clientspanel1.TabIndex = 11;
            // 
            // controlspanel1
            // 
            this.controlspanel1.BackColor = System.Drawing.Color.Transparent;
            this.controlspanel1.Location = new System.Drawing.Point(345, 33);
            this.controlspanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlspanel1.Name = "controlspanel1";
            this.controlspanel1.Size = new System.Drawing.Size(923, 722);
            this.controlspanel1.TabIndex = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.controlsbtn);
            this.Controls.Add(this.reportbtn);
            this.Controls.Add(this.clientbtn);
            this.Controls.Add(this.stockbtn);
            this.Controls.Add(this.opbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.oppanel1);
            this.Controls.Add(this.stockpanel1);
            this.Controls.Add(this.clientspanel1);
            this.Controls.Add(this.controlspanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BtnClose_Click);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button opbtn;
        private System.Windows.Forms.Button stockbtn;
        private System.Windows.Forms.Button clientbtn;
        private System.Windows.Forms.Button reportbtn;
        private System.Windows.Forms.Button controlsbtn;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button exitbtn;
        private Controlspanel controlspanel1;
        private Clientspanel clientspanel1;
        private Stockpanel stockpanel1;
        private Oppanel oppanel1;
    }
}