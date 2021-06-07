
namespace BookStoreVS
{
    partial class Clientspanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClientsGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateJoined = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ClientNametxt = new System.Windows.Forms.TextBox();
            this.EditClientButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsGrid
            // 
            this.ClientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.phone,
            this.dateJoined});
            this.ClientsGrid.Location = new System.Drawing.Point(304, 26);
            this.ClientsGrid.Margin = new System.Windows.Forms.Padding(2);
            this.ClientsGrid.Name = "ClientsGrid";
            this.ClientsGrid.RowHeadersWidth = 51;
            this.ClientsGrid.RowTemplate.Height = 24;
            this.ClientsGrid.Size = new System.Drawing.Size(375, 545);
            this.ClientsGrid.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 112;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 112;
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 111;
            // 
            // dateJoined
            // 
            this.dateJoined.HeaderText = "Date joined";
            this.dateJoined.MinimumWidth = 6;
            this.dateJoined.Name = "dateJoined";
            this.dateJoined.ReadOnly = true;
            this.dateJoined.Width = 112;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(57, 191);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(177, 29);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Visible = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ClientNametxt
            // 
            this.ClientNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNametxt.Location = new System.Drawing.Point(162, 150);
            this.ClientNametxt.Margin = new System.Windows.Forms.Padding(2);
            this.ClientNametxt.Name = "ClientNametxt";
            this.ClientNametxt.Size = new System.Drawing.Size(120, 24);
            this.ClientNametxt.TabIndex = 2;
            this.ClientNametxt.TextChanged += new System.EventHandler(this.ClientNametxt_TextChanged);
            // 
            // EditClientButton
            // 
            this.EditClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditClientButton.Location = new System.Drawing.Point(57, 235);
            this.EditClientButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditClientButton.Name = "EditClientButton";
            this.EditClientButton.Size = new System.Drawing.Size(177, 29);
            this.EditClientButton.TabIndex = 3;
            this.EditClientButton.Text = "Edit client data";
            this.EditClientButton.UseVisualStyleBackColor = true;
            this.EditClientButton.Click += new System.EventHandler(this.EditClientButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search by name";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(57, 268);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(177, 29);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Clientspanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditClientButton);
            this.Controls.Add(this.ClientNametxt);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ClientsGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Clientspanel";
            this.Size = new System.Drawing.Size(692, 587);
            this.Load += new System.EventHandler(this.Clientspanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientsGrid;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox ClientNametxt;
        private System.Windows.Forms.Button EditClientButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateJoined;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RefreshButton;
    }
}
