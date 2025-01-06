namespace GreenYard_POS.Views.Scenes
{
    partial class Stocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stocks));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddStocks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvStocks = new System.Windows.Forms.DataGridView();
            this.btnDeleteStocks = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(114)))), ((int)(((byte)(118)))));
            this.panel2.Controls.Add(this.btnAddStocks);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgvStocks);
            this.panel2.Controls.Add(this.btnDeleteStocks);
            this.panel2.Location = new System.Drawing.Point(23, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 504);
            this.panel2.TabIndex = 12;
            // 
            // btnAddStocks
            // 
            this.btnAddStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.btnAddStocks.FlatAppearance.BorderSize = 0;
            this.btnAddStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStocks.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(189)))), ((int)(((byte)(186)))));
            this.btnAddStocks.Location = new System.Drawing.Point(20, 447);
            this.btnAddStocks.Name = "btnAddStocks";
            this.btnAddStocks.Size = new System.Drawing.Size(158, 38);
            this.btnAddStocks.TabIndex = 3;
            this.btnAddStocks.Text = "Add Stocks";
            this.btnAddStocks.UseVisualStyleBackColor = false;
            this.btnAddStocks.Click += new System.EventHandler(this.btnAddStocks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search Stocks";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(503, 456);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(146, 29);
            this.txtID.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(154, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(213, 29);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(415, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stocks ID";
            // 
            // dgvStocks
            // 
            this.dgvStocks.AllowUserToAddRows = false;
            this.dgvStocks.AllowUserToDeleteRows = false;
            this.dgvStocks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(114)))), ((int)(((byte)(118)))));
            this.dgvStocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStocks.GridColor = System.Drawing.Color.White;
            this.dgvStocks.Location = new System.Drawing.Point(20, 57);
            this.dgvStocks.Name = "dgvStocks";
            this.dgvStocks.ReadOnly = true;
            this.dgvStocks.RowHeadersVisible = false;
            this.dgvStocks.Size = new System.Drawing.Size(849, 370);
            this.dgvStocks.TabIndex = 0;
            // 
            // btnDeleteStocks
            // 
            this.btnDeleteStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.btnDeleteStocks.FlatAppearance.BorderSize = 0;
            this.btnDeleteStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStocks.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(189)))), ((int)(((byte)(186)))));
            this.btnDeleteStocks.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteStocks.Image")));
            this.btnDeleteStocks.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteStocks.Location = new System.Drawing.Point(655, 450);
            this.btnDeleteStocks.Name = "btnDeleteStocks";
            this.btnDeleteStocks.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnDeleteStocks.Size = new System.Drawing.Size(214, 38);
            this.btnDeleteStocks.TabIndex = 5;
            this.btnDeleteStocks.Text = "Remove Stocks";
            this.btnDeleteStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteStocks.UseVisualStyleBackColor = false;
            this.btnDeleteStocks.Click += new System.EventHandler(this.btnDeleteStocks_Click);
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(937, 557);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stocks";
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.Stocks_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddStocks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvStocks;
        private System.Windows.Forms.Button btnDeleteStocks;
    }
}