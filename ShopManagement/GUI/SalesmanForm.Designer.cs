namespace ShopManagement.GUI
{
    partial class SalesmanForm
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
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.cartMetroListView = new MetroFramework.Controls.MetroListView();
            this.slNoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitPriceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.netPriceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productSellPanel = new System.Windows.Forms.Panel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.searchMetroButton = new MetroFramework.Controls.MetroButton();
            this.addMetroButton = new MetroFramework.Controls.MetroButton();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.printMetroButton = new MetroFramework.Controls.MetroButton();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.showAllMetroButton = new MetroFramework.Controls.MetroButton();
            this.removeMetroButton = new MetroFramework.Controls.MetroButton();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.logoutMetroButton = new MetroFramework.Controls.MetroButton();
            this.editInfoMetroButton = new MetroFramework.Controls.MetroButton();
            this.salesmanLabel = new System.Windows.Forms.Label();
            this.backgroundPanel.SuspendLayout();
            this.productSellPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackgroundImage = global::ShopManagement.Properties.Resources.Background;
            this.backgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPanel.Controls.Add(this.cartMetroListView);
            this.backgroundPanel.Controls.Add(this.productSellPanel);
            this.backgroundPanel.Controls.Add(this.rightPanel);
            this.backgroundPanel.Controls.Add(this.bottomPanel);
            this.backgroundPanel.Controls.Add(this.leftPanel);
            this.backgroundPanel.Controls.Add(this.topPanel);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(20, 60);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(1284, 576);
            this.backgroundPanel.TabIndex = 0;
            // 
            // cartMetroListView
            // 
            this.cartMetroListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.slNoColumnHeader,
            this.idColumnHeader,
            this.nameColumnHeader,
            this.quantityColumnHeader,
            this.unitPriceColumnHeader,
            this.netPriceColumnHeader});
            this.cartMetroListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartMetroListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cartMetroListView.FullRowSelect = true;
            this.cartMetroListView.GridLines = true;
            this.cartMetroListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.cartMetroListView.Location = new System.Drawing.Point(28, 153);
            this.cartMetroListView.Name = "cartMetroListView";
            this.cartMetroListView.OwnerDraw = true;
            this.cartMetroListView.Size = new System.Drawing.Size(1236, 311);
            this.cartMetroListView.TabIndex = 9;
            this.cartMetroListView.UseCompatibleStateImageBehavior = false;
            this.cartMetroListView.UseSelectable = true;
            this.cartMetroListView.View = System.Windows.Forms.View.Details;
            this.cartMetroListView.Click += new System.EventHandler(this.cartMetroListView_SelectedIndexChanged);
            // 
            // slNoColumnHeader
            // 
            this.slNoColumnHeader.Text = "Sl no";
            // 
            // idColumnHeader
            // 
            this.idColumnHeader.Text = "Id";
            this.idColumnHeader.Width = 98;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameColumnHeader.Width = 208;
            // 
            // quantityColumnHeader
            // 
            this.quantityColumnHeader.Text = "Quantity";
            this.quantityColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityColumnHeader.Width = 123;
            // 
            // unitPriceColumnHeader
            // 
            this.unitPriceColumnHeader.Text = "Unit price";
            this.unitPriceColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unitPriceColumnHeader.Width = 120;
            // 
            // netPriceColumnHeader
            // 
            this.netPriceColumnHeader.Text = "Net price";
            this.netPriceColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.netPriceColumnHeader.Width = 113;
            // 
            // productSellPanel
            // 
            this.productSellPanel.BackColor = System.Drawing.Color.Transparent;
            this.productSellPanel.Controls.Add(this.idTextBox);
            this.productSellPanel.Controls.Add(this.idLabel);
            this.productSellPanel.Controls.Add(this.quantityNumericUpDown);
            this.productSellPanel.Controls.Add(this.searchMetroButton);
            this.productSellPanel.Controls.Add(this.addMetroButton);
            this.productSellPanel.Controls.Add(this.priceTextBox);
            this.productSellPanel.Controls.Add(this.nameTextBox);
            this.productSellPanel.Controls.Add(this.priceLabel);
            this.productSellPanel.Controls.Add(this.quantityLabel);
            this.productSellPanel.Controls.Add(this.nameLabel);
            this.productSellPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.productSellPanel.Location = new System.Drawing.Point(28, 72);
            this.productSellPanel.Name = "productSellPanel";
            this.productSellPanel.Size = new System.Drawing.Size(1236, 81);
            this.productSellPanel.TabIndex = 8;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.idTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.idTextBox.Location = new System.Drawing.Point(796, 23);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(146, 20);
            this.idTextBox.TabIndex = 52;
            // 
            // idLabel
            // 
            this.idLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.idLabel.Location = new System.Drawing.Point(747, 24);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 16);
            this.idLabel.TabIndex = 51;
            this.idLabel.Text = "Id: ";
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(117, 46);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.quantityNumericUpDown.TabIndex = 2;
            // 
            // searchMetroButton
            // 
            this.searchMetroButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.searchMetroButton.Location = new System.Drawing.Point(564, 22);
            this.searchMetroButton.Name = "searchMetroButton";
            this.searchMetroButton.Size = new System.Drawing.Size(102, 44);
            this.searchMetroButton.TabIndex = 4;
            this.searchMetroButton.Text = "Search";
            this.searchMetroButton.UseSelectable = true;
            this.searchMetroButton.Click += new System.EventHandler(this.searchMetroButton_Click);
            // 
            // addMetroButton
            // 
            this.addMetroButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.addMetroButton.Location = new System.Drawing.Point(438, 22);
            this.addMetroButton.Name = "addMetroButton";
            this.addMetroButton.Size = new System.Drawing.Size(102, 44);
            this.addMetroButton.TabIndex = 3;
            this.addMetroButton.Text = "Add to cart";
            this.addMetroButton.UseSelectable = true;
            this.addMetroButton.Click += new System.EventHandler(this.addMetroButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.priceTextBox.Location = new System.Drawing.Point(1097, 22);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 50;
            // 
            // nameTextBox
            // 
            this.nameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.nameTextBox.Location = new System.Drawing.Point(117, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(254, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.priceLabel.Location = new System.Drawing.Point(1009, 23);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(42, 16);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Price:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quantityLabel.Location = new System.Drawing.Point(29, 46);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(59, 16);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Quantity:";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameLabel.Location = new System.Drawing.Point(29, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.Transparent;
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1264, 72);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(20, 392);
            this.rightPanel.TabIndex = 7;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.bottomPanel.Controls.Add(this.totalPriceTextBox);
            this.bottomPanel.Controls.Add(this.printMetroButton);
            this.bottomPanel.Controls.Add(this.totalPriceLabel);
            this.bottomPanel.Controls.Add(this.showAllMetroButton);
            this.bottomPanel.Controls.Add(this.removeMetroButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(28, 464);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1256, 112);
            this.bottomPanel.TabIndex = 6;
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceTextBox.Location = new System.Drawing.Point(1090, 19);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.ReadOnly = true;
            this.totalPriceTextBox.Size = new System.Drawing.Size(135, 22);
            this.totalPriceTextBox.TabIndex = 55;
            // 
            // printMetroButton
            // 
            this.printMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.printMetroButton.Location = new System.Drawing.Point(1150, 55);
            this.printMetroButton.Name = "printMetroButton";
            this.printMetroButton.Size = new System.Drawing.Size(75, 44);
            this.printMetroButton.TabIndex = 5;
            this.printMetroButton.Text = "Print";
            this.printMetroButton.UseSelectable = true;
            this.printMetroButton.Click += new System.EventHandler(this.printMetroButton_Click);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(979, 21);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(90, 20);
            this.totalPriceLabel.TabIndex = 2;
            this.totalPriceLabel.Text = "Total price: ";
            // 
            // showAllMetroButton
            // 
            this.showAllMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showAllMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.showAllMetroButton.Location = new System.Drawing.Point(937, 55);
            this.showAllMetroButton.Name = "showAllMetroButton";
            this.showAllMetroButton.Size = new System.Drawing.Size(75, 44);
            this.showAllMetroButton.TabIndex = 7;
            this.showAllMetroButton.Text = "Show all";
            this.showAllMetroButton.UseSelectable = true;
            this.showAllMetroButton.Click += new System.EventHandler(this.showAllMetroButton_Click);
            // 
            // removeMetroButton
            // 
            this.removeMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.removeMetroButton.Location = new System.Drawing.Point(1048, 55);
            this.removeMetroButton.Name = "removeMetroButton";
            this.removeMetroButton.Size = new System.Drawing.Size(75, 44);
            this.removeMetroButton.TabIndex = 6;
            this.removeMetroButton.Text = "Remove";
            this.removeMetroButton.UseSelectable = true;
            this.removeMetroButton.Click += new System.EventHandler(this.removeMetroButton_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.Transparent;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 72);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(28, 504);
            this.leftPanel.TabIndex = 5;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.Controls.Add(this.logoutMetroButton);
            this.topPanel.Controls.Add(this.editInfoMetroButton);
            this.topPanel.Controls.Add(this.salesmanLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1284, 72);
            this.topPanel.TabIndex = 4;
            // 
            // logoutMetroButton
            // 
            this.logoutMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.logoutMetroButton.Location = new System.Drawing.Point(1189, 15);
            this.logoutMetroButton.Name = "logoutMetroButton";
            this.logoutMetroButton.Size = new System.Drawing.Size(75, 44);
            this.logoutMetroButton.TabIndex = 8;
            this.logoutMetroButton.Text = "Logout";
            this.logoutMetroButton.UseSelectable = true;
            this.logoutMetroButton.Click += new System.EventHandler(this.logoutMetroButton_Click);
            // 
            // editInfoMetroButton
            // 
            this.editInfoMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editInfoMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.editInfoMetroButton.Location = new System.Drawing.Point(1076, 15);
            this.editInfoMetroButton.Name = "editInfoMetroButton";
            this.editInfoMetroButton.Size = new System.Drawing.Size(75, 44);
            this.editInfoMetroButton.TabIndex = 9;
            this.editInfoMetroButton.Text = "Edit info";
            this.editInfoMetroButton.UseSelectable = true;
            this.editInfoMetroButton.Click += new System.EventHandler(this.editInfoMetroButton_Click);
            // 
            // salesmanLabel
            // 
            this.salesmanLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.salesmanLabel.AutoSize = true;
            this.salesmanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesmanLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.salesmanLabel.Location = new System.Drawing.Point(563, 15);
            this.salesmanLabel.Name = "salesmanLabel";
            this.salesmanLabel.Size = new System.Drawing.Size(134, 31);
            this.salesmanLabel.TabIndex = 27;
            this.salesmanLabel.Text = "Salesman";
            // 
            // SalesmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 656);
            this.Controls.Add(this.backgroundPanel);
            this.MinimumSize = new System.Drawing.Size(1324, 656);
            this.Name = "SalesmanForm";
            this.Text = "Super shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SalesmanForm_Load);
            this.backgroundPanel.ResumeLayout(false);
            this.productSellPanel.ResumeLayout(false);
            this.productSellPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.Panel topPanel;
        private MetroFramework.Controls.MetroButton logoutMetroButton;
        private MetroFramework.Controls.MetroButton editInfoMetroButton;
        private System.Windows.Forms.Label salesmanLabel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private MetroFramework.Controls.MetroButton printMetroButton;
        private System.Windows.Forms.Label totalPriceLabel;
        private MetroFramework.Controls.MetroButton showAllMetroButton;
        private MetroFramework.Controls.MetroButton removeMetroButton;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel productSellPanel;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private MetroFramework.Controls.MetroButton searchMetroButton;
        private MetroFramework.Controls.MetroButton addMetroButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label nameLabel;
        private MetroFramework.Controls.MetroListView cartMetroListView;
        private System.Windows.Forms.ColumnHeader idColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader quantityColumnHeader;
        private System.Windows.Forms.ColumnHeader unitPriceColumnHeader;
        private System.Windows.Forms.ColumnHeader netPriceColumnHeader;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ColumnHeader slNoColumnHeader;
    }
}