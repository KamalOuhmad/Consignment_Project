namespace ConsignmentShopUI
{
    partial class ConsignmentShop
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
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListbox = new System.Windows.Forms.ListBox();
            this.itemListboxLabel = new System.Windows.Forms.Label();
            this.AddtoCart = new System.Windows.Forms.Button();
            this.itemsListboxShoppingLabel = new System.Windows.Forms.Label();
            this.ShoppingCartListBox = new System.Windows.Forms.ListBox();
            this.MakePurchase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VendorListBox = new System.Windows.Forms.ListBox();
            this.VendorListBoxLabel = new System.Windows.Forms.Label();
            this.StoreProfiteLabel = new System.Windows.Forms.Label();
            this.storeProfiteValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(26, 40);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(376, 46);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop";
            // 
            // itemsListbox
            // 
            this.itemsListbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.itemsListbox.FormattingEnabled = true;
            this.itemsListbox.ItemHeight = 25;
            this.itemsListbox.Location = new System.Drawing.Point(34, 141);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(276, 179);
            this.itemsListbox.TabIndex = 1;
            // 
            // itemListboxLabel
            // 
            this.itemListboxLabel.AutoSize = true;
            this.itemListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemListboxLabel.Location = new System.Drawing.Point(29, 98);
            this.itemListboxLabel.Name = "itemListboxLabel";
            this.itemListboxLabel.Size = new System.Drawing.Size(122, 25);
            this.itemListboxLabel.TabIndex = 2;
            this.itemListboxLabel.Text = "Store Items";
            // 
            // AddtoCart
            // 
            this.AddtoCart.Location = new System.Drawing.Point(328, 211);
            this.AddtoCart.Name = "AddtoCart";
            this.AddtoCart.Size = new System.Drawing.Size(156, 30);
            this.AddtoCart.TabIndex = 3;
            this.AddtoCart.Text = "Add To Cart ->";
            this.AddtoCart.UseVisualStyleBackColor = true;
            this.AddtoCart.Click += new System.EventHandler(this.AddtoCart_Click);
            // 
            // itemsListboxShoppingLabel
            // 
            this.itemsListboxShoppingLabel.AutoSize = true;
            this.itemsListboxShoppingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListboxShoppingLabel.Location = new System.Drawing.Point(509, 98);
            this.itemsListboxShoppingLabel.Name = "itemsListboxShoppingLabel";
            this.itemsListboxShoppingLabel.Size = new System.Drawing.Size(151, 25);
            this.itemsListboxShoppingLabel.TabIndex = 5;
            this.itemsListboxShoppingLabel.Text = "Shopping Cart";
            // 
            // ShoppingCartListBox
            // 
            this.ShoppingCartListBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ShoppingCartListBox.FormattingEnabled = true;
            this.ShoppingCartListBox.ItemHeight = 25;
            this.ShoppingCartListBox.Location = new System.Drawing.Point(505, 141);
            this.ShoppingCartListBox.Name = "ShoppingCartListBox";
            this.ShoppingCartListBox.Size = new System.Drawing.Size(280, 179);
            this.ShoppingCartListBox.TabIndex = 4;
            // 
            // MakePurchase
            // 
            this.MakePurchase.Location = new System.Drawing.Point(646, 337);
            this.MakePurchase.Name = "MakePurchase";
            this.MakePurchase.Size = new System.Drawing.Size(139, 31);
            this.MakePurchase.TabIndex = 6;
            this.MakePurchase.Text = "Purchase";
            this.MakePurchase.UseVisualStyleBackColor = true;
            this.MakePurchase.Click += new System.EventHandler(this.MakePurchase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Store Items";
            // 
            // VendorListBox
            // 
            this.VendorListBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.VendorListBox.FormattingEnabled = true;
            this.VendorListBox.ItemHeight = 25;
            this.VendorListBox.Location = new System.Drawing.Point(34, 365);
            this.VendorListBox.Name = "VendorListBox";
            this.VendorListBox.Size = new System.Drawing.Size(276, 179);
            this.VendorListBox.TabIndex = 7;
            // 
            // VendorListBoxLabel
            // 
            this.VendorListBoxLabel.AutoSize = true;
            this.VendorListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorListBoxLabel.Location = new System.Drawing.Point(38, 337);
            this.VendorListBoxLabel.Name = "VendorListBoxLabel";
            this.VendorListBoxLabel.Size = new System.Drawing.Size(93, 25);
            this.VendorListBoxLabel.TabIndex = 8;
            this.VendorListBoxLabel.Text = "Vendors";
            // 
            // StoreProfiteLabel
            // 
            this.StoreProfiteLabel.AutoSize = true;
            this.StoreProfiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreProfiteLabel.Location = new System.Drawing.Point(537, 447);
            this.StoreProfiteLabel.Name = "StoreProfiteLabel";
            this.StoreProfiteLabel.Size = new System.Drawing.Size(120, 25);
            this.StoreProfiteLabel.TabIndex = 9;
            this.StoreProfiteLabel.Text = "Store Profit";
            // 
            // storeProfiteValue
            // 
            this.storeProfiteValue.AutoSize = true;
            this.storeProfiteValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfiteValue.Location = new System.Drawing.Point(680, 447);
            this.storeProfiteValue.Name = "storeProfiteValue";
            this.storeProfiteValue.Size = new System.Drawing.Size(66, 25);
            this.storeProfiteValue.TabIndex = 10;
            this.storeProfiteValue.Text = "$0.00";
            this.storeProfiteValue.Click += new System.EventHandler(this.label2_Click);
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(845, 554);
            this.Controls.Add(this.storeProfiteValue);
            this.Controls.Add(this.StoreProfiteLabel);
            this.Controls.Add(this.VendorListBoxLabel);
            this.Controls.Add(this.VendorListBox);
            this.Controls.Add(this.MakePurchase);
            this.Controls.Add(this.itemsListboxShoppingLabel);
            this.Controls.Add(this.ShoppingCartListBox);
            this.Controls.Add(this.AddtoCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemListboxLabel);
            this.Controls.Add(this.itemsListbox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListbox;
        private System.Windows.Forms.Label itemListboxLabel;
        private System.Windows.Forms.Button AddtoCart;
        private System.Windows.Forms.Label itemsListboxShoppingLabel;
        private System.Windows.Forms.ListBox ShoppingCartListBox;
        private System.Windows.Forms.Button MakePurchase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox VendorListBox;
        private System.Windows.Forms.Label VendorListBoxLabel;
        private System.Windows.Forms.Label StoreProfiteLabel;
        private System.Windows.Forms.Label storeProfiteValue;
    }
}

