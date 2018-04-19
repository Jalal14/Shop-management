namespace ShopManagement.GUI
{
    partial class TransactionForm
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
            this.profitLabel = new System.Windows.Forms.Label();
            this.transactionListView = new System.Windows.Forms.ListView();
            this.slNocolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewMetroButton = new MetroFramework.Controls.MetroButton();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.toDateLabel = new System.Windows.Forms.Label();
            this.backgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackgroundImage = global::ShopManagement.Properties.Resources.Background;
            this.backgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPanel.Controls.Add(this.profitLabel);
            this.backgroundPanel.Controls.Add(this.transactionListView);
            this.backgroundPanel.Controls.Add(this.viewMetroButton);
            this.backgroundPanel.Controls.Add(this.toDateTimePicker);
            this.backgroundPanel.Controls.Add(this.fromDateTimePicker);
            this.backgroundPanel.Controls.Add(this.dateLabel);
            this.backgroundPanel.Controls.Add(this.toDateLabel);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(20, 60);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(621, 393);
            this.backgroundPanel.TabIndex = 0;
            // 
            // profitLabel
            // 
            this.profitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.profitLabel.AutoSize = true;
            this.profitLabel.BackColor = System.Drawing.Color.Transparent;
            this.profitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitLabel.ForeColor = System.Drawing.Color.Maroon;
            this.profitLabel.Location = new System.Drawing.Point(98, 341);
            this.profitLabel.Name = "profitLabel";
            this.profitLabel.Size = new System.Drawing.Size(52, 20);
            this.profitLabel.TabIndex = 4;
            this.profitLabel.Text = "Profit";
            // 
            // transactionListView
            // 
            this.transactionListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.transactionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.slNocolumnHeader,
            this.dateColumnHeader,
            this.incomeColumnHeader,
            this.expenseColumnHeader});
            this.transactionListView.GridLines = true;
            this.transactionListView.Location = new System.Drawing.Point(102, 129);
            this.transactionListView.Name = "transactionListView";
            this.transactionListView.Size = new System.Drawing.Size(418, 194);
            this.transactionListView.TabIndex = 3;
            this.transactionListView.UseCompatibleStateImageBehavior = false;
            this.transactionListView.View = System.Windows.Forms.View.Details;
            // 
            // slNocolumnHeader
            // 
            this.slNocolumnHeader.Text = "Sl no";
            // 
            // dateColumnHeader
            // 
            this.dateColumnHeader.Text = "Date";
            this.dateColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateColumnHeader.Width = 150;
            // 
            // incomeColumnHeader
            // 
            this.incomeColumnHeader.Text = "Income";
            this.incomeColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.incomeColumnHeader.Width = 100;
            // 
            // expenseColumnHeader
            // 
            this.expenseColumnHeader.Text = "Expense";
            this.expenseColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.expenseColumnHeader.Width = 100;
            // 
            // viewMetroButton
            // 
            this.viewMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.viewMetroButton.Location = new System.Drawing.Point(490, 83);
            this.viewMetroButton.Name = "viewMetroButton";
            this.viewMetroButton.Size = new System.Drawing.Size(75, 40);
            this.viewMetroButton.TabIndex = 2;
            this.viewMetroButton.Text = "View";
            this.viewMetroButton.UseSelectable = true;
            this.viewMetroButton.Click += new System.EventHandler(this.viewMetroButton_Click);
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateTimePicker.CustomFormat = "MMMM dd, yyyy";
            this.toDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDateTimePicker.Location = new System.Drawing.Point(365, 43);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.toDateTimePicker.TabIndex = 1;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateTimePicker.CustomFormat = "MMMM dd, yyyy";
            this.fromDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDateTimePicker.Location = new System.Drawing.Point(90, 43);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fromDateTimePicker.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateLabel.Location = new System.Drawing.Point(32, 43);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(52, 20);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date: ";
            // 
            // toDateLabel
            // 
            this.toDateLabel.AutoSize = true;
            this.toDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.toDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toDateLabel.Location = new System.Drawing.Point(324, 43);
            this.toDateLabel.Name = "toDateLabel";
            this.toDateLabel.Size = new System.Drawing.Size(35, 20);
            this.toDateLabel.TabIndex = 0;
            this.toDateLabel.Text = "To: ";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 473);
            this.Controls.Add(this.backgroundPanel);
            this.MaximumSize = new System.Drawing.Size(661, 473);
            this.Name = "TransactionForm";
            this.Text = "Super shop";
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.ListView transactionListView;
        private MetroFramework.Controls.MetroButton viewMetroButton;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label toDateLabel;
        private System.Windows.Forms.ColumnHeader slNocolumnHeader;
        private System.Windows.Forms.ColumnHeader dateColumnHeader;
        private System.Windows.Forms.ColumnHeader incomeColumnHeader;
        private System.Windows.Forms.ColumnHeader expenseColumnHeader;
        private System.Windows.Forms.Label profitLabel;
    }
}