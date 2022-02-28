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
            this.lstInventorySearch = new System.Windows.Forms.ListBox();
            this.txtResultsTitle = new System.Windows.Forms.TextBox();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.lstSearchWear = new System.Windows.Forms.ListBox();
            this.txtSearchBrand = new System.Windows.Forms.TextBox();
            this.lblSearchBrand = new System.Windows.Forms.Label();
            this.lblSearchWear = new System.Windows.Forms.Label();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.lblSearchID = new System.Windows.Forms.Label();
            this.txtSearchCost = new System.Windows.Forms.TextBox();
            this.lblSearchCost = new System.Windows.Forms.Label();
            this.lblSearchQuantity = new System.Windows.Forms.Label();
            this.txtSearchQuantity = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSearchItem = new System.Windows.Forms.Button();
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
            this.btnHomepage.Click += new System.EventHandler(this.SrchToHPButtonClickEvent);
            // 
            // lstInventorySearch
            // 
            this.lstInventorySearch.FormattingEnabled = true;
            this.lstInventorySearch.ItemHeight = 25;
            this.lstInventorySearch.Location = new System.Drawing.Point(467, 125);
            this.lstInventorySearch.Name = "lstInventorySearch";
            this.lstInventorySearch.Size = new System.Drawing.Size(302, 379);
            this.lstInventorySearch.TabIndex = 4;
            // 
            // txtResultsTitle
            // 
            this.txtResultsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultsTitle.Location = new System.Drawing.Point(467, 52);
            this.txtResultsTitle.Multiline = true;
            this.txtResultsTitle.Name = "txtResultsTitle";
            this.txtResultsTitle.Size = new System.Drawing.Size(302, 57);
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
            // lstSearchWear
            // 
            this.lstSearchWear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSearchWear.FormattingEnabled = true;
            this.lstSearchWear.ItemHeight = 39;
            this.lstSearchWear.Items.AddRange(new object[] {
            "New",
            "Used",
            "Dirty"});
            this.lstSearchWear.Location = new System.Drawing.Point(65, 440);
            this.lstSearchWear.Name = "lstSearchWear";
            this.lstSearchWear.Size = new System.Drawing.Size(164, 43);
            this.lstSearchWear.TabIndex = 34;
            // 
            // txtSearchBrand
            // 
            this.txtSearchBrand.Location = new System.Drawing.Point(280, 440);
            this.txtSearchBrand.Multiline = true;
            this.txtSearchBrand.Name = "txtSearchBrand";
            this.txtSearchBrand.Size = new System.Drawing.Size(164, 42);
            this.txtSearchBrand.TabIndex = 33;
            // 
            // lblSearchBrand
            // 
            this.lblSearchBrand.AutoSize = true;
            this.lblSearchBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBrand.Location = new System.Drawing.Point(274, 396);
            this.lblSearchBrand.Name = "lblSearchBrand";
            this.lblSearchBrand.Size = new System.Drawing.Size(86, 31);
            this.lblSearchBrand.TabIndex = 32;
            this.lblSearchBrand.Text = "Brand";
            // 
            // lblSearchWear
            // 
            this.lblSearchWear.AutoSize = true;
            this.lblSearchWear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchWear.Location = new System.Drawing.Point(60, 396);
            this.lblSearchWear.Name = "lblSearchWear";
            this.lblSearchWear.Size = new System.Drawing.Size(78, 31);
            this.lblSearchWear.TabIndex = 31;
            this.lblSearchWear.Text = "Wear";
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(280, 322);
            this.txtSearchID.Multiline = true;
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(164, 42);
            this.txtSearchID.TabIndex = 30;
            // 
            // lblSearchID
            // 
            this.lblSearchID.AutoSize = true;
            this.lblSearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchID.Location = new System.Drawing.Point(274, 274);
            this.lblSearchID.Name = "lblSearchID";
            this.lblSearchID.Size = new System.Drawing.Size(42, 31);
            this.lblSearchID.TabIndex = 29;
            this.lblSearchID.Text = "ID";
            // 
            // txtSearchCost
            // 
            this.txtSearchCost.Location = new System.Drawing.Point(66, 322);
            this.txtSearchCost.Multiline = true;
            this.txtSearchCost.Name = "txtSearchCost";
            this.txtSearchCost.Size = new System.Drawing.Size(164, 42);
            this.txtSearchCost.TabIndex = 28;
            // 
            // lblSearchCost
            // 
            this.lblSearchCost.AutoSize = true;
            this.lblSearchCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCost.Location = new System.Drawing.Point(60, 274);
            this.lblSearchCost.Name = "lblSearchCost";
            this.lblSearchCost.Size = new System.Drawing.Size(71, 31);
            this.lblSearchCost.TabIndex = 27;
            this.lblSearchCost.Text = "Cost";
            // 
            // lblSearchQuantity
            // 
            this.lblSearchQuantity.AutoSize = true;
            this.lblSearchQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchQuantity.Location = new System.Drawing.Point(274, 161);
            this.lblSearchQuantity.Name = "lblSearchQuantity";
            this.lblSearchQuantity.Size = new System.Drawing.Size(57, 31);
            this.lblSearchQuantity.TabIndex = 26;
            this.lblSearchQuantity.Text = "Qty";
            // 
            // txtSearchQuantity
            // 
            this.txtSearchQuantity.Location = new System.Drawing.Point(280, 206);
            this.txtSearchQuantity.Multiline = true;
            this.txtSearchQuantity.Name = "txtSearchQuantity";
            this.txtSearchQuantity.Size = new System.Drawing.Size(164, 42);
            this.txtSearchQuantity.TabIndex = 24;
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
            this.btnSearchItem.Location = new System.Drawing.Point(805, 52);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(215, 57);
            this.btnSearchItem.TabIndex = 35;
            this.btnSearchItem.Text = "Search Item";
            this.btnSearchItem.UseVisualStyleBackColor = false;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1044, 536);
            this.Controls.Add(this.btnSearchItem);
            this.Controls.Add(this.lstSearchWear);
            this.Controls.Add(this.txtSearchBrand);
            this.Controls.Add(this.lblSearchBrand);
            this.Controls.Add(this.lblSearchWear);
            this.Controls.Add(this.txtSearchID);
            this.Controls.Add(this.lblSearchID);
            this.Controls.Add(this.txtSearchCost);
            this.Controls.Add(this.lblSearchCost);
            this.Controls.Add(this.lblSearchQuantity);
            this.Controls.Add(this.txtSearchQuantity);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.txtResultsTitle);
            this.Controls.Add(this.lstInventorySearch);
            this.Controls.Add(this.btnHomepage);
            this.Name = "Search";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHomepage;
        private System.Windows.Forms.ListBox lstInventorySearch;
        private System.Windows.Forms.TextBox txtResultsTitle;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.ListBox lstSearchWear;
        private System.Windows.Forms.TextBox txtSearchBrand;
        private System.Windows.Forms.Label lblSearchBrand;
        private System.Windows.Forms.Label lblSearchWear;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Label lblSearchID;
        private System.Windows.Forms.TextBox txtSearchCost;
        private System.Windows.Forms.Label lblSearchCost;
        private System.Windows.Forms.Label lblSearchQuantity;
        private System.Windows.Forms.TextBox txtSearchQuantity;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearchItem;
    }
}