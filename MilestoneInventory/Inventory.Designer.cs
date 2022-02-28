namespace MilestoneInventory
{
    partial class Inventory
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
            this.btnEditItems = new System.Windows.Forms.Button();
            this.txtInventoryTitle = new System.Windows.Forms.TextBox();
            this.btnSearchItems = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnRemoveItems = new System.Windows.Forms.Button();
            this.btnReorderItems = new System.Windows.Forms.Button();
            this.btnItemDetails = new System.Windows.Forms.Button();
            this.lstInventory = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnHomepage
            // 
            this.btnHomepage.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnHomepage.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomepage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHomepage.Location = new System.Drawing.Point(39, 54);
            this.btnHomepage.Name = "btnHomepage";
            this.btnHomepage.Size = new System.Drawing.Size(379, 81);
            this.btnHomepage.TabIndex = 2;
            this.btnHomepage.Text = "Karsten\'s Kicks";
            this.btnHomepage.UseVisualStyleBackColor = false;
            this.btnHomepage.Click += new System.EventHandler(this.InvToHPButtonClickEvent);
            // 
            // btnEditItems
            // 
            this.btnEditItems.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnEditItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditItems.Location = new System.Drawing.Point(797, 54);
            this.btnEditItems.Name = "btnEditItems";
            this.btnEditItems.Size = new System.Drawing.Size(215, 57);
            this.btnEditItems.TabIndex = 4;
            this.btnEditItems.Text = "Edit Items";
            this.btnEditItems.UseVisualStyleBackColor = false;
            this.btnEditItems.Click += new System.EventHandler(this.InvToEditButtonClickEvent);
            // 
            // txtInventoryTitle
            // 
            this.txtInventoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventoryTitle.Location = new System.Drawing.Point(469, 54);
            this.txtInventoryTitle.Multiline = true;
            this.txtInventoryTitle.Name = "txtInventoryTitle";
            this.txtInventoryTitle.Size = new System.Drawing.Size(302, 57);
            this.txtInventoryTitle.TabIndex = 5;
            this.txtInventoryTitle.Text = "Inventory";
            this.txtInventoryTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearchItems
            // 
            this.btnSearchItems.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearchItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchItems.Location = new System.Drawing.Point(797, 129);
            this.btnSearchItems.Name = "btnSearchItems";
            this.btnSearchItems.Size = new System.Drawing.Size(215, 57);
            this.btnSearchItems.TabIndex = 6;
            this.btnSearchItems.Text = "Search Items";
            this.btnSearchItems.UseVisualStyleBackColor = false;
            this.btnSearchItems.Click += new System.EventHandler(this.InvToSrchButtonClickEvent);
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.Location = new System.Drawing.Point(797, 204);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(215, 57);
            this.btnAddItems.TabIndex = 7;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.UseVisualStyleBackColor = false;
            this.btnAddItems.Click += new System.EventHandler(this.InvToAddButtonClickEvent);
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnRemoveItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItems.Location = new System.Drawing.Point(797, 278);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.Size = new System.Drawing.Size(215, 57);
            this.btnRemoveItems.TabIndex = 8;
            this.btnRemoveItems.Text = "Remove Items";
            this.btnRemoveItems.UseVisualStyleBackColor = false;
            this.btnRemoveItems.Click += new System.EventHandler(this.InvToRmvButtonClickEvent);
            // 
            // btnReorderItems
            // 
            this.btnReorderItems.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnReorderItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReorderItems.Location = new System.Drawing.Point(797, 353);
            this.btnReorderItems.Name = "btnReorderItems";
            this.btnReorderItems.Size = new System.Drawing.Size(215, 57);
            this.btnReorderItems.TabIndex = 9;
            this.btnReorderItems.Text = "Reorder Items";
            this.btnReorderItems.UseVisualStyleBackColor = false;
            // 
            // btnItemDetails
            // 
            this.btnItemDetails.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnItemDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemDetails.Location = new System.Drawing.Point(797, 430);
            this.btnItemDetails.Name = "btnItemDetails";
            this.btnItemDetails.Size = new System.Drawing.Size(215, 57);
            this.btnItemDetails.TabIndex = 10;
            this.btnItemDetails.Text = "Item Details";
            this.btnItemDetails.UseVisualStyleBackColor = false;
            this.btnItemDetails.Click += new System.EventHandler(this.InvToDetailsButtonClickEvent);
            // 
            // lstInventory
            // 
            this.lstInventory.FormattingEnabled = true;
            this.lstInventory.Location = new System.Drawing.Point(469, 129);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(302, 368);
            this.lstInventory.TabIndex = 11;
            this.lstInventory.SelectedIndexChanged += new System.EventHandler(this.ItemSelectCheckedEvent);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1044, 536);
            this.Controls.Add(this.lstInventory);
            this.Controls.Add(this.btnItemDetails);
            this.Controls.Add(this.btnReorderItems);
            this.Controls.Add(this.btnRemoveItems);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.btnSearchItems);
            this.Controls.Add(this.txtInventoryTitle);
            this.Controls.Add(this.btnEditItems);
            this.Controls.Add(this.btnHomepage);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHomepage;
        private System.Windows.Forms.Button btnEditItems;
        private System.Windows.Forms.TextBox txtInventoryTitle;
        private System.Windows.Forms.Button btnSearchItems;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnRemoveItems;
        private System.Windows.Forms.Button btnReorderItems;
        private System.Windows.Forms.Button btnItemDetails;
        private System.Windows.Forms.CheckedListBox lstInventory;
    }
}