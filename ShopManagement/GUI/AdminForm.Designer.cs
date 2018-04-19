namespace ShopManagement.GUI
{
    partial class AdminForm
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
            this.centerSplitContainer = new System.Windows.Forms.SplitContainer();
            this.manageProductsGroupBox = new System.Windows.Forms.GroupBox();
            this.manageProductsMetroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.addProductMetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.productQuantityNumericUpDownAdd = new System.Windows.Forms.NumericUpDown();
            this.totalPriceTextBoxAdd = new System.Windows.Forms.TextBox();
            this.productPriceTextBoxAdd = new System.Windows.Forms.TextBox();
            this.productNameTextBoxAdd = new System.Windows.Forms.TextBox();
            this.productIdTextBoxAdd = new System.Windows.Forms.TextBox();
            this.totalPriceLabelAdd = new System.Windows.Forms.Label();
            this.quantityLabelAdd = new System.Windows.Forms.Label();
            this.productPriceLabelAdd = new System.Windows.Forms.Label();
            this.productNameLabelAdd = new System.Windows.Forms.Label();
            this.productIdLabelAdd = new System.Windows.Forms.Label();
            this.submitMetroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.resetMetroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.searchAndUpdateMetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.submitMetroButtonSearchAndUpdate = new MetroFramework.Controls.MetroButton();
            this.productQuantityNumericUpDownSearchAndUpdate = new System.Windows.Forms.NumericUpDown();
            this.productPriceTextBoxSearchAndUpdate = new System.Windows.Forms.TextBox();
            this.productNameTextBoxSearchAndUpdate = new System.Windows.Forms.TextBox();
            this.productIdTextBoxSearchAndUpdate = new System.Windows.Forms.TextBox();
            this.searchMetroBtton = new MetroFramework.Controls.MetroButton();
            this.resetMetroButtonSearchAndUpdate = new MetroFramework.Controls.MetroButton();
            this.productQuantityLabelUpdate = new System.Windows.Forms.Label();
            this.productPriceLabelUpdate = new System.Windows.Forms.Label();
            this.productNameLabelhUpdate = new System.Windows.Forms.Label();
            this.productIdLabelUpdate = new System.Windows.Forms.Label();
            this.deleteMetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.productNameTextBoxDelete = new System.Windows.Forms.TextBox();
            this.productIdTextBoxDelete = new System.Windows.Forms.TextBox();
            this.productNameLabelDelete = new System.Windows.Forms.Label();
            this.productIdLabelDelete = new System.Windows.Forms.Label();
            this.resetMetroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.submitMetroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.quantityMetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.submitMetroButtonUpdateQuantity = new MetroFramework.Controls.MetroButton();
            this.resetMetroButtonUpdateQuantity = new MetroFramework.Controls.MetroButton();
            this.numericUpDownUpdateQuantity = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.nameTextBoxUpdateQuantity = new System.Windows.Forms.TextBox();
            this.idTextBoxUpdateQuantity = new System.Windows.Forms.TextBox();
            this.nameLabelUpdate = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.showAllProductsMetroButton = new MetroFramework.Controls.MetroButton();
            this.manageUserGroupBox = new System.Windows.Forms.GroupBox();
            this.notificationLabel = new System.Windows.Forms.Label();
            this.productListGroupBox = new System.Windows.Forms.GroupBox();
            this.productListMetroListView = new MetroFramework.Controls.MetroListView();
            this.idColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showAllMetroButton = new MetroFramework.Controls.MetroButton();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.logoutMetroButton = new MetroFramework.Controls.MetroButton();
            this.editInfoMetroButton = new MetroFramework.Controls.MetroButton();
            this.adminLabel = new System.Windows.Forms.Label();
            this.backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerSplitContainer)).BeginInit();
            this.centerSplitContainer.Panel1.SuspendLayout();
            this.centerSplitContainer.Panel2.SuspendLayout();
            this.centerSplitContainer.SuspendLayout();
            this.manageProductsGroupBox.SuspendLayout();
            this.manageProductsMetroTabControl.SuspendLayout();
            this.addProductMetroTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantityNumericUpDownAdd)).BeginInit();
            this.searchAndUpdateMetroTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantityNumericUpDownSearchAndUpdate)).BeginInit();
            this.deleteMetroTabPage.SuspendLayout();
            this.quantityMetroTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpdateQuantity)).BeginInit();
            this.manageUserGroupBox.SuspendLayout();
            this.productListGroupBox.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackgroundImage = global::ShopManagement.Properties.Resources.Background;
            this.backgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPanel.Controls.Add(this.centerSplitContainer);
            this.backgroundPanel.Controls.Add(this.leftPanel);
            this.backgroundPanel.Controls.Add(this.topPanel);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(20, 60);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(1324, 656);
            this.backgroundPanel.TabIndex = 0;
            // 
            // centerSplitContainer
            // 
            this.centerSplitContainer.BackColor = System.Drawing.Color.Transparent;
            this.centerSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerSplitContainer.Location = new System.Drawing.Point(25, 60);
            this.centerSplitContainer.Name = "centerSplitContainer";
            // 
            // centerSplitContainer.Panel1
            // 
            this.centerSplitContainer.Panel1.Controls.Add(this.manageProductsGroupBox);
            // 
            // centerSplitContainer.Panel2
            // 
            this.centerSplitContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.centerSplitContainer.Panel2.Controls.Add(this.showAllProductsMetroButton);
            this.centerSplitContainer.Panel2.Controls.Add(this.manageUserGroupBox);
            this.centerSplitContainer.Panel2.Controls.Add(this.productListGroupBox);
            this.centerSplitContainer.Size = new System.Drawing.Size(1299, 596);
            this.centerSplitContainer.SplitterDistance = 623;
            this.centerSplitContainer.TabIndex = 6;
            // 
            // manageProductsGroupBox
            // 
            this.manageProductsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manageProductsGroupBox.Controls.Add(this.manageProductsMetroTabControl);
            this.manageProductsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageProductsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageProductsGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.manageProductsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.manageProductsGroupBox.Name = "manageProductsGroupBox";
            this.manageProductsGroupBox.Size = new System.Drawing.Size(623, 596);
            this.manageProductsGroupBox.TabIndex = 1;
            this.manageProductsGroupBox.TabStop = false;
            this.manageProductsGroupBox.Text = "Manage products";
            // 
            // manageProductsMetroTabControl
            // 
            this.manageProductsMetroTabControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manageProductsMetroTabControl.Controls.Add(this.addProductMetroTabPage);
            this.manageProductsMetroTabControl.Controls.Add(this.searchAndUpdateMetroTabPage);
            this.manageProductsMetroTabControl.Controls.Add(this.deleteMetroTabPage);
            this.manageProductsMetroTabControl.Controls.Add(this.quantityMetroTabPage);
            this.manageProductsMetroTabControl.Location = new System.Drawing.Point(56, 83);
            this.manageProductsMetroTabControl.Name = "manageProductsMetroTabControl";
            this.manageProductsMetroTabControl.SelectedIndex = 1;
            this.manageProductsMetroTabControl.Size = new System.Drawing.Size(501, 401);
            this.manageProductsMetroTabControl.TabIndex = 2;
            this.manageProductsMetroTabControl.UseSelectable = true;
            // 
            // addProductMetroTabPage
            // 
            this.addProductMetroTabPage.BackColor = System.Drawing.Color.Transparent;
            this.addProductMetroTabPage.Controls.Add(this.productQuantityNumericUpDownAdd);
            this.addProductMetroTabPage.Controls.Add(this.totalPriceTextBoxAdd);
            this.addProductMetroTabPage.Controls.Add(this.productPriceTextBoxAdd);
            this.addProductMetroTabPage.Controls.Add(this.productNameTextBoxAdd);
            this.addProductMetroTabPage.Controls.Add(this.productIdTextBoxAdd);
            this.addProductMetroTabPage.Controls.Add(this.totalPriceLabelAdd);
            this.addProductMetroTabPage.Controls.Add(this.quantityLabelAdd);
            this.addProductMetroTabPage.Controls.Add(this.productPriceLabelAdd);
            this.addProductMetroTabPage.Controls.Add(this.productNameLabelAdd);
            this.addProductMetroTabPage.Controls.Add(this.productIdLabelAdd);
            this.addProductMetroTabPage.Controls.Add(this.submitMetroButtonAdd);
            this.addProductMetroTabPage.Controls.Add(this.resetMetroButtonAdd);
            this.addProductMetroTabPage.ForeColor = System.Drawing.Color.Transparent;
            this.addProductMetroTabPage.HorizontalScrollbarBarColor = true;
            this.addProductMetroTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.addProductMetroTabPage.HorizontalScrollbarSize = 10;
            this.addProductMetroTabPage.Location = new System.Drawing.Point(4, 38);
            this.addProductMetroTabPage.Name = "addProductMetroTabPage";
            this.addProductMetroTabPage.Size = new System.Drawing.Size(493, 359);
            this.addProductMetroTabPage.TabIndex = 0;
            this.addProductMetroTabPage.Text = "Add product";
            this.addProductMetroTabPage.VerticalScrollbarBarColor = true;
            this.addProductMetroTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.addProductMetroTabPage.VerticalScrollbarSize = 10;
            // 
            // productQuantityNumericUpDownAdd
            // 
            this.productQuantityNumericUpDownAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productQuantityNumericUpDownAdd.Location = new System.Drawing.Point(102, 223);
            this.productQuantityNumericUpDownAdd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.productQuantityNumericUpDownAdd.Name = "productQuantityNumericUpDownAdd";
            this.productQuantityNumericUpDownAdd.Size = new System.Drawing.Size(100, 22);
            this.productQuantityNumericUpDownAdd.TabIndex = 15;
            this.productQuantityNumericUpDownAdd.ThousandsSeparator = true;
            // 
            // totalPriceTextBoxAdd
            // 
            this.totalPriceTextBoxAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.totalPriceTextBoxAdd.Location = new System.Drawing.Point(102, 128);
            this.totalPriceTextBoxAdd.MaxLength = 10;
            this.totalPriceTextBoxAdd.Name = "totalPriceTextBoxAdd";
            this.totalPriceTextBoxAdd.Size = new System.Drawing.Size(125, 22);
            this.totalPriceTextBoxAdd.TabIndex = 14;
            // 
            // productPriceTextBoxAdd
            // 
            this.productPriceTextBoxAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productPriceTextBoxAdd.Location = new System.Drawing.Point(102, 173);
            this.productPriceTextBoxAdd.MaxLength = 10;
            this.productPriceTextBoxAdd.Name = "productPriceTextBoxAdd";
            this.productPriceTextBoxAdd.Size = new System.Drawing.Size(125, 22);
            this.productPriceTextBoxAdd.TabIndex = 14;
            // 
            // productNameTextBoxAdd
            // 
            this.productNameTextBoxAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productNameTextBoxAdd.Location = new System.Drawing.Point(102, 82);
            this.productNameTextBoxAdd.MaxLength = 100;
            this.productNameTextBoxAdd.Name = "productNameTextBoxAdd";
            this.productNameTextBoxAdd.Size = new System.Drawing.Size(268, 22);
            this.productNameTextBoxAdd.TabIndex = 13;
            // 
            // productIdTextBoxAdd
            // 
            this.productIdTextBoxAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productIdTextBoxAdd.Location = new System.Drawing.Point(102, 32);
            this.productIdTextBoxAdd.MaxLength = 20;
            this.productIdTextBoxAdd.Name = "productIdTextBoxAdd";
            this.productIdTextBoxAdd.Size = new System.Drawing.Size(194, 22);
            this.productIdTextBoxAdd.TabIndex = 8;
            // 
            // totalPriceLabelAdd
            // 
            this.totalPriceLabelAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.totalPriceLabelAdd.AutoSize = true;
            this.totalPriceLabelAdd.ForeColor = System.Drawing.Color.Black;
            this.totalPriceLabelAdd.Location = new System.Drawing.Point(20, 131);
            this.totalPriceLabelAdd.Name = "totalPriceLabelAdd";
            this.totalPriceLabelAdd.Size = new System.Drawing.Size(75, 16);
            this.totalPriceLabelAdd.TabIndex = 10;
            this.totalPriceLabelAdd.Text = "Total price:";
            // 
            // quantityLabelAdd
            // 
            this.quantityLabelAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.quantityLabelAdd.AutoSize = true;
            this.quantityLabelAdd.ForeColor = System.Drawing.Color.Black;
            this.quantityLabelAdd.Location = new System.Drawing.Point(20, 223);
            this.quantityLabelAdd.Name = "quantityLabelAdd";
            this.quantityLabelAdd.Size = new System.Drawing.Size(59, 16);
            this.quantityLabelAdd.TabIndex = 9;
            this.quantityLabelAdd.Text = "Quantity:";
            // 
            // productPriceLabelAdd
            // 
            this.productPriceLabelAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productPriceLabelAdd.AutoSize = true;
            this.productPriceLabelAdd.ForeColor = System.Drawing.Color.Black;
            this.productPriceLabelAdd.Location = new System.Drawing.Point(20, 173);
            this.productPriceLabelAdd.Name = "productPriceLabelAdd";
            this.productPriceLabelAdd.Size = new System.Drawing.Size(67, 16);
            this.productPriceLabelAdd.TabIndex = 10;
            this.productPriceLabelAdd.Text = "Unit price:";
            // 
            // productNameLabelAdd
            // 
            this.productNameLabelAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productNameLabelAdd.AutoSize = true;
            this.productNameLabelAdd.ForeColor = System.Drawing.Color.Black;
            this.productNameLabelAdd.Location = new System.Drawing.Point(20, 82);
            this.productNameLabelAdd.Name = "productNameLabelAdd";
            this.productNameLabelAdd.Size = new System.Drawing.Size(48, 16);
            this.productNameLabelAdd.TabIndex = 11;
            this.productNameLabelAdd.Text = "Name:";
            // 
            // productIdLabelAdd
            // 
            this.productIdLabelAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productIdLabelAdd.AutoSize = true;
            this.productIdLabelAdd.ForeColor = System.Drawing.Color.Black;
            this.productIdLabelAdd.Location = new System.Drawing.Point(20, 32);
            this.productIdLabelAdd.Name = "productIdLabelAdd";
            this.productIdLabelAdd.Size = new System.Drawing.Size(22, 16);
            this.productIdLabelAdd.TabIndex = 12;
            this.productIdLabelAdd.Text = "Id:";
            // 
            // submitMetroButtonAdd
            // 
            this.submitMetroButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitMetroButtonAdd.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.submitMetroButtonAdd.Location = new System.Drawing.Point(400, 289);
            this.submitMetroButtonAdd.Name = "submitMetroButtonAdd";
            this.submitMetroButtonAdd.Size = new System.Drawing.Size(65, 44);
            this.submitMetroButtonAdd.TabIndex = 16;
            this.submitMetroButtonAdd.Text = "Submit";
            this.submitMetroButtonAdd.UseSelectable = true;
            this.submitMetroButtonAdd.Click += new System.EventHandler(this.submitMetroButtonAdd_Click);
            // 
            // resetMetroButtonAdd
            // 
            this.resetMetroButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetMetroButtonAdd.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.resetMetroButtonAdd.Location = new System.Drawing.Point(300, 289);
            this.resetMetroButtonAdd.Name = "resetMetroButtonAdd";
            this.resetMetroButtonAdd.Size = new System.Drawing.Size(58, 44);
            this.resetMetroButtonAdd.TabIndex = 17;
            this.resetMetroButtonAdd.Text = "Reset";
            this.resetMetroButtonAdd.UseSelectable = true;
            this.resetMetroButtonAdd.Click += new System.EventHandler(this.resetMetroButtonAdd_Click);
            // 
            // searchAndUpdateMetroTabPage
            // 
            this.searchAndUpdateMetroTabPage.BackColor = System.Drawing.Color.Transparent;
            this.searchAndUpdateMetroTabPage.Controls.Add(this.submitMetroButtonSearchAndUpdate);
            this.searchAndUpdateMetroTabPage.Controls.Add(this.productQuantityNumericUpDownSearchAndUpdate);
            this.searchAndUpdateMetroTabPage.Controls.Add(this.productPriceTextBoxSearchAndUpdate);
            this.searchAndUpdateMetroTabPage.Controls.Add(this.productNameTextBoxSearchAndUpdate);
            this.searchAndUpdateMetroTabPage.Controls.Add(this.productIdTextBoxSearchAndUpdate);
            this.searchAndUpdateMetroTabPage.Controls.Add(this.searchMetroBtton);
            this.searchAndUpdateMetroTabPage.Controls.Add(this.resetMetroButtonSearchAndUpdate);
            this.searchAndUpdateMetroTabPage.Controls.Add(this.productQuantityLabelUpdate);
            this.searchAndUpdateMetroTabPage.Controls.Add(this.productPriceLabelUpdate);
            this.searchAndUpdateMetroTabPage.Controls.Add(this.productNameLabelhUpdate);
            this.searchAndUpdateMetroTabPage.Controls.Add(this.productIdLabelUpdate);
            this.searchAndUpdateMetroTabPage.HorizontalScrollbarBarColor = true;
            this.searchAndUpdateMetroTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.searchAndUpdateMetroTabPage.HorizontalScrollbarSize = 10;
            this.searchAndUpdateMetroTabPage.Location = new System.Drawing.Point(4, 38);
            this.searchAndUpdateMetroTabPage.Name = "searchAndUpdateMetroTabPage";
            this.searchAndUpdateMetroTabPage.Size = new System.Drawing.Size(493, 359);
            this.searchAndUpdateMetroTabPage.TabIndex = 1;
            this.searchAndUpdateMetroTabPage.Text = "Search and Update";
            this.searchAndUpdateMetroTabPage.VerticalScrollbarBarColor = true;
            this.searchAndUpdateMetroTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.searchAndUpdateMetroTabPage.VerticalScrollbarSize = 10;
            // 
            // submitMetroButtonSearchAndUpdate
            // 
            this.submitMetroButtonSearchAndUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitMetroButtonSearchAndUpdate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.submitMetroButtonSearchAndUpdate.Location = new System.Drawing.Point(400, 283);
            this.submitMetroButtonSearchAndUpdate.Name = "submitMetroButtonSearchAndUpdate";
            this.submitMetroButtonSearchAndUpdate.Size = new System.Drawing.Size(65, 44);
            this.submitMetroButtonSearchAndUpdate.TabIndex = 23;
            this.submitMetroButtonSearchAndUpdate.Text = "Submit";
            this.submitMetroButtonSearchAndUpdate.UseSelectable = true;
            this.submitMetroButtonSearchAndUpdate.Click += new System.EventHandler(this.submitMetroButtonSearchAndUpdate_Click);
            // 
            // productQuantityNumericUpDownSearchAndUpdate
            // 
            this.productQuantityNumericUpDownSearchAndUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productQuantityNumericUpDownSearchAndUpdate.Enabled = false;
            this.productQuantityNumericUpDownSearchAndUpdate.Location = new System.Drawing.Point(112, 224);
            this.productQuantityNumericUpDownSearchAndUpdate.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.productQuantityNumericUpDownSearchAndUpdate.Name = "productQuantityNumericUpDownSearchAndUpdate";
            this.productQuantityNumericUpDownSearchAndUpdate.ReadOnly = true;
            this.productQuantityNumericUpDownSearchAndUpdate.Size = new System.Drawing.Size(100, 22);
            this.productQuantityNumericUpDownSearchAndUpdate.TabIndex = 22;
            this.productQuantityNumericUpDownSearchAndUpdate.ThousandsSeparator = true;
            // 
            // productPriceTextBoxSearchAndUpdate
            // 
            this.productPriceTextBoxSearchAndUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productPriceTextBoxSearchAndUpdate.Location = new System.Drawing.Point(112, 174);
            this.productPriceTextBoxSearchAndUpdate.MaxLength = 10;
            this.productPriceTextBoxSearchAndUpdate.Name = "productPriceTextBoxSearchAndUpdate";
            this.productPriceTextBoxSearchAndUpdate.Size = new System.Drawing.Size(125, 22);
            this.productPriceTextBoxSearchAndUpdate.TabIndex = 21;
            // 
            // productNameTextBoxSearchAndUpdate
            // 
            this.productNameTextBoxSearchAndUpdate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.productNameTextBoxSearchAndUpdate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productNameTextBoxSearchAndUpdate.Location = new System.Drawing.Point(112, 114);
            this.productNameTextBoxSearchAndUpdate.MaxLength = 100;
            this.productNameTextBoxSearchAndUpdate.Name = "productNameTextBoxSearchAndUpdate";
            this.productNameTextBoxSearchAndUpdate.Size = new System.Drawing.Size(268, 22);
            this.productNameTextBoxSearchAndUpdate.TabIndex = 20;
            // 
            // productIdTextBoxSearchAndUpdate
            // 
            this.productIdTextBoxSearchAndUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productIdTextBoxSearchAndUpdate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.productIdTextBoxSearchAndUpdate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productIdTextBoxSearchAndUpdate.Location = new System.Drawing.Point(112, 72);
            this.productIdTextBoxSearchAndUpdate.MaxLength = 20;
            this.productIdTextBoxSearchAndUpdate.Name = "productIdTextBoxSearchAndUpdate";
            this.productIdTextBoxSearchAndUpdate.Size = new System.Drawing.Size(194, 22);
            this.productIdTextBoxSearchAndUpdate.TabIndex = 19;
            // 
            // searchMetroBtton
            // 
            this.searchMetroBtton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchMetroBtton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.searchMetroBtton.Location = new System.Drawing.Point(200, 283);
            this.searchMetroBtton.Name = "searchMetroBtton";
            this.searchMetroBtton.Size = new System.Drawing.Size(69, 44);
            this.searchMetroBtton.TabIndex = 24;
            this.searchMetroBtton.Text = "Search";
            this.searchMetroBtton.UseSelectable = true;
            this.searchMetroBtton.Click += new System.EventHandler(this.searchMetroBtton_Click);
            // 
            // resetMetroButtonSearchAndUpdate
            // 
            this.resetMetroButtonSearchAndUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetMetroButtonSearchAndUpdate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.resetMetroButtonSearchAndUpdate.Location = new System.Drawing.Point(300, 283);
            this.resetMetroButtonSearchAndUpdate.Name = "resetMetroButtonSearchAndUpdate";
            this.resetMetroButtonSearchAndUpdate.Size = new System.Drawing.Size(58, 44);
            this.resetMetroButtonSearchAndUpdate.TabIndex = 24;
            this.resetMetroButtonSearchAndUpdate.Text = "Reset";
            this.resetMetroButtonSearchAndUpdate.UseSelectable = true;
            this.resetMetroButtonSearchAndUpdate.Click += new System.EventHandler(this.resetMetroButtonSearchAndUpdate_Click);
            // 
            // productQuantityLabelUpdate
            // 
            this.productQuantityLabelUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productQuantityLabelUpdate.AutoSize = true;
            this.productQuantityLabelUpdate.ForeColor = System.Drawing.Color.Black;
            this.productQuantityLabelUpdate.Location = new System.Drawing.Point(30, 224);
            this.productQuantityLabelUpdate.Name = "productQuantityLabelUpdate";
            this.productQuantityLabelUpdate.Size = new System.Drawing.Size(59, 16);
            this.productQuantityLabelUpdate.TabIndex = 15;
            this.productQuantityLabelUpdate.Text = "Quantity:";
            // 
            // productPriceLabelUpdate
            // 
            this.productPriceLabelUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productPriceLabelUpdate.AutoSize = true;
            this.productPriceLabelUpdate.ForeColor = System.Drawing.Color.Black;
            this.productPriceLabelUpdate.Location = new System.Drawing.Point(30, 174);
            this.productPriceLabelUpdate.Name = "productPriceLabelUpdate";
            this.productPriceLabelUpdate.Size = new System.Drawing.Size(42, 16);
            this.productPriceLabelUpdate.TabIndex = 16;
            this.productPriceLabelUpdate.Text = "Price:";
            // 
            // productNameLabelhUpdate
            // 
            this.productNameLabelhUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productNameLabelhUpdate.AutoSize = true;
            this.productNameLabelhUpdate.BackColor = System.Drawing.Color.Transparent;
            this.productNameLabelhUpdate.ForeColor = System.Drawing.Color.Black;
            this.productNameLabelhUpdate.Location = new System.Drawing.Point(30, 122);
            this.productNameLabelhUpdate.Name = "productNameLabelhUpdate";
            this.productNameLabelhUpdate.Size = new System.Drawing.Size(48, 16);
            this.productNameLabelhUpdate.TabIndex = 17;
            this.productNameLabelhUpdate.Text = "Name:";
            // 
            // productIdLabelUpdate
            // 
            this.productIdLabelUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productIdLabelUpdate.AutoSize = true;
            this.productIdLabelUpdate.ForeColor = System.Drawing.Color.Black;
            this.productIdLabelUpdate.Location = new System.Drawing.Point(30, 72);
            this.productIdLabelUpdate.Name = "productIdLabelUpdate";
            this.productIdLabelUpdate.Size = new System.Drawing.Size(22, 16);
            this.productIdLabelUpdate.TabIndex = 18;
            this.productIdLabelUpdate.Text = "Id:";
            // 
            // deleteMetroTabPage
            // 
            this.deleteMetroTabPage.BackColor = System.Drawing.Color.Transparent;
            this.deleteMetroTabPage.Controls.Add(this.productNameTextBoxDelete);
            this.deleteMetroTabPage.Controls.Add(this.productIdTextBoxDelete);
            this.deleteMetroTabPage.Controls.Add(this.productNameLabelDelete);
            this.deleteMetroTabPage.Controls.Add(this.productIdLabelDelete);
            this.deleteMetroTabPage.Controls.Add(this.resetMetroButtonDelete);
            this.deleteMetroTabPage.Controls.Add(this.submitMetroButtonDelete);
            this.deleteMetroTabPage.HorizontalScrollbarBarColor = true;
            this.deleteMetroTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.deleteMetroTabPage.HorizontalScrollbarSize = 10;
            this.deleteMetroTabPage.Location = new System.Drawing.Point(4, 38);
            this.deleteMetroTabPage.Name = "deleteMetroTabPage";
            this.deleteMetroTabPage.Size = new System.Drawing.Size(493, 359);
            this.deleteMetroTabPage.TabIndex = 2;
            this.deleteMetroTabPage.Text = "Delete product";
            this.deleteMetroTabPage.VerticalScrollbarBarColor = true;
            this.deleteMetroTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.deleteMetroTabPage.VerticalScrollbarSize = 10;
            // 
            // productNameTextBoxDelete
            // 
            this.productNameTextBoxDelete.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.productNameTextBoxDelete.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productNameTextBoxDelete.Location = new System.Drawing.Point(112, 114);
            this.productNameTextBoxDelete.MaxLength = 100;
            this.productNameTextBoxDelete.Name = "productNameTextBoxDelete";
            this.productNameTextBoxDelete.Size = new System.Drawing.Size(268, 22);
            this.productNameTextBoxDelete.TabIndex = 23;
            // 
            // productIdTextBoxDelete
            // 
            this.productIdTextBoxDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productIdTextBoxDelete.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.productIdTextBoxDelete.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productIdTextBoxDelete.Location = new System.Drawing.Point(112, 74);
            this.productIdTextBoxDelete.MaxLength = 20;
            this.productIdTextBoxDelete.Name = "productIdTextBoxDelete";
            this.productIdTextBoxDelete.Size = new System.Drawing.Size(194, 22);
            this.productIdTextBoxDelete.TabIndex = 22;
            // 
            // productNameLabelDelete
            // 
            this.productNameLabelDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productNameLabelDelete.AutoSize = true;
            this.productNameLabelDelete.ForeColor = System.Drawing.Color.Black;
            this.productNameLabelDelete.Location = new System.Drawing.Point(30, 124);
            this.productNameLabelDelete.Name = "productNameLabelDelete";
            this.productNameLabelDelete.Size = new System.Drawing.Size(48, 16);
            this.productNameLabelDelete.TabIndex = 20;
            this.productNameLabelDelete.Text = "Name:";
            // 
            // productIdLabelDelete
            // 
            this.productIdLabelDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productIdLabelDelete.AutoSize = true;
            this.productIdLabelDelete.ForeColor = System.Drawing.Color.Black;
            this.productIdLabelDelete.Location = new System.Drawing.Point(30, 74);
            this.productIdLabelDelete.Name = "productIdLabelDelete";
            this.productIdLabelDelete.Size = new System.Drawing.Size(22, 16);
            this.productIdLabelDelete.TabIndex = 21;
            this.productIdLabelDelete.Text = "Id:";
            // 
            // resetMetroButtonDelete
            // 
            this.resetMetroButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetMetroButtonDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.resetMetroButtonDelete.Location = new System.Drawing.Point(300, 286);
            this.resetMetroButtonDelete.Name = "resetMetroButtonDelete";
            this.resetMetroButtonDelete.Size = new System.Drawing.Size(58, 44);
            this.resetMetroButtonDelete.TabIndex = 25;
            this.resetMetroButtonDelete.Text = "Reset";
            this.resetMetroButtonDelete.UseSelectable = true;
            this.resetMetroButtonDelete.Click += new System.EventHandler(this.resetMetroButtonDelete_Click);
            // 
            // submitMetroButtonDelete
            // 
            this.submitMetroButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitMetroButtonDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.submitMetroButtonDelete.Location = new System.Drawing.Point(400, 286);
            this.submitMetroButtonDelete.Name = "submitMetroButtonDelete";
            this.submitMetroButtonDelete.Size = new System.Drawing.Size(65, 44);
            this.submitMetroButtonDelete.TabIndex = 24;
            this.submitMetroButtonDelete.Text = "Submit";
            this.submitMetroButtonDelete.UseSelectable = true;
            this.submitMetroButtonDelete.Click += new System.EventHandler(this.submitMetroButtonDelete_Click);
            // 
            // quantityMetroTabPage
            // 
            this.quantityMetroTabPage.Controls.Add(this.submitMetroButtonUpdateQuantity);
            this.quantityMetroTabPage.Controls.Add(this.resetMetroButtonUpdateQuantity);
            this.quantityMetroTabPage.Controls.Add(this.numericUpDownUpdateQuantity);
            this.quantityMetroTabPage.Controls.Add(this.quantityLabel);
            this.quantityMetroTabPage.Controls.Add(this.nameTextBoxUpdateQuantity);
            this.quantityMetroTabPage.Controls.Add(this.idTextBoxUpdateQuantity);
            this.quantityMetroTabPage.Controls.Add(this.nameLabelUpdate);
            this.quantityMetroTabPage.Controls.Add(this.idLabel);
            this.quantityMetroTabPage.HorizontalScrollbarBarColor = true;
            this.quantityMetroTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.quantityMetroTabPage.HorizontalScrollbarSize = 10;
            this.quantityMetroTabPage.Location = new System.Drawing.Point(4, 38);
            this.quantityMetroTabPage.Name = "quantityMetroTabPage";
            this.quantityMetroTabPage.Size = new System.Drawing.Size(493, 359);
            this.quantityMetroTabPage.TabIndex = 3;
            this.quantityMetroTabPage.Text = "Update quantity";
            this.quantityMetroTabPage.VerticalScrollbarBarColor = true;
            this.quantityMetroTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.quantityMetroTabPage.VerticalScrollbarSize = 10;
            // 
            // submitMetroButtonUpdateQuantity
            // 
            this.submitMetroButtonUpdateQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitMetroButtonUpdateQuantity.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.submitMetroButtonUpdateQuantity.Location = new System.Drawing.Point(389, 260);
            this.submitMetroButtonUpdateQuantity.Name = "submitMetroButtonUpdateQuantity";
            this.submitMetroButtonUpdateQuantity.Size = new System.Drawing.Size(65, 44);
            this.submitMetroButtonUpdateQuantity.TabIndex = 20;
            this.submitMetroButtonUpdateQuantity.Text = "Submit";
            this.submitMetroButtonUpdateQuantity.UseSelectable = true;
            this.submitMetroButtonUpdateQuantity.Click += new System.EventHandler(this.submitMetroButtonUpdateQuantity_Click);
            // 
            // resetMetroButtonUpdateQuantity
            // 
            this.resetMetroButtonUpdateQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetMetroButtonUpdateQuantity.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.resetMetroButtonUpdateQuantity.Location = new System.Drawing.Point(289, 260);
            this.resetMetroButtonUpdateQuantity.Name = "resetMetroButtonUpdateQuantity";
            this.resetMetroButtonUpdateQuantity.Size = new System.Drawing.Size(58, 44);
            this.resetMetroButtonUpdateQuantity.TabIndex = 21;
            this.resetMetroButtonUpdateQuantity.Text = "Reset";
            this.resetMetroButtonUpdateQuantity.UseSelectable = true;
            this.resetMetroButtonUpdateQuantity.Click += new System.EventHandler(this.resetMetroButtonUpdateQuantity_Click);
            // 
            // numericUpDownUpdateQuantity
            // 
            this.numericUpDownUpdateQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownUpdateQuantity.Location = new System.Drawing.Point(104, 143);
            this.numericUpDownUpdateQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownUpdateQuantity.Name = "numericUpDownUpdateQuantity";
            this.numericUpDownUpdateQuantity.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownUpdateQuantity.TabIndex = 19;
            this.numericUpDownUpdateQuantity.ThousandsSeparator = true;
            // 
            // quantityLabel
            // 
            this.quantityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.quantityLabel.ForeColor = System.Drawing.Color.Black;
            this.quantityLabel.Location = new System.Drawing.Point(22, 143);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(59, 16);
            this.quantityLabel.TabIndex = 18;
            this.quantityLabel.Text = "Quantity:";
            // 
            // nameTextBoxUpdateQuantity
            // 
            this.nameTextBoxUpdateQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameTextBoxUpdateQuantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nameTextBoxUpdateQuantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.nameTextBoxUpdateQuantity.Location = new System.Drawing.Point(104, 92);
            this.nameTextBoxUpdateQuantity.MaxLength = 100;
            this.nameTextBoxUpdateQuantity.Name = "nameTextBoxUpdateQuantity";
            this.nameTextBoxUpdateQuantity.Size = new System.Drawing.Size(268, 22);
            this.nameTextBoxUpdateQuantity.TabIndex = 17;
            // 
            // idTextBoxUpdateQuantity
            // 
            this.idTextBoxUpdateQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.idTextBoxUpdateQuantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.idTextBoxUpdateQuantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.idTextBoxUpdateQuantity.Location = new System.Drawing.Point(104, 42);
            this.idTextBoxUpdateQuantity.MaxLength = 20;
            this.idTextBoxUpdateQuantity.Name = "idTextBoxUpdateQuantity";
            this.idTextBoxUpdateQuantity.Size = new System.Drawing.Size(194, 22);
            this.idTextBoxUpdateQuantity.TabIndex = 14;
            // 
            // nameLabelUpdate
            // 
            this.nameLabelUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameLabelUpdate.AutoSize = true;
            this.nameLabelUpdate.BackColor = System.Drawing.Color.Transparent;
            this.nameLabelUpdate.ForeColor = System.Drawing.Color.Black;
            this.nameLabelUpdate.Location = new System.Drawing.Point(22, 92);
            this.nameLabelUpdate.Name = "nameLabelUpdate";
            this.nameLabelUpdate.Size = new System.Drawing.Size(48, 16);
            this.nameLabelUpdate.TabIndex = 15;
            this.nameLabelUpdate.Text = "Name:";
            // 
            // idLabel
            // 
            this.idLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.Transparent;
            this.idLabel.ForeColor = System.Drawing.Color.Black;
            this.idLabel.Location = new System.Drawing.Point(22, 42);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(22, 16);
            this.idLabel.TabIndex = 16;
            this.idLabel.Text = "Id:";
            // 
            // showAllProductsMetroButton
            // 
            this.showAllProductsMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showAllProductsMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.showAllProductsMetroButton.Location = new System.Drawing.Point(481, 423);
            this.showAllProductsMetroButton.Name = "showAllProductsMetroButton";
            this.showAllProductsMetroButton.Size = new System.Drawing.Size(102, 44);
            this.showAllProductsMetroButton.TabIndex = 24;
            this.showAllProductsMetroButton.Text = "Show all";
            this.showAllProductsMetroButton.UseSelectable = true;
            this.showAllProductsMetroButton.Click += new System.EventHandler(this.showAllProductsMetroButton_Click);
            // 
            // manageUserGroupBox
            // 
            this.manageUserGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manageUserGroupBox.Controls.Add(this.notificationLabel);
            this.manageUserGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUserGroupBox.Location = new System.Drawing.Point(113, 493);
            this.manageUserGroupBox.Name = "manageUserGroupBox";
            this.manageUserGroupBox.Size = new System.Drawing.Size(470, 68);
            this.manageUserGroupBox.TabIndex = 22;
            this.manageUserGroupBox.TabStop = false;
            this.manageUserGroupBox.Text = "Manage users";
            // 
            // notificationLabel
            // 
            this.notificationLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationLabel.ForeColor = System.Drawing.Color.Red;
            this.notificationLabel.Location = new System.Drawing.Point(137, 25);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(179, 25);
            this.notificationLabel.TabIndex = 23;
            this.notificationLabel.Text = "New notification";
            this.notificationLabel.Click += new System.EventHandler(this.notificationLabel_Click);
            // 
            // productListGroupBox
            // 
            this.productListGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.productListGroupBox.Controls.Add(this.productListMetroListView);
            this.productListGroupBox.Controls.Add(this.showAllMetroButton);
            this.productListGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productListGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.productListGroupBox.Location = new System.Drawing.Point(92, 16);
            this.productListGroupBox.Name = "productListGroupBox";
            this.productListGroupBox.Size = new System.Drawing.Size(541, 383);
            this.productListGroupBox.TabIndex = 20;
            this.productListGroupBox.TabStop = false;
            this.productListGroupBox.Text = "Product list";
            // 
            // productListMetroListView
            // 
            this.productListMetroListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumnHeader,
            this.productIdColumnHeader,
            this.nameColumnHeader,
            this.priceColumnHeader,
            this.quantityColumnHeader});
            this.productListMetroListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productListMetroListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.productListMetroListView.FullRowSelect = true;
            this.productListMetroListView.GridLines = true;
            this.productListMetroListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.productListMetroListView.Location = new System.Drawing.Point(3, 18);
            this.productListMetroListView.Name = "productListMetroListView";
            this.productListMetroListView.OwnerDraw = true;
            this.productListMetroListView.Size = new System.Drawing.Size(535, 362);
            this.productListMetroListView.TabIndex = 0;
            this.productListMetroListView.UseCompatibleStateImageBehavior = false;
            this.productListMetroListView.UseSelectable = true;
            this.productListMetroListView.View = System.Windows.Forms.View.Details;
            this.productListMetroListView.Click += new System.EventHandler(this.productListMetroListView_SelectedIndexChanged);
            // 
            // idColumnHeader
            // 
            this.idColumnHeader.Text = "SL no";
            this.idColumnHeader.Width = 90;
            // 
            // productIdColumnHeader
            // 
            this.productIdColumnHeader.Text = "Id";
            this.productIdColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameColumnHeader.Width = 168;
            // 
            // priceColumnHeader
            // 
            this.priceColumnHeader.Text = "Price";
            this.priceColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceColumnHeader.Width = 128;
            // 
            // quantityColumnHeader
            // 
            this.quantityColumnHeader.Text = "Quantity";
            this.quantityColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityColumnHeader.Width = 72;
            // 
            // showAllMetroButton
            // 
            this.showAllMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showAllMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.showAllMetroButton.Location = new System.Drawing.Point(453, 350);
            this.showAllMetroButton.Name = "showAllMetroButton";
            this.showAllMetroButton.Size = new System.Drawing.Size(82, 27);
            this.showAllMetroButton.TabIndex = 21;
            this.showAllMetroButton.Text = "Show all";
            this.showAllMetroButton.UseSelectable = true;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.Transparent;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 60);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(25, 596);
            this.leftPanel.TabIndex = 5;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.Controls.Add(this.logoutMetroButton);
            this.topPanel.Controls.Add(this.editInfoMetroButton);
            this.topPanel.Controls.Add(this.adminLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1324, 60);
            this.topPanel.TabIndex = 4;
            // 
            // logoutMetroButton
            // 
            this.logoutMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.logoutMetroButton.Location = new System.Drawing.Point(1210, 9);
            this.logoutMetroButton.Name = "logoutMetroButton";
            this.logoutMetroButton.Size = new System.Drawing.Size(75, 44);
            this.logoutMetroButton.TabIndex = 25;
            this.logoutMetroButton.Text = "Logout";
            this.logoutMetroButton.UseSelectable = true;
            this.logoutMetroButton.Click += new System.EventHandler(this.logoutMetroButton_Click);
            // 
            // editInfoMetroButton
            // 
            this.editInfoMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editInfoMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.editInfoMetroButton.Location = new System.Drawing.Point(1104, 9);
            this.editInfoMetroButton.Name = "editInfoMetroButton";
            this.editInfoMetroButton.Size = new System.Drawing.Size(75, 44);
            this.editInfoMetroButton.TabIndex = 26;
            this.editInfoMetroButton.Text = "Edit info";
            this.editInfoMetroButton.UseSelectable = true;
            this.editInfoMetroButton.Click += new System.EventHandler(this.editInfoMetroButton_Click);
            // 
            // adminLabel
            // 
            this.adminLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adminLabel.AutoSize = true;
            this.adminLabel.BackColor = System.Drawing.Color.Transparent;
            this.adminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminLabel.Location = new System.Drawing.Point(595, 20);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(90, 31);
            this.adminLabel.TabIndex = 0;
            this.adminLabel.Text = "Admin";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.backgroundPanel);
            this.MinimumSize = new System.Drawing.Size(1364, 736);
            this.Name = "AdminForm";
            this.Text = "Super shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.backgroundPanel.ResumeLayout(false);
            this.centerSplitContainer.Panel1.ResumeLayout(false);
            this.centerSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.centerSplitContainer)).EndInit();
            this.centerSplitContainer.ResumeLayout(false);
            this.manageProductsGroupBox.ResumeLayout(false);
            this.manageProductsMetroTabControl.ResumeLayout(false);
            this.addProductMetroTabPage.ResumeLayout(false);
            this.addProductMetroTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantityNumericUpDownAdd)).EndInit();
            this.searchAndUpdateMetroTabPage.ResumeLayout(false);
            this.searchAndUpdateMetroTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantityNumericUpDownSearchAndUpdate)).EndInit();
            this.deleteMetroTabPage.ResumeLayout(false);
            this.deleteMetroTabPage.PerformLayout();
            this.quantityMetroTabPage.ResumeLayout(false);
            this.quantityMetroTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpdateQuantity)).EndInit();
            this.manageUserGroupBox.ResumeLayout(false);
            this.manageUserGroupBox.PerformLayout();
            this.productListGroupBox.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.Panel topPanel;
        private MetroFramework.Controls.MetroButton logoutMetroButton;
        private MetroFramework.Controls.MetroButton editInfoMetroButton;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.SplitContainer centerSplitContainer;
        private System.Windows.Forms.GroupBox manageUserGroupBox;
        private System.Windows.Forms.Label notificationLabel;
        private System.Windows.Forms.GroupBox productListGroupBox;
        private MetroFramework.Controls.MetroListView productListMetroListView;
        private System.Windows.Forms.ColumnHeader idColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader priceColumnHeader;
        private System.Windows.Forms.ColumnHeader quantityColumnHeader;
        private MetroFramework.Controls.MetroButton showAllMetroButton;
        private System.Windows.Forms.GroupBox manageProductsGroupBox;
        private MetroFramework.Controls.MetroTabControl manageProductsMetroTabControl;
        private MetroFramework.Controls.MetroTabPage addProductMetroTabPage;
        private System.Windows.Forms.NumericUpDown productQuantityNumericUpDownAdd;
        private System.Windows.Forms.TextBox productPriceTextBoxAdd;
        private System.Windows.Forms.TextBox productNameTextBoxAdd;
        private System.Windows.Forms.TextBox productIdTextBoxAdd;
        private System.Windows.Forms.Label quantityLabelAdd;
        private System.Windows.Forms.Label productPriceLabelAdd;
        private System.Windows.Forms.Label productNameLabelAdd;
        private System.Windows.Forms.Label productIdLabelAdd;
        private MetroFramework.Controls.MetroButton submitMetroButtonAdd;
        private MetroFramework.Controls.MetroButton resetMetroButtonAdd;
        private MetroFramework.Controls.MetroTabPage searchAndUpdateMetroTabPage;
        private MetroFramework.Controls.MetroButton submitMetroButtonSearchAndUpdate;
        private System.Windows.Forms.NumericUpDown productQuantityNumericUpDownSearchAndUpdate;
        private System.Windows.Forms.TextBox productPriceTextBoxSearchAndUpdate;
        private System.Windows.Forms.TextBox productNameTextBoxSearchAndUpdate;
        private System.Windows.Forms.TextBox productIdTextBoxSearchAndUpdate;
        private MetroFramework.Controls.MetroButton searchMetroBtton;
        private MetroFramework.Controls.MetroButton resetMetroButtonSearchAndUpdate;
        private System.Windows.Forms.Label productQuantityLabelUpdate;
        private System.Windows.Forms.Label productPriceLabelUpdate;
        private System.Windows.Forms.Label productNameLabelhUpdate;
        private System.Windows.Forms.Label productIdLabelUpdate;
        private MetroFramework.Controls.MetroTabPage deleteMetroTabPage;
        private System.Windows.Forms.TextBox productNameTextBoxDelete;
        private System.Windows.Forms.TextBox productIdTextBoxDelete;
        private System.Windows.Forms.Label productNameLabelDelete;
        private System.Windows.Forms.Label productIdLabelDelete;
        private MetroFramework.Controls.MetroButton resetMetroButtonDelete;
        private MetroFramework.Controls.MetroButton submitMetroButtonDelete;
        private MetroFramework.Controls.MetroButton showAllProductsMetroButton;
        private System.Windows.Forms.ColumnHeader productIdColumnHeader;
        private System.Windows.Forms.TextBox totalPriceTextBoxAdd;
        private System.Windows.Forms.Label totalPriceLabelAdd;
        private MetroFramework.Controls.MetroTabPage quantityMetroTabPage;
        private MetroFramework.Controls.MetroButton submitMetroButtonUpdateQuantity;
        private MetroFramework.Controls.MetroButton resetMetroButtonUpdateQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownUpdateQuantity;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox nameTextBoxUpdateQuantity;
        private System.Windows.Forms.TextBox idTextBoxUpdateQuantity;
        private System.Windows.Forms.Label nameLabelUpdate;
        private System.Windows.Forms.Label idLabel;
    }
}