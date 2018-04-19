namespace ShopManagement.GUI
{
    partial class NotificationForm
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
            this.notificationSplitContainer = new System.Windows.Forms.SplitContainer();
            this.notificationListGroupBox = new System.Windows.Forms.GroupBox();
            this.notificationListMetroListView = new MetroFramework.Controls.MetroListView();
            this.seriallNoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.detailsGroupBox = new System.Windows.Forms.GroupBox();
            this.backMetroButton = new MetroFramework.Controls.MetroButton();
            this.acceptMetroButton = new MetroFramework.Controls.MetroButton();
            this.rejectMetroButton = new MetroFramework.Controls.MetroButton();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.dOBTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstaNameTextBox = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.dOBLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastaNamelabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notificationSplitContainer)).BeginInit();
            this.notificationSplitContainer.Panel1.SuspendLayout();
            this.notificationSplitContainer.Panel2.SuspendLayout();
            this.notificationSplitContainer.SuspendLayout();
            this.notificationListGroupBox.SuspendLayout();
            this.detailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackgroundImage = global::ShopManagement.Properties.Resources.Background;
            this.backgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPanel.Controls.Add(this.notificationSplitContainer);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(20, 60);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(1284, 576);
            this.backgroundPanel.TabIndex = 0;
            // 
            // notificationSplitContainer
            // 
            this.notificationSplitContainer.BackColor = System.Drawing.Color.Transparent;
            this.notificationSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.notificationSplitContainer.Name = "notificationSplitContainer";
            // 
            // notificationSplitContainer.Panel1
            // 
            this.notificationSplitContainer.Panel1.Controls.Add(this.notificationListGroupBox);
            // 
            // notificationSplitContainer.Panel2
            // 
            this.notificationSplitContainer.Panel2.Controls.Add(this.detailsGroupBox);
            this.notificationSplitContainer.Size = new System.Drawing.Size(1284, 576);
            this.notificationSplitContainer.SplitterDistance = 410;
            this.notificationSplitContainer.TabIndex = 2;
            // 
            // notificationListGroupBox
            // 
            this.notificationListGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.notificationListGroupBox.Controls.Add(this.notificationListMetroListView);
            this.notificationListGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationListGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationListGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.notificationListGroupBox.Location = new System.Drawing.Point(0, 0);
            this.notificationListGroupBox.Name = "notificationListGroupBox";
            this.notificationListGroupBox.Size = new System.Drawing.Size(410, 576);
            this.notificationListGroupBox.TabIndex = 0;
            this.notificationListGroupBox.TabStop = false;
            this.notificationListGroupBox.Text = "Notifications";
            // 
            // notificationListMetroListView
            // 
            this.notificationListMetroListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.seriallNoColumnHeader,
            this.typeColumnHeader});
            this.notificationListMetroListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationListMetroListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.notificationListMetroListView.FullRowSelect = true;
            this.notificationListMetroListView.GridLines = true;
            this.notificationListMetroListView.Location = new System.Drawing.Point(3, 18);
            this.notificationListMetroListView.Name = "notificationListMetroListView";
            this.notificationListMetroListView.OwnerDraw = true;
            this.notificationListMetroListView.Size = new System.Drawing.Size(404, 555);
            this.notificationListMetroListView.TabIndex = 0;
            this.notificationListMetroListView.UseCompatibleStateImageBehavior = false;
            this.notificationListMetroListView.UseSelectable = true;
            this.notificationListMetroListView.View = System.Windows.Forms.View.Details;
            this.notificationListMetroListView.Click += new System.EventHandler(this.notificationListMetroListView_SelectedIndexChanged);
            // 
            // seriallNoColumnHeader
            // 
            this.seriallNoColumnHeader.Text = "Sl no";
            this.seriallNoColumnHeader.Width = 135;
            // 
            // typeColumnHeader
            // 
            this.typeColumnHeader.Text = "Type";
            this.typeColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.typeColumnHeader.Width = 265;
            // 
            // detailsGroupBox
            // 
            this.detailsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.detailsGroupBox.Controls.Add(this.backMetroButton);
            this.detailsGroupBox.Controls.Add(this.acceptMetroButton);
            this.detailsGroupBox.Controls.Add(this.rejectMetroButton);
            this.detailsGroupBox.Controls.Add(this.genderTextBox);
            this.detailsGroupBox.Controls.Add(this.dOBTextBox);
            this.detailsGroupBox.Controls.Add(this.emailTextBox);
            this.detailsGroupBox.Controls.Add(this.lastNameTextBox);
            this.detailsGroupBox.Controls.Add(this.firstaNameTextBox);
            this.detailsGroupBox.Controls.Add(this.genderLabel);
            this.detailsGroupBox.Controls.Add(this.dOBLabel);
            this.detailsGroupBox.Controls.Add(this.emailLabel);
            this.detailsGroupBox.Controls.Add(this.lastaNamelabel);
            this.detailsGroupBox.Controls.Add(this.firstNameLabel);
            this.detailsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.detailsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.detailsGroupBox.Name = "detailsGroupBox";
            this.detailsGroupBox.Size = new System.Drawing.Size(870, 576);
            this.detailsGroupBox.TabIndex = 0;
            this.detailsGroupBox.TabStop = false;
            this.detailsGroupBox.Text = "Details";
            // 
            // backMetroButton
            // 
            this.backMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.backMetroButton.Location = new System.Drawing.Point(435, 457);
            this.backMetroButton.Name = "backMetroButton";
            this.backMetroButton.Size = new System.Drawing.Size(75, 44);
            this.backMetroButton.TabIndex = 0;
            this.backMetroButton.Text = "Back";
            this.backMetroButton.UseSelectable = true;
            this.backMetroButton.Click += new System.EventHandler(this.backMetroButton_Click);
            // 
            // acceptMetroButton
            // 
            this.acceptMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.acceptMetroButton.Location = new System.Drawing.Point(635, 457);
            this.acceptMetroButton.Name = "acceptMetroButton";
            this.acceptMetroButton.Size = new System.Drawing.Size(75, 44);
            this.acceptMetroButton.TabIndex = 2;
            this.acceptMetroButton.Text = "Accept";
            this.acceptMetroButton.UseSelectable = true;
            this.acceptMetroButton.Click += new System.EventHandler(this.acceptMetroButton_Click);
            // 
            // rejectMetroButton
            // 
            this.rejectMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rejectMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.rejectMetroButton.Location = new System.Drawing.Point(535, 457);
            this.rejectMetroButton.Name = "rejectMetroButton";
            this.rejectMetroButton.Size = new System.Drawing.Size(75, 44);
            this.rejectMetroButton.TabIndex = 2;
            this.rejectMetroButton.Text = "Reject";
            this.rejectMetroButton.UseSelectable = true;
            this.rejectMetroButton.Click += new System.EventHandler(this.rejectMetroButton_Click);
            // 
            // genderTextBox
            // 
            this.genderTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderTextBox.Location = new System.Drawing.Point(150, 300);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.ReadOnly = true;
            this.genderTextBox.Size = new System.Drawing.Size(148, 22);
            this.genderTextBox.TabIndex = 1;
            // 
            // dOBTextBox
            // 
            this.dOBTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dOBTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dOBTextBox.Location = new System.Drawing.Point(150, 250);
            this.dOBTextBox.Name = "dOBTextBox";
            this.dOBTextBox.ReadOnly = true;
            this.dOBTextBox.Size = new System.Drawing.Size(148, 22);
            this.dOBTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(150, 200);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(344, 22);
            this.emailTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(150, 150);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(344, 22);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // firstaNameTextBox
            // 
            this.firstaNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstaNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstaNameTextBox.Location = new System.Drawing.Point(150, 100);
            this.firstaNameTextBox.Name = "firstaNameTextBox";
            this.firstaNameTextBox.ReadOnly = true;
            this.firstaNameTextBox.Size = new System.Drawing.Size(344, 22);
            this.firstaNameTextBox.TabIndex = 1;
            // 
            // genderLabel
            // 
            this.genderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.genderLabel.Location = new System.Drawing.Point(50, 300);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(56, 16);
            this.genderLabel.TabIndex = 0;
            this.genderLabel.Text = "Gender:";
            // 
            // dOBLabel
            // 
            this.dOBLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dOBLabel.AutoSize = true;
            this.dOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dOBLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dOBLabel.Location = new System.Drawing.Point(50, 250);
            this.dOBLabel.Name = "dOBLabel";
            this.dOBLabel.Size = new System.Drawing.Size(46, 16);
            this.dOBLabel.TabIndex = 0;
            this.dOBLabel.Text = "D.O.B:";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailLabel.Location = new System.Drawing.Point(50, 200);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(45, 16);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email:";
            // 
            // lastaNamelabel
            // 
            this.lastaNamelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastaNamelabel.AutoSize = true;
            this.lastaNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastaNamelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastaNamelabel.Location = new System.Drawing.Point(50, 150);
            this.lastaNamelabel.Name = "lastaNamelabel";
            this.lastaNamelabel.Size = new System.Drawing.Size(73, 16);
            this.lastaNamelabel.TabIndex = 0;
            this.lastaNamelabel.Text = "Last name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstNameLabel.Location = new System.Drawing.Point(50, 100);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(76, 16);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 656);
            this.Controls.Add(this.backgroundPanel);
            this.MinimumSize = new System.Drawing.Size(1324, 656);
            this.Name = "NotificationForm";
            this.Text = "Super shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            this.backgroundPanel.ResumeLayout(false);
            this.notificationSplitContainer.Panel1.ResumeLayout(false);
            this.notificationSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notificationSplitContainer)).EndInit();
            this.notificationSplitContainer.ResumeLayout(false);
            this.notificationListGroupBox.ResumeLayout(false);
            this.detailsGroupBox.ResumeLayout(false);
            this.detailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.SplitContainer notificationSplitContainer;
        private System.Windows.Forms.GroupBox notificationListGroupBox;
        private MetroFramework.Controls.MetroListView notificationListMetroListView;
        private System.Windows.Forms.ColumnHeader seriallNoColumnHeader;
        private System.Windows.Forms.ColumnHeader typeColumnHeader;
        private System.Windows.Forms.GroupBox detailsGroupBox;
        private MetroFramework.Controls.MetroButton acceptMetroButton;
        private MetroFramework.Controls.MetroButton rejectMetroButton;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox dOBTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstaNameTextBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label dOBLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastaNamelabel;
        private System.Windows.Forms.Label firstNameLabel;
        private MetroFramework.Controls.MetroButton backMetroButton;
    }
}