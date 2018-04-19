namespace ShopManagement.GUI
{
    partial class AllProductsForm
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
            this.allProductsMetroListView = new MetroFramework.Controls.MetroListView();
            this.slNoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.addMetroButton = new MetroFramework.Controls.MetroButton();
            this.backMetroButton = new MetroFramework.Controls.MetroButton();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.backgroundPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackgroundImage = global::ShopManagement.Properties.Resources.Background;
            this.backgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPanel.Controls.Add(this.allProductsMetroListView);
            this.backgroundPanel.Controls.Add(this.bottomPanel);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(20, 60);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(560, 420);
            this.backgroundPanel.TabIndex = 0;
            // 
            // allProductsMetroListView
            // 
            this.allProductsMetroListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.slNoColumnHeader,
            this.idColumnHeader,
            this.nameColumnHeader,
            this.quantityColumnHeader,
            this.priceColumnHeader});
            this.allProductsMetroListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allProductsMetroListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.allProductsMetroListView.FullRowSelect = true;
            this.allProductsMetroListView.GridLines = true;
            this.allProductsMetroListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.allProductsMetroListView.Location = new System.Drawing.Point(0, 0);
            this.allProductsMetroListView.Name = "allProductsMetroListView";
            this.allProductsMetroListView.OwnerDraw = true;
            this.allProductsMetroListView.Size = new System.Drawing.Size(560, 339);
            this.allProductsMetroListView.TabIndex = 3;
            this.allProductsMetroListView.UseCompatibleStateImageBehavior = false;
            this.allProductsMetroListView.UseSelectable = true;
            this.allProductsMetroListView.View = System.Windows.Forms.View.Details;
            this.allProductsMetroListView.Click += new System.EventHandler(this.allProductsMetroListView_SelectedIndexChanged);
            // 
            // slNoColumnHeader
            // 
            this.slNoColumnHeader.Text = "Sl no";
            this.slNoColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // idColumnHeader
            // 
            this.idColumnHeader.Text = "Id";
            this.idColumnHeader.Width = 58;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameColumnHeader.Width = 228;
            // 
            // quantityColumnHeader
            // 
            this.quantityColumnHeader.Text = "Available";
            this.quantityColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityColumnHeader.Width = 80;
            // 
            // priceColumnHeader
            // 
            this.priceColumnHeader.Text = "Price";
            this.priceColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceColumnHeader.Width = 85;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.bottomPanel.Controls.Add(this.quantityNumericUpDown);
            this.bottomPanel.Controls.Add(this.quantityLabel);
            this.bottomPanel.Controls.Add(this.addMetroButton);
            this.bottomPanel.Controls.Add(this.backMetroButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 339);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(560, 81);
            this.bottomPanel.TabIndex = 2;
            // 
            // addMetroButton
            // 
            this.addMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.addMetroButton.Location = new System.Drawing.Point(357, 24);
            this.addMetroButton.Name = "addMetroButton";
            this.addMetroButton.Size = new System.Drawing.Size(91, 44);
            this.addMetroButton.TabIndex = 0;
            this.addMetroButton.Text = "Add";
            this.addMetroButton.UseSelectable = true;
            this.addMetroButton.Click += new System.EventHandler(this.addMetroButton_Click);
            // 
            // backMetroButton
            // 
            this.backMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.backMetroButton.Location = new System.Drawing.Point(471, 24);
            this.backMetroButton.Name = "backMetroButton";
            this.backMetroButton.Size = new System.Drawing.Size(77, 44);
            this.backMetroButton.TabIndex = 0;
            this.backMetroButton.Text = "Back";
            this.backMetroButton.UseSelectable = true;
            this.backMetroButton.Click += new System.EventHandler(this.backMetroButton_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quantityLabel.Location = new System.Drawing.Point(54, 36);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(76, 20);
            this.quantityLabel.TabIndex = 1;
            this.quantityLabel.Text = "Quantity: ";
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quantityNumericUpDown.Location = new System.Drawing.Point(136, 36);
            this.quantityNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.quantityNumericUpDown.TabIndex = 2;
            // 
            // AllProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.backgroundPanel);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "AllProductsForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "Super shop";
            this.Load += new System.EventHandler(this.AllProductsForm_Load);
            this.backgroundPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private MetroFramework.Controls.MetroButton addMetroButton;
        private MetroFramework.Controls.MetroButton backMetroButton;
        private MetroFramework.Controls.MetroListView allProductsMetroListView;
        private System.Windows.Forms.ColumnHeader idColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader quantityColumnHeader;
        private System.Windows.Forms.ColumnHeader priceColumnHeader;
        private System.Windows.Forms.ColumnHeader slNoColumnHeader;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Label quantityLabel;
    }
}