namespace ShopManagement.GUI
{
    partial class LoginForm
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
            this.loginMetroButton = new MetroFramework.Controls.MetroButton();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.forgotPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.resetMetroButton = new MetroFramework.Controls.MetroButton();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.centerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginMetroButton
            // 
            this.loginMetroButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.loginMetroButton.Highlight = true;
            this.loginMetroButton.Location = new System.Drawing.Point(745, 402);
            this.loginMetroButton.Name = "loginMetroButton";
            this.loginMetroButton.Size = new System.Drawing.Size(83, 44);
            this.loginMetroButton.TabIndex = 2;
            this.loginMetroButton.Text = "Login";
            this.loginMetroButton.UseSelectable = true;
            this.loginMetroButton.Click += new System.EventHandler(this.loginMetroButton_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.SystemColors.Control;
            this.centerPanel.BackgroundImage = global::ShopManagement.Properties.Resources.Background;
            this.centerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.centerPanel.Controls.Add(this.forgotPasswordLinkLabel);
            this.centerPanel.Controls.Add(this.loginMetroButton);
            this.centerPanel.Controls.Add(this.resetMetroButton);
            this.centerPanel.Controls.Add(this.passwordTextBox);
            this.centerPanel.Controls.Add(this.usernameTextBox);
            this.centerPanel.Controls.Add(this.passwordLabel);
            this.centerPanel.Controls.Add(this.userNameLabel);
            this.centerPanel.Controls.Add(this.welcomeLabel);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(20, 60);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(1324, 656);
            this.centerPanel.TabIndex = 1;
            // 
            // forgotPasswordLinkLabel
            // 
            this.forgotPasswordLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forgotPasswordLinkLabel.AutoSize = true;
            this.forgotPasswordLinkLabel.DisabledLinkColor = System.Drawing.Color.Red;
            this.forgotPasswordLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordLinkLabel.ForeColor = System.Drawing.Color.Red;
            this.forgotPasswordLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.forgotPasswordLinkLabel.LinkColor = System.Drawing.Color.Red;
            this.forgotPasswordLinkLabel.LinkVisited = true;
            this.forgotPasswordLinkLabel.Location = new System.Drawing.Point(712, 468);
            this.forgotPasswordLinkLabel.Name = "forgotPasswordLinkLabel";
            this.forgotPasswordLinkLabel.Size = new System.Drawing.Size(116, 16);
            this.forgotPasswordLinkLabel.TabIndex = 4;
            this.forgotPasswordLinkLabel.TabStop = true;
            this.forgotPasswordLinkLabel.Text = "Forgot password?";
            this.forgotPasswordLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.forgotPasswordLinkLabel.VisitedLinkColor = System.Drawing.Color.Red;
            this.forgotPasswordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPasswordLinkLabel_LinkClicked);
            // 
            // resetMetroButton
            // 
            this.resetMetroButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.resetMetroButton.Highlight = true;
            this.resetMetroButton.Location = new System.Drawing.Point(644, 402);
            this.resetMetroButton.Name = "resetMetroButton";
            this.resetMetroButton.Size = new System.Drawing.Size(83, 44);
            this.resetMetroButton.TabIndex = 3;
            this.resetMetroButton.Text = "Reset";
            this.resetMetroButton.UseSelectable = true;
            this.resetMetroButton.Click += new System.EventHandler(this.resetMetroButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(606, 349);
            this.passwordTextBox.MaxLength = 100;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(222, 25);
            this.passwordTextBox.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(606, 282);
            this.usernameTextBox.MaxLength = 100;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(222, 25);
            this.usernameTextBox.TabIndex = 0;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.passwordLabel.Location = new System.Drawing.Point(489, 347);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(102, 24);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password: ";
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.userNameLabel.Location = new System.Drawing.Point(480, 282);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(112, 24);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "User name: ";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Black;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.welcomeLabel.Location = new System.Drawing.Point(569, 30);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(180, 42);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginMetroButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.centerPanel);
            this.MaximumSize = new System.Drawing.Size(1364, 736);
            this.Name = "LoginForm";
            this.Text = "Super shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.centerPanel.ResumeLayout(false);
            this.centerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private MetroFramework.Controls.MetroButton loginMetroButton;
        private MetroFramework.Controls.MetroButton resetMetroButton;
        private System.Windows.Forms.LinkLabel forgotPasswordLinkLabel;




    }
}