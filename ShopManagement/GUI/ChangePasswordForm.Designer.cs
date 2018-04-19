namespace ShopManagement.GUI
{
    partial class ChangePasswordForm
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
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.submitMetroButton = new MetroFramework.Controls.MetroButton();
            this.resetMetroButton = new MetroFramework.Controls.MetroButton();
            this.backgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackgroundImage = global::ShopManagement.Properties.Resources.Background;
            this.backgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPanel.Controls.Add(this.submitMetroButton);
            this.backgroundPanel.Controls.Add(this.resetMetroButton);
            this.backgroundPanel.Controls.Add(this.confirmPasswordTextBox);
            this.backgroundPanel.Controls.Add(this.newPasswordTextBox);
            this.backgroundPanel.Controls.Add(this.confirmPasswordLabel);
            this.backgroundPanel.Controls.Add(this.oldPasswordTextBox);
            this.backgroundPanel.Controls.Add(this.newPasswordLabel);
            this.backgroundPanel.Controls.Add(this.oldPasswordLabel);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(20, 60);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(472, 297);
            this.backgroundPanel.TabIndex = 0;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.newPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordTextBox.Location = new System.Drawing.Point(148, 113);
            this.newPasswordTextBox.MaxLength = 100;
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '*';
            this.newPasswordTextBox.Size = new System.Drawing.Size(269, 22);
            this.newPasswordTextBox.TabIndex = 20;
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.oldPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasswordTextBox.Location = new System.Drawing.Point(148, 55);
            this.oldPasswordTextBox.MaxLength = 100;
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.PasswordChar = '*';
            this.oldPasswordTextBox.Size = new System.Drawing.Size(269, 22);
            this.oldPasswordTextBox.TabIndex = 19;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.newPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newPasswordLabel.Location = new System.Drawing.Point(18, 116);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(71, 16);
            this.newPasswordLabel.TabIndex = 22;
            this.newPasswordLabel.Text = "New pass:";
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.oldPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oldPasswordLabel.Location = new System.Drawing.Point(18, 55);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(94, 16);
            this.oldPasswordLabel.TabIndex = 21;
            this.oldPasswordLabel.Text = "Old password:";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(18, 174);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(121, 16);
            this.confirmPasswordLabel.TabIndex = 22;
            this.confirmPasswordLabel.Text = "Confirm password: ";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(148, 171);
            this.confirmPasswordTextBox.MaxLength = 100;
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '*';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(269, 22);
            this.confirmPasswordTextBox.TabIndex = 20;
            // 
            // submitMetroButton
            // 
            this.submitMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.submitMetroButton.Location = new System.Drawing.Point(382, 237);
            this.submitMetroButton.Name = "submitMetroButton";
            this.submitMetroButton.Size = new System.Drawing.Size(75, 44);
            this.submitMetroButton.TabIndex = 23;
            this.submitMetroButton.Text = "Submit";
            this.submitMetroButton.UseSelectable = true;
            this.submitMetroButton.Click += new System.EventHandler(this.submitMetroButton_Click);
            // 
            // resetMetroButton
            // 
            this.resetMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.resetMetroButton.Location = new System.Drawing.Point(282, 237);
            this.resetMetroButton.Name = "resetMetroButton";
            this.resetMetroButton.Size = new System.Drawing.Size(75, 44);
            this.resetMetroButton.TabIndex = 24;
            this.resetMetroButton.Text = "Reset";
            this.resetMetroButton.UseSelectable = true;
            this.resetMetroButton.Click += new System.EventHandler(this.resetMetroButton_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 377);
            this.Controls.Add(this.backgroundPanel);
            this.Name = "ChangePasswordForm";
            this.Text = "Super shop";
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox oldPasswordTextBox;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label oldPasswordLabel;
        private MetroFramework.Controls.MetroButton submitMetroButton;
        private MetroFramework.Controls.MetroButton resetMetroButton;
    }
}