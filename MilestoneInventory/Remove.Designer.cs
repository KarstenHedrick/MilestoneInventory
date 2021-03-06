namespace MilestoneInventory
{
    partial class Remove
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
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.txtInvenoryTitle = new System.Windows.Forms.TextBox();
            this.btnHomepage = new System.Windows.Forms.Button();
            this.gvRemoveItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvRemoveItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(792, 64);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(215, 57);
            this.btnRemoveItem.TabIndex = 51;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.BtnRemoveClickEvent);
            // 
            // txtInvenoryTitle
            // 
            this.txtInvenoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvenoryTitle.Location = new System.Drawing.Point(454, 64);
            this.txtInvenoryTitle.Multiline = true;
            this.txtInvenoryTitle.Name = "txtInvenoryTitle";
            this.txtInvenoryTitle.Size = new System.Drawing.Size(302, 57);
            this.txtInvenoryTitle.TabIndex = 38;
            this.txtInvenoryTitle.Text = "Inventory";
            this.txtInvenoryTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnHomepage.Click += new System.EventHandler(this.RmvToHPButtonClickEvent);
            // 
            // gvRemoveItems
            // 
            this.gvRemoveItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRemoveItems.Location = new System.Drawing.Point(38, 162);
            this.gvRemoveItems.Name = "gvRemoveItems";
            this.gvRemoveItems.RowHeadersWidth = 82;
            this.gvRemoveItems.RowTemplate.Height = 33;
            this.gvRemoveItems.Size = new System.Drawing.Size(969, 342);
            this.gvRemoveItems.TabIndex = 52;
            // 
            // Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1044, 536);
            this.Controls.Add(this.gvRemoveItems);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.txtInvenoryTitle);
            this.Controls.Add(this.btnHomepage);
            this.Name = "Remove";
            this.Text = "Remove";
            ((System.ComponentModel.ISupportInitialize)(this.gvRemoveItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.TextBox txtInvenoryTitle;
        private System.Windows.Forms.Button btnHomepage;
        private System.Windows.Forms.DataGridView gvRemoveItems;
    }
}