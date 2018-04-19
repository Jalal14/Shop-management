namespace ShopManagement.GUI
{
    partial class EditInformationForm
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
            this.informationGroupBox = new System.Windows.Forms.GroupBox();
            this.changePassMetroButton = new MetroFramework.Controls.MetroButton();
            this.genderLabel = new System.Windows.Forms.Label();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.backMetroButton = new MetroFramework.Controls.MetroButton();
            this.dOBMetroDateTime = new MetroFramework.Controls.MetroDateTime();
            this.submitMetroButton = new MetroFramework.Controls.MetroButton();
            this.resetMetroButton = new MetroFramework.Controls.MetroButton();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.secureAnswerTextBox = new System.Windows.Forms.TextBox();
            this.sequrityQuestionTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.secureAnsLabel = new System.Windows.Forms.Label();
            this.sequrityQuesLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.dOBLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.informationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // informationGroupBox
            // 
            this.informationGroupBox.BackgroundImage = global::ShopManagement.Properties.Resources.Background;
            this.informationGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.informationGroupBox.Controls.Add(this.changePassMetroButton);
            this.informationGroupBox.Controls.Add(this.genderLabel);
            this.informationGroupBox.Controls.Add(this.femaleRadioButton);
            this.informationGroupBox.Controls.Add(this.maleRadioButton);
            this.informationGroupBox.Controls.Add(this.backMetroButton);
            this.informationGroupBox.Controls.Add(this.dOBMetroDateTime);
            this.informationGroupBox.Controls.Add(this.submitMetroButton);
            this.informationGroupBox.Controls.Add(this.resetMetroButton);
            this.informationGroupBox.Controls.Add(this.confirmPasswordTextBox);
            this.informationGroupBox.Controls.Add(this.passwordTextBox);
            this.informationGroupBox.Controls.Add(this.secureAnswerTextBox);
            this.informationGroupBox.Controls.Add(this.sequrityQuestionTextBox);
            this.informationGroupBox.Controls.Add(this.emailTextBox);
            this.informationGroupBox.Controls.Add(this.lastNameTextBox);
            this.informationGroupBox.Controls.Add(this.firstNameTextBox);
            this.informationGroupBox.Controls.Add(this.confirmPasswordLabel);
            this.informationGroupBox.Controls.Add(this.oldPasswordLabel);
            this.informationGroupBox.Controls.Add(this.secureAnsLabel);
            this.informationGroupBox.Controls.Add(this.sequrityQuesLabel);
            this.informationGroupBox.Controls.Add(this.emailLabel);
            this.informationGroupBox.Controls.Add(this.dOBLabel);
            this.informationGroupBox.Controls.Add(this.lastNameLabel);
            this.informationGroupBox.Controls.Add(this.firstNameLabel);
            this.informationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationGroupBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.informationGroupBox.Location = new System.Drawing.Point(20, 60);
            this.informationGroupBox.Name = "informationGroupBox";
            this.informationGroupBox.Size = new System.Drawing.Size(1324, 656);
            this.informationGroupBox.TabIndex = 0;
            this.informationGroupBox.TabStop = false;
            this.informationGroupBox.Text = "Information";
            // 
            // changePassMetroButton
            // 
            this.changePassMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changePassMetroButton.BackColor = System.Drawing.Color.White;
            this.changePassMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.changePassMetroButton.Location = new System.Drawing.Point(1100, 34);
            this.changePassMetroButton.Name = "changePassMetroButton";
            this.changePassMetroButton.Size = new System.Drawing.Size(163, 42);
            this.changePassMetroButton.TabIndex = 24;
            this.changePassMetroButton.Text = "Change password";
            this.changePassMetroButton.UseSelectable = true;
            this.changePassMetroButton.Click += new System.EventHandler(this.changePassMetroButton_Click);
            // 
            // genderLabel
            // 
            this.genderLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.genderLabel.AutoSize = true;
            this.genderLabel.BackColor = System.Drawing.Color.Transparent;
            this.genderLabel.Location = new System.Drawing.Point(20, 452);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(71, 20);
            this.genderLabel.TabIndex = 23;
            this.genderLabel.Text = "Gender: ";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.femaleRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.femaleRadioButton.Location = new System.Drawing.Point(251, 450);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(80, 24);
            this.femaleRadioButton.TabIndex = 22;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = false;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.maleRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.maleRadioButton.Location = new System.Drawing.Point(168, 450);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(61, 24);
            this.maleRadioButton.TabIndex = 22;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = false;
            // 
            // backMetroButton
            // 
            this.backMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.backMetroButton.Location = new System.Drawing.Point(1000, 550);
            this.backMetroButton.Name = "backMetroButton";
            this.backMetroButton.Size = new System.Drawing.Size(75, 44);
            this.backMetroButton.TabIndex = 21;
            this.backMetroButton.Text = "Back";
            this.backMetroButton.UseSelectable = true;
            this.backMetroButton.Click += new System.EventHandler(this.backMetroButton_Click);
            // 
            // dOBMetroDateTime
            // 
            this.dOBMetroDateTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dOBMetroDateTime.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dOBMetroDateTime.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dOBMetroDateTime.CustomFormat = "MMMM dd, yyyy";
            this.dOBMetroDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dOBMetroDateTime.Location = new System.Drawing.Point(168, 152);
            this.dOBMetroDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dOBMetroDateTime.Name = "dOBMetroDateTime";
            this.dOBMetroDateTime.Size = new System.Drawing.Size(222, 29);
            this.dOBMetroDateTime.TabIndex = 4;
            // 
            // submitMetroButton
            // 
            this.submitMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.submitMetroButton.Location = new System.Drawing.Point(1200, 550);
            this.submitMetroButton.Name = "submitMetroButton";
            this.submitMetroButton.Size = new System.Drawing.Size(75, 44);
            this.submitMetroButton.TabIndex = 11;
            this.submitMetroButton.Text = "Submit";
            this.submitMetroButton.UseSelectable = true;
            this.submitMetroButton.Click += new System.EventHandler(this.submitMetroButton_Click);
            // 
            // resetMetroButton
            // 
            this.resetMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.resetMetroButton.Location = new System.Drawing.Point(1100, 550);
            this.resetMetroButton.Name = "resetMetroButton";
            this.resetMetroButton.Size = new System.Drawing.Size(75, 44);
            this.resetMetroButton.TabIndex = 12;
            this.resetMetroButton.Text = "Reset";
            this.resetMetroButton.UseSelectable = true;
            this.resetMetroButton.Click += new System.EventHandler(this.resetMetroButton_Click);
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(168, 408);
            this.confirmPasswordTextBox.MaxLength = 100;
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '*';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(371, 26);
            this.confirmPasswordTextBox.TabIndex = 10;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordTextBox.Location = new System.Drawing.Point(168, 352);
            this.passwordTextBox.MaxLength = 100;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(371, 26);
            this.passwordTextBox.TabIndex = 8;
            // 
            // secureAnswerTextBox
            // 
            this.secureAnswerTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.secureAnswerTextBox.Location = new System.Drawing.Point(168, 302);
            this.secureAnswerTextBox.Name = "secureAnswerTextBox";
            this.secureAnswerTextBox.Size = new System.Drawing.Size(371, 26);
            this.secureAnswerTextBox.TabIndex = 7;
            // 
            // sequrityQuestionTextBox
            // 
            this.sequrityQuestionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sequrityQuestionTextBox.Location = new System.Drawing.Point(168, 252);
            this.sequrityQuestionTextBox.MaxLength = 100;
            this.sequrityQuestionTextBox.Name = "sequrityQuestionTextBox";
            this.sequrityQuestionTextBox.Size = new System.Drawing.Size(371, 26);
            this.sequrityQuestionTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailTextBox.Location = new System.Drawing.Point(168, 202);
            this.emailTextBox.MaxLength = 100;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(371, 26);
            this.emailTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lastNameTextBox.Location = new System.Drawing.Point(168, 100);
            this.lastNameTextBox.MaxLength = 100;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(267, 26);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.firstNameTextBox.Location = new System.Drawing.Point(168, 50);
            this.firstNameTextBox.MaxLength = 100;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(267, 26);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(15, 408);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(106, 20);
            this.confirmPasswordLabel.TabIndex = 18;
            this.confirmPasswordLabel.Text = "Confirm pass:";
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.oldPasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oldPasswordLabel.Location = new System.Drawing.Point(15, 352);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(82, 20);
            this.oldPasswordLabel.TabIndex = 17;
            this.oldPasswordLabel.Text = "Password:";
            // 
            // secureAnsLabel
            // 
            this.secureAnsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.secureAnsLabel.AutoSize = true;
            this.secureAnsLabel.BackColor = System.Drawing.Color.Transparent;
            this.secureAnsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.secureAnsLabel.Location = new System.Drawing.Point(15, 302);
            this.secureAnsLabel.Name = "secureAnsLabel";
            this.secureAnsLabel.Size = new System.Drawing.Size(119, 20);
            this.secureAnsLabel.TabIndex = 16;
            this.secureAnsLabel.Text = "Secure answer:";
            // 
            // sequrityQuesLabel
            // 
            this.sequrityQuesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sequrityQuesLabel.AutoSize = true;
            this.sequrityQuesLabel.BackColor = System.Drawing.Color.Transparent;
            this.sequrityQuesLabel.Location = new System.Drawing.Point(15, 252);
            this.sequrityQuesLabel.Name = "sequrityQuesLabel";
            this.sequrityQuesLabel.Size = new System.Drawing.Size(136, 20);
            this.sequrityQuesLabel.TabIndex = 15;
            this.sequrityQuesLabel.Text = "Sequrity question:";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Location = new System.Drawing.Point(15, 202);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(52, 20);
            this.emailLabel.TabIndex = 14;
            this.emailLabel.Text = "Email:";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dOBLabel
            // 
            this.dOBLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dOBLabel.AutoSize = true;
            this.dOBLabel.BackColor = System.Drawing.Color.Transparent;
            this.dOBLabel.Location = new System.Drawing.Point(15, 152);
            this.dOBLabel.Name = "dOBLabel";
            this.dOBLabel.Size = new System.Drawing.Size(56, 20);
            this.dOBLabel.TabIndex = 13;
            this.dOBLabel.Text = "D.O.B:";
            this.dOBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLabel.Location = new System.Drawing.Point(15, 100);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.lastNameLabel.TabIndex = 20;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.firstNameLabel.Location = new System.Drawing.Point(15, 50);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(90, 20);
            this.firstNameLabel.TabIndex = 11;
            this.firstNameLabel.Text = "First Name:";
            // 
            // EditInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.informationGroupBox);
            this.Name = "EditInformationForm";
            this.Text = "Super shop";
            this.Load += new System.EventHandler(this.EditInformationForm_Load);
            this.informationGroupBox.ResumeLayout(false);
            this.informationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox informationGroupBox;
        private MetroFramework.Controls.MetroDateTime dOBMetroDateTime;
        private MetroFramework.Controls.MetroButton submitMetroButton;
        private MetroFramework.Controls.MetroButton resetMetroButton;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox secureAnswerTextBox;
        private System.Windows.Forms.TextBox sequrityQuestionTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label oldPasswordLabel;
        private System.Windows.Forms.Label secureAnsLabel;
        private System.Windows.Forms.Label sequrityQuesLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label dOBLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private MetroFramework.Controls.MetroButton backMetroButton;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private MetroFramework.Controls.MetroButton changePassMetroButton;
    }
}