namespace ShopManagement.GUI
{
    partial class LimitedStockForm
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
            this.limitedStockListView = new System.Windows.Forms.ListView();
            this.slNoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackgroundImage = global::ShopManagement.Properties.Resources.Background;
            this.backgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPanel.Controls.Add(this.limitedStockListView);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(20, 60);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(531, 299);
            this.backgroundPanel.TabIndex = 0;
            // 
            // limitedStockListView
            // 
            this.limitedStockListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.slNoColumnHeader,
            this.idColumnHeader,
            this.nameColumnHeader,
            this.quantityColumnHeader,
            this.priceColumnHeader});
            this.limitedStockListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.limitedStockListView.GridLines = true;
            this.limitedStockListView.Location = new System.Drawing.Point(0, 0);
            this.limitedStockListView.Name = "limitedStockListView";
            this.limitedStockListView.Size = new System.Drawing.Size(531, 299);
            this.limitedStockListView.TabIndex = 0;
            this.limitedStockListView.UseCompatibleStateImageBehavior = false;
            this.limitedStockListView.View = System.Windows.Forms.View.Details;
            // 
            // slNoColumnHeader
            // 
            this.slNoColumnHeader.Text = "Sl no";
            // 
            // idColumnHeader
            // 
            this.idColumnHeader.Text = "Id";
            this.idColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameColumnHeader.Width = 200;
            // 
            // quantityColumnHeader
            // 
            this.quantityColumnHeader.Text = "Quantity";
            this.quantityColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceColumnHeader
            // 
            this.priceColumnHeader.Text = "Price";
            this.priceColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceColumnHeader.Width = 140;
            // 
            // LimitedStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 379);
            this.Controls.Add(this.backgroundPanel);
            this.Name = "LimitedStockForm";
            this.Text = "Super shop";
            this.Load += new System.EventHandler(this.LimitedStockForm_Load);
            this.backgroundPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.ListView limitedStockListView;
        private System.Windows.Forms.ColumnHeader slNoColumnHeader;
        private System.Windows.Forms.ColumnHeader idColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader quantityColumnHeader;
        private System.Windows.Forms.ColumnHeader priceColumnHeader;
    }
}