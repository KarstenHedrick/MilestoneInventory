namespace MilestoneInventory
{
    partial class Search
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
            this.btnHomepage = new System.Windows.Forms.Button();
            this.txtResultsTitle = new System.Windows.Forms.TextBox();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.lblSearchID = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.gvSearchInventory = new System.Windows.Forms.DataGridView();
            this.btnSrchToInv = new System.Windows.Forms.Button();
            this.lblNotFound = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHomepage
            // 
            this.btnHomepage.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnHomepage.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomepage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHomepage.Location = new System.Drawing.Point(51, 52);
            this.btnHomepage.Name = "btnHomepage";
            this.btnHomepage.Size = new System.Drawing.Size(379, 81);
            this.btnHomepage.TabIndex = 3;
            this.btnHomepage.Text = "Karsten\'s Kicks";
            this.btnHomepage.UseVisualStyleBackColor = false;
            // 
            // txtResultsTitle
            // 
            this.txtResultsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultsTitle.Location = new System.Drawing.Point(497, 137);
            this.txtResultsTitle.Multiline = true;
            this.txtResultsTitle.Name = "txtResultsTitle";
            this.txtResultsTitle.Size = new System.Drawing.Size(523, 57);
            this.txtResultsTitle.TabIndex = 6;
            this.txtResultsTitle.Text = "Results";
            this.txtResultsTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchName.Location = new System.Drawing.Point(59, 163);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(86, 31);
            this.lblSearchName.TabIndex = 13;
            this.lblSearchName.Text = "Name";
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(266, 206);
            this.txtSearchID.Multiline = true;
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(164, 42);
            this.txtSearchID.TabIndex = 30;
            // 
            // lblSearchID
            // 
            this.lblSearchID.AutoSize = true;
            this.lblSearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchID.Location = new System.Drawing.Point(260, 158);
            this.lblSearchID.Name = "lblSearchID";
            this.lblSearchID.Size = new System.Drawing.Size(42, 31);
            this.lblSearchID.TabIndex = 29;
            this.lblSearchID.Text = "ID";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(65, 206);
            this.txtSearchName.Multiline = true;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(164, 42);
            this.txtSearchName.TabIndex = 23;
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchItem.Location = new System.Drawing.Point(497, 52);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(215, 57);
            this.btnSearchItem.TabIndex = 35;
            this.btnSearchItem.Text = "Search Item";
            this.btnSearchItem.UseVisualStyleBackColor = false;
            this.btnSearchItem.Click += new System.EventHandler(this.BtnSearchClickEvent);
            // 
            // gvSearchInventory
            // 
            this.gvSearchInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSearchInventory.Location = new System.Drawing.Point(499, 206);
            this.gvSearchInventory.Name = "gvSearchInventory";
            this.gvSearchInventory.RowHeadersWidth = 82;
            this.gvSearchInventory.RowTemplate.Height = 33;
            this.gvSearchInventory.Size = new System.Drawing.Size(521, 276);
            this.gvSearchInventory.TabIndex = 36;
            // 
            // btnSrchToInv
            // 
            this.btnSrchToInv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSrchToInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrchToInv.Location = new System.Drawing.Point(805, 52);
            this.btnSrchToInv.Name = "btnSrchToInv";
            this.btnSrchToInv.Size = new System.Drawing.Size(215, 57);
            this.btnSrchToInv.TabIndex = 37;
            this.btnSrchToInv.Text = "Inventory";
            this.btnSrchToInv.UseVisualStyleBackColor = false;
            this.btnSrchToInv.Click += new System.EventHandler(this.BtnSrchToInvClickEvent);
            // 
            // lblNotFound
            // 
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.ForeColor = System.Drawing.Color.Red;
            this.lblNotFound.Location = new System.Drawing.Point(65, 299);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(164, 25);
            this.lblNotFound.TabIndex = 38;
            this.lblNotFound.Text = "Item Not Found!";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1044, 536);
            this.Controls.Add(this.lblNotFound);
            this.Controls.Add(this.btnSrchToInv);
            this.Controls.Add(this.gvSearchInventory);
            this.Controls.Add(this.btnSearchItem);
            this.Controls.Add(this.txtSearchID);
            this.Controls.Add(this.lblSearchID);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.txtResultsTitle);
            this.Controls.Add(this.btnHomepage);
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHomepage;
        private System.Windows.Forms.TextBox txtResultsTitle;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Label lblSearchID;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearchItem;
        private System.Windows.Forms.DataGridView gvSearchInventory;
        private System.Windows.Forms.Button btnSrchToInv;
        private System.Windows.Forms.Label lblNotFound;
    }
}