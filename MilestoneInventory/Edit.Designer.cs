namespace MilestoneInventory
{
    partial class Edit
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
            this.txtInventoryTitle = new System.Windows.Forms.TextBox();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.txtEditQuantity = new System.Windows.Forms.TextBox();
            this.lblEditName = new System.Windows.Forms.Label();
            this.lblEditQuantity = new System.Windows.Forms.Label();
            this.lblEditCost = new System.Windows.Forms.Label();
            this.txtEditCost = new System.Windows.Forms.TextBox();
            this.lblEditID = new System.Windows.Forms.Label();
            this.txtEditID = new System.Windows.Forms.TextBox();
            this.lblEditWear = new System.Windows.Forms.Label();
            this.lblEditBrand = new System.Windows.Forms.Label();
            this.txtEditBrand = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnApplyChanges = new System.Windows.Forms.Button();
            this.lstCheckInventory = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnHomepage
            // 
            this.btnHomepage.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnHomepage.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomepage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHomepage.Location = new System.Drawing.Point(51, 54);
            this.btnHomepage.Name = "btnHomepage";
            this.btnHomepage.Size = new System.Drawing.Size(379, 81);
            this.btnHomepage.TabIndex = 2;
            this.btnHomepage.Text = "Karsten\'s Kicks";
            this.btnHomepage.UseVisualStyleBackColor = false;
            this.btnHomepage.Click += new System.EventHandler(this.EditToHPButtonClickEvent);
            // 
            // txtInventoryTitle
            // 
            this.txtInventoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventoryTitle.Location = new System.Drawing.Point(485, 54);
            this.txtInventoryTitle.Multiline = true;
            this.txtInventoryTitle.Name = "txtInventoryTitle";
            this.txtInventoryTitle.Size = new System.Drawing.Size(302, 57);
            this.txtInventoryTitle.TabIndex = 6;
            this.txtInventoryTitle.Text = "Inventory";
            this.txtInventoryTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEditItem
            // 
            this.btnEditItem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnEditItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditItem.Location = new System.Drawing.Point(817, 54);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(215, 57);
            this.btnEditItem.TabIndex = 7;
            this.btnEditItem.Text = "Edit Item";
            this.btnEditItem.UseVisualStyleBackColor = false;
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(51, 211);
            this.txtEditName.Multiline = true;
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(164, 42);
            this.txtEditName.TabIndex = 9;
            // 
            // txtEditQuantity
            // 
            this.txtEditQuantity.Location = new System.Drawing.Point(266, 211);
            this.txtEditQuantity.Multiline = true;
            this.txtEditQuantity.Name = "txtEditQuantity";
            this.txtEditQuantity.Size = new System.Drawing.Size(164, 42);
            this.txtEditQuantity.TabIndex = 11;
            // 
            // lblEditName
            // 
            this.lblEditName.AutoSize = true;
            this.lblEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditName.Location = new System.Drawing.Point(46, 166);
            this.lblEditName.Name = "lblEditName";
            this.lblEditName.Size = new System.Drawing.Size(86, 31);
            this.lblEditName.TabIndex = 12;
            this.lblEditName.Text = "Name";
            // 
            // lblEditQuantity
            // 
            this.lblEditQuantity.AutoSize = true;
            this.lblEditQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditQuantity.Location = new System.Drawing.Point(260, 166);
            this.lblEditQuantity.Name = "lblEditQuantity";
            this.lblEditQuantity.Size = new System.Drawing.Size(57, 31);
            this.lblEditQuantity.TabIndex = 13;
            this.lblEditQuantity.Text = "Qty";
            // 
            // lblEditCost
            // 
            this.lblEditCost.AutoSize = true;
            this.lblEditCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCost.Location = new System.Drawing.Point(46, 279);
            this.lblEditCost.Name = "lblEditCost";
            this.lblEditCost.Size = new System.Drawing.Size(71, 31);
            this.lblEditCost.TabIndex = 14;
            this.lblEditCost.Text = "Cost";
            // 
            // txtEditCost
            // 
            this.txtEditCost.Location = new System.Drawing.Point(52, 327);
            this.txtEditCost.Multiline = true;
            this.txtEditCost.Name = "txtEditCost";
            this.txtEditCost.Size = new System.Drawing.Size(164, 42);
            this.txtEditCost.TabIndex = 15;
            // 
            // lblEditID
            // 
            this.lblEditID.AutoSize = true;
            this.lblEditID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditID.Location = new System.Drawing.Point(260, 279);
            this.lblEditID.Name = "lblEditID";
            this.lblEditID.Size = new System.Drawing.Size(42, 31);
            this.lblEditID.TabIndex = 16;
            this.lblEditID.Text = "ID";
            // 
            // txtEditID
            // 
            this.txtEditID.Location = new System.Drawing.Point(266, 327);
            this.txtEditID.Multiline = true;
            this.txtEditID.Name = "txtEditID";
            this.txtEditID.Size = new System.Drawing.Size(164, 42);
            this.txtEditID.TabIndex = 17;
            // 
            // lblEditWear
            // 
            this.lblEditWear.AutoSize = true;
            this.lblEditWear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditWear.Location = new System.Drawing.Point(46, 401);
            this.lblEditWear.Name = "lblEditWear";
            this.lblEditWear.Size = new System.Drawing.Size(78, 31);
            this.lblEditWear.TabIndex = 19;
            this.lblEditWear.Text = "Wear";
            // 
            // lblEditBrand
            // 
            this.lblEditBrand.AutoSize = true;
            this.lblEditBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditBrand.Location = new System.Drawing.Point(260, 401);
            this.lblEditBrand.Name = "lblEditBrand";
            this.lblEditBrand.Size = new System.Drawing.Size(86, 31);
            this.lblEditBrand.TabIndex = 20;
            this.lblEditBrand.Text = "Brand";
            // 
            // txtEditBrand
            // 
            this.txtEditBrand.Location = new System.Drawing.Point(266, 445);
            this.txtEditBrand.Multiline = true;
            this.txtEditBrand.Name = "txtEditBrand";
            this.txtEditBrand.Size = new System.Drawing.Size(164, 42);
            this.txtEditBrand.TabIndex = 21;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 39;
            this.listBox1.Items.AddRange(new object[] {
            "New",
            "Used",
            "Dirty"});
            this.listBox1.Location = new System.Drawing.Point(51, 445);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 43);
            this.listBox1.TabIndex = 22;
            // 
            // btnApplyChanges
            // 
            this.btnApplyChanges.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnApplyChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyChanges.Location = new System.Drawing.Point(817, 131);
            this.btnApplyChanges.Name = "btnApplyChanges";
            this.btnApplyChanges.Size = new System.Drawing.Size(215, 57);
            this.btnApplyChanges.TabIndex = 23;
            this.btnApplyChanges.Text = "Apply Changes";
            this.btnApplyChanges.UseVisualStyleBackColor = false;
            this.btnApplyChanges.Click += new System.EventHandler(this.BtnApplyClickEvent);
            // 
            // lstCheckInventory
            // 
            this.lstCheckInventory.FormattingEnabled = true;
            this.lstCheckInventory.Location = new System.Drawing.Point(485, 131);
            this.lstCheckInventory.Name = "lstCheckInventory";
            this.lstCheckInventory.Size = new System.Drawing.Size(302, 368);
            this.lstCheckInventory.TabIndex = 24;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1044, 536);
            this.Controls.Add(this.lstCheckInventory);
            this.Controls.Add(this.btnApplyChanges);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtEditBrand);
            this.Controls.Add(this.lblEditBrand);
            this.Controls.Add(this.lblEditWear);
            this.Controls.Add(this.txtEditID);
            this.Controls.Add(this.lblEditID);
            this.Controls.Add(this.txtEditCost);
            this.Controls.Add(this.lblEditCost);
            this.Controls.Add(this.lblEditQuantity);
            this.Controls.Add(this.lblEditName);
            this.Controls.Add(this.txtEditQuantity);
            this.Controls.Add(this.txtEditName);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.txtInventoryTitle);
            this.Controls.Add(this.btnHomepage);
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHomepage;
        private System.Windows.Forms.TextBox txtInventoryTitle;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.TextBox txtEditQuantity;
        private System.Windows.Forms.Label lblEditName;
        private System.Windows.Forms.Label lblEditQuantity;
        private System.Windows.Forms.Label lblEditCost;
        private System.Windows.Forms.TextBox txtEditCost;
        private System.Windows.Forms.Label lblEditID;
        private System.Windows.Forms.TextBox txtEditID;
        private System.Windows.Forms.Label lblEditWear;
        private System.Windows.Forms.Label lblEditBrand;
        private System.Windows.Forms.TextBox txtEditBrand;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnApplyChanges;
        private System.Windows.Forms.CheckedListBox lstCheckInventory;
    }
}