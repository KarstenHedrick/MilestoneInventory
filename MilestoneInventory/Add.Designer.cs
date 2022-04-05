namespace MilestoneInventory
{
    partial class Add
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
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lstAddWear = new System.Windows.Forms.ListBox();
            this.txtAddBrand = new System.Windows.Forms.TextBox();
            this.lblAddBrand = new System.Windows.Forms.Label();
            this.lblAddWear = new System.Windows.Forms.Label();
            this.txtAddID = new System.Windows.Forms.TextBox();
            this.lblAddID = new System.Windows.Forms.Label();
            this.txtAddCost = new System.Windows.Forms.TextBox();
            this.lblAddCost = new System.Windows.Forms.Label();
            this.lblAddQuantity = new System.Windows.Forms.Label();
            this.txtAddQuantity = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.lblAddName = new System.Windows.Forms.Label();
            this.txtInventoryTitle = new System.Windows.Forms.TextBox();
            this.btnHomepage = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.txtField2 = new System.Windows.Forms.TextBox();
            this.lblField2 = new System.Windows.Forms.Label();
            this.txtField1 = new System.Windows.Forms.TextBox();
            this.lblField1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(792, 42);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(215, 57);
            this.btnAddItem.TabIndex = 51;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItemClickEvent);
            // 
            // lstAddWear
            // 
            this.lstAddWear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAddWear.FormattingEnabled = true;
            this.lstAddWear.ItemHeight = 39;
            this.lstAddWear.Items.AddRange(new object[] {
            "New",
            "Used",
            "Dirty"});
            this.lstAddWear.Location = new System.Drawing.Point(52, 430);
            this.lstAddWear.Name = "lstAddWear";
            this.lstAddWear.Size = new System.Drawing.Size(164, 43);
            this.lstAddWear.TabIndex = 50;
            // 
            // txtAddBrand
            // 
            this.txtAddBrand.Location = new System.Drawing.Point(454, 430);
            this.txtAddBrand.Multiline = true;
            this.txtAddBrand.Name = "txtAddBrand";
            this.txtAddBrand.Size = new System.Drawing.Size(164, 42);
            this.txtAddBrand.TabIndex = 49;
            // 
            // lblAddBrand
            // 
            this.lblAddBrand.AutoSize = true;
            this.lblAddBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBrand.Location = new System.Drawing.Point(448, 386);
            this.lblAddBrand.Name = "lblAddBrand";
            this.lblAddBrand.Size = new System.Drawing.Size(86, 31);
            this.lblAddBrand.TabIndex = 48;
            this.lblAddBrand.Text = "Brand";
            // 
            // lblAddWear
            // 
            this.lblAddWear.AutoSize = true;
            this.lblAddWear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddWear.Location = new System.Drawing.Point(47, 386);
            this.lblAddWear.Name = "lblAddWear";
            this.lblAddWear.Size = new System.Drawing.Size(78, 31);
            this.lblAddWear.TabIndex = 47;
            this.lblAddWear.Text = "Wear";
            // 
            // txtAddID
            // 
            this.txtAddID.Location = new System.Drawing.Point(454, 312);
            this.txtAddID.Multiline = true;
            this.txtAddID.Name = "txtAddID";
            this.txtAddID.Size = new System.Drawing.Size(164, 42);
            this.txtAddID.TabIndex = 46;
            // 
            // lblAddID
            // 
            this.lblAddID.AutoSize = true;
            this.lblAddID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddID.Location = new System.Drawing.Point(448, 264);
            this.lblAddID.Name = "lblAddID";
            this.lblAddID.Size = new System.Drawing.Size(42, 31);
            this.lblAddID.TabIndex = 45;
            this.lblAddID.Text = "ID";
            // 
            // txtAddCost
            // 
            this.txtAddCost.Location = new System.Drawing.Point(53, 312);
            this.txtAddCost.Multiline = true;
            this.txtAddCost.Name = "txtAddCost";
            this.txtAddCost.Size = new System.Drawing.Size(164, 42);
            this.txtAddCost.TabIndex = 44;
            // 
            // lblAddCost
            // 
            this.lblAddCost.AutoSize = true;
            this.lblAddCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCost.Location = new System.Drawing.Point(47, 264);
            this.lblAddCost.Name = "lblAddCost";
            this.lblAddCost.Size = new System.Drawing.Size(71, 31);
            this.lblAddCost.TabIndex = 43;
            this.lblAddCost.Text = "Cost";
            // 
            // lblAddQuantity
            // 
            this.lblAddQuantity.AutoSize = true;
            this.lblAddQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddQuantity.Location = new System.Drawing.Point(448, 151);
            this.lblAddQuantity.Name = "lblAddQuantity";
            this.lblAddQuantity.Size = new System.Drawing.Size(57, 31);
            this.lblAddQuantity.TabIndex = 42;
            this.lblAddQuantity.Text = "Qty";
            // 
            // txtAddQuantity
            // 
            this.txtAddQuantity.Location = new System.Drawing.Point(454, 196);
            this.txtAddQuantity.Multiline = true;
            this.txtAddQuantity.Name = "txtAddQuantity";
            this.txtAddQuantity.Size = new System.Drawing.Size(164, 42);
            this.txtAddQuantity.TabIndex = 41;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(52, 196);
            this.txtAddName.Multiline = true;
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(164, 42);
            this.txtAddName.TabIndex = 40;
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddName.Location = new System.Drawing.Point(46, 153);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(86, 31);
            this.lblAddName.TabIndex = 39;
            this.lblAddName.Text = "Name";
            // 
            // txtInventoryTitle
            // 
            this.txtInventoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventoryTitle.Location = new System.Drawing.Point(454, 42);
            this.txtInventoryTitle.Multiline = true;
            this.txtInventoryTitle.Name = "txtInventoryTitle";
            this.txtInventoryTitle.Size = new System.Drawing.Size(302, 57);
            this.txtInventoryTitle.TabIndex = 38;
            this.txtInventoryTitle.Text = "Inventory";
            this.txtInventoryTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnHomepage
            // 
            this.btnHomepage.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnHomepage.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomepage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHomepage.Location = new System.Drawing.Point(38, 42);
            this.btnHomepage.Name = "btnHomepage";
            this.btnHomepage.Size = new System.Drawing.Size(379, 81);
            this.btnHomepage.TabIndex = 36;
            this.btnHomepage.Text = "Karsten\'s Kicks";
            this.btnHomepage.UseVisualStyleBackColor = false;
            this.btnHomepage.Click += new System.EventHandler(this.AddToHPButtonClickEvent);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(787, 196);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(243, 25);
            this.lblError.TabIndex = 52;
            this.lblError.Text = "Error: Enter valid inputs.";
            // 
            // txtField2
            // 
            this.txtField2.Location = new System.Drawing.Point(792, 430);
            this.txtField2.Multiline = true;
            this.txtField2.Name = "txtField2";
            this.txtField2.Size = new System.Drawing.Size(164, 42);
            this.txtField2.TabIndex = 58;
            // 
            // lblField2
            // 
            this.lblField2.AutoSize = true;
            this.lblField2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField2.Location = new System.Drawing.Point(786, 264);
            this.lblField2.Name = "lblField2";
            this.lblField2.Size = new System.Drawing.Size(277, 31);
            this.lblField2.TabIndex = 57;
            this.lblField2.Text = "Is Available (Boolean)";
            // 
            // txtField1
            // 
            this.txtField1.Location = new System.Drawing.Point(792, 312);
            this.txtField1.Multiline = true;
            this.txtField1.Name = "txtField1";
            this.txtField1.Size = new System.Drawing.Size(164, 42);
            this.txtField1.TabIndex = 56;
            // 
            // lblField1
            // 
            this.lblField1.AutoSize = true;
            this.lblField1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField1.Location = new System.Drawing.Point(800, 386);
            this.lblField1.Name = "lblField1";
            this.lblField1.Size = new System.Drawing.Size(45, 31);
            this.lblField1.TabIndex = 55;
            this.lblField1.Text = "Fit";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1074, 536);
            this.Controls.Add(this.txtField2);
            this.Controls.Add(this.lblField2);
            this.Controls.Add(this.txtField1);
            this.Controls.Add(this.lblField1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lstAddWear);
            this.Controls.Add(this.txtAddBrand);
            this.Controls.Add(this.lblAddBrand);
            this.Controls.Add(this.lblAddWear);
            this.Controls.Add(this.txtAddID);
            this.Controls.Add(this.lblAddID);
            this.Controls.Add(this.txtAddCost);
            this.Controls.Add(this.lblAddCost);
            this.Controls.Add(this.lblAddQuantity);
            this.Controls.Add(this.txtAddQuantity);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.lblAddName);
            this.Controls.Add(this.txtInventoryTitle);
            this.Controls.Add(this.btnHomepage);
            this.Name = "Add";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ListBox lstAddWear;
        private System.Windows.Forms.TextBox txtAddBrand;
        private System.Windows.Forms.Label lblAddBrand;
        private System.Windows.Forms.Label lblAddWear;
        private System.Windows.Forms.TextBox txtAddID;
        private System.Windows.Forms.Label lblAddID;
        private System.Windows.Forms.TextBox txtAddCost;
        private System.Windows.Forms.Label lblAddCost;
        private System.Windows.Forms.Label lblAddQuantity;
        private System.Windows.Forms.TextBox txtAddQuantity;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.TextBox txtInventoryTitle;
        private System.Windows.Forms.Button btnHomepage;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtField2;
        private System.Windows.Forms.Label lblField2;
        private System.Windows.Forms.TextBox txtField1;
        private System.Windows.Forms.Label lblField1;
    }
}