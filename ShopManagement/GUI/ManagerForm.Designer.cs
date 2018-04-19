namespace ShopManagement.GUI
{
    partial class ManagerForm
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
            this.signUpGroupBox = new System.Windows.Forms.GroupBox();
            this.submitMetroButton = new MetroFramework.Controls.MetroButton();
            this.resetMetroButton = new MetroFramework.Controls.MetroButton();
            this.dOBMetroDateTime = new MetroFramework.Controls.MetroDateTime();
            this.femaleMetroRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.maleMetroRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.secureAnswerTextBox = new System.Windows.Forms.TextBox();
            this.sequrityQuestionTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.secureAnsLabel = new System.Windows.Forms.Label();
            this.sequrityQuesLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.dOBLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.salesmanMetroRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.adminMetroRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.deleteUserGroupBox = new System.Windows.Forms.GroupBox();
            this.submitMetroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.resetMetroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.salesmanNameTextBoxDelete = new System.Windows.Forms.TextBox();
            this.confirmManagerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.managerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.managerAdminPasswordLabel = new System.Windows.Forms.Label();
            this.managerPasswordLabel = new System.Windows.Forms.Label();
            this.salesmanUsernameLabelDelete = new System.Windows.Forms.Label();
            this.userListGroupBox = new System.Windows.Forms.GroupBox();
            this.showAllMetroButton = new MetroFramework.Controls.MetroButton();
            this.userListMetroListView = new MetroFramework.Controls.MetroListView();
            this.slNoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salesmanNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.warningLabel = new System.Windows.Forms.Label();
            this.transactionMetroButton = new MetroFramework.Controls.MetroButton();
            this.editInfoMetroButton = new MetroFramework.Controls.MetroButton();
            this.logoutMetroButton = new MetroFramework.Controls.MetroButton();
            this.managerLabel = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerSplitContainer)).BeginInit();
            this.centerSplitContainer.Panel1.SuspendLayout();
            this.centerSplitContainer.Panel2.SuspendLayout();
            this.centerSplitContainer.SuspendLayout();
            this.signUpGroupBox.SuspendLayout();
            this.deleteUserGroupBox.SuspendLayout();
            this.userListGroupBox.SuspendLayout();
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
            this.backgroundPanel.Controls.Add(this.rightPanel);
            this.backgroundPanel.Controls.Add(this.bottomPanel);
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
            this.centerSplitContainer.Location = new System.Drawing.Point(21, 64);
            this.centerSplitContainer.Name = "centerSplitContainer";
            // 
            // centerSplitContainer.Panel1
            // 
            this.centerSplitContainer.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.centerSplitContainer.Panel1.Controls.Add(this.signUpGroupBox);
            this.centerSplitContainer.Panel1.Controls.Add(this.salesmanMetroRadioButton);
            this.centerSplitContainer.Panel1.Controls.Add(this.adminMetroRadioButton);
            // 
            // centerSplitContainer.Panel2
            // 
            this.centerSplitContainer.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.centerSplitContainer.Panel2.Controls.Add(this.deleteUserGroupBox);
            this.centerSplitContainer.Panel2.Controls.Add(this.userListGroupBox);
            this.centerSplitContainer.Size = new System.Drawing.Size(1282, 579);
            this.centerSplitContainer.SplitterDistance = 633;
            this.centerSplitContainer.TabIndex = 14;
            // 
            // signUpGroupBox
            // 
            this.signUpGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.signUpGroupBox.Controls.Add(this.submitMetroButton);
            this.signUpGroupBox.Controls.Add(this.resetMetroButton);
            this.signUpGroupBox.Controls.Add(this.dOBMetroDateTime);
            this.signUpGroupBox.Controls.Add(this.femaleMetroRadioButton);
            this.signUpGroupBox.Controls.Add(this.maleMetroRadioButton);
            this.signUpGroupBox.Controls.Add(this.confirmPasswordTextBox);
            this.signUpGroupBox.Controls.Add(this.passwordTextBox);
            this.signUpGroupBox.Controls.Add(this.secureAnswerTextBox);
            this.signUpGroupBox.Controls.Add(this.sequrityQuestionTextBox);
            this.signUpGroupBox.Controls.Add(this.emailTextBox);
            this.signUpGroupBox.Controls.Add(this.userNameTextBox);
            this.signUpGroupBox.Controls.Add(this.lastNameTextBox);
            this.signUpGroupBox.Controls.Add(this.firstNameTextBox);
            this.signUpGroupBox.Controls.Add(this.passwordLabel);
            this.signUpGroupBox.Controls.Add(this.genderLabel);
            this.signUpGroupBox.Controls.Add(this.confirmPasswordLabel);
            this.signUpGroupBox.Controls.Add(this.secureAnsLabel);
            this.signUpGroupBox.Controls.Add(this.sequrityQuesLabel);
            this.signUpGroupBox.Controls.Add(this.emailLabel);
            this.signUpGroupBox.Controls.Add(this.dOBLabel);
            this.signUpGroupBox.Controls.Add(this.userNameLabel);
            this.signUpGroupBox.Controls.Add(this.lastNameLabel);
            this.signUpGroupBox.Controls.Add(this.firstNameLabel);
            this.signUpGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.signUpGroupBox.Location = new System.Drawing.Point(8, 83);
            this.signUpGroupBox.Name = "signUpGroupBox";
            this.signUpGroupBox.Size = new System.Drawing.Size(603, 460);
            this.signUpGroupBox.TabIndex = 1;
            this.signUpGroupBox.TabStop = false;
            this.signUpGroupBox.Text = "Sign up";
            // 
            // submitMetroButton
            // 
            this.submitMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.submitMetroButton.Location = new System.Drawing.Point(500, 400);
            this.submitMetroButton.Name = "submitMetroButton";
            this.submitMetroButton.Size = new System.Drawing.Size(75, 44);
            this.submitMetroButton.TabIndex = 40;
            this.submitMetroButton.Text = "Submit";
            this.submitMetroButton.UseSelectable = true;
            this.submitMetroButton.Click += new System.EventHandler(this.submitMetroButton_Click);
            // 
            // resetMetroButton
            // 
            this.resetMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.resetMetroButton.Location = new System.Drawing.Point(400, 400);
            this.resetMetroButton.Name = "resetMetroButton";
            this.resetMetroButton.Size = new System.Drawing.Size(75, 44);
            this.resetMetroButton.TabIndex = 41;
            this.resetMetroButton.Text = "Reset";
            this.resetMetroButton.UseSelectable = true;
            this.resetMetroButton.Click += new System.EventHandler(this.resetMetroButton_Click);
            // 
            // dOBMetroDateTime
            // 
            this.dOBMetroDateTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dOBMetroDateTime.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dOBMetroDateTime.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dOBMetroDateTime.CustomFormat = "MMMM dd, yyyy";
            this.dOBMetroDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dOBMetroDateTime.Location = new System.Drawing.Point(140, 150);
            this.dOBMetroDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dOBMetroDateTime.Name = "dOBMetroDateTime";
            this.dOBMetroDateTime.Size = new System.Drawing.Size(175, 29);
            this.dOBMetroDateTime.TabIndex = 34;
            // 
            // femaleMetroRadioButton
            // 
            this.femaleMetroRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.femaleMetroRadioButton.AutoSize = true;
            this.femaleMetroRadioButton.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.femaleMetroRadioButton.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.femaleMetroRadioButton.ForeColor = System.Drawing.Color.Transparent;
            this.femaleMetroRadioButton.Location = new System.Drawing.Point(217, 390);
            this.femaleMetroRadioButton.Name = "femaleMetroRadioButton";
            this.femaleMetroRadioButton.Size = new System.Drawing.Size(73, 19);
            this.femaleMetroRadioButton.TabIndex = 0;
            this.femaleMetroRadioButton.Text = "Female";
            this.femaleMetroRadioButton.UseSelectable = true;
            // 
            // maleMetroRadioButton
            // 
            this.maleMetroRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maleMetroRadioButton.AutoSize = true;
            this.maleMetroRadioButton.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.maleMetroRadioButton.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.maleMetroRadioButton.ForeColor = System.Drawing.Color.Transparent;
            this.maleMetroRadioButton.Location = new System.Drawing.Point(140, 390);
            this.maleMetroRadioButton.Name = "maleMetroRadioButton";
            this.maleMetroRadioButton.Size = new System.Drawing.Size(58, 19);
            this.maleMetroRadioButton.TabIndex = 0;
            this.maleMetroRadioButton.Text = "Male";
            this.maleMetroRadioButton.UseSelectable = true;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(140, 350);
            this.confirmPasswordTextBox.MaxLength = 100;
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '*';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(308, 22);
            this.confirmPasswordTextBox.TabIndex = 38;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordTextBox.Location = new System.Drawing.Point(140, 310);
            this.passwordTextBox.MaxLength = 100;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(308, 22);
            this.passwordTextBox.TabIndex = 39;
            // 
            // secureAnswerTextBox
            // 
            this.secureAnswerTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.secureAnswerTextBox.Location = new System.Drawing.Point(140, 270);
            this.secureAnswerTextBox.Name = "secureAnswerTextBox";
            this.secureAnswerTextBox.Size = new System.Drawing.Size(308, 22);
            this.secureAnswerTextBox.TabIndex = 37;
            // 
            // sequrityQuestionTextBox
            // 
            this.sequrityQuestionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sequrityQuestionTextBox.Location = new System.Drawing.Point(140, 230);
            this.sequrityQuestionTextBox.MaxLength = 100;
            this.sequrityQuestionTextBox.Name = "sequrityQuestionTextBox";
            this.sequrityQuestionTextBox.Size = new System.Drawing.Size(308, 22);
            this.sequrityQuestionTextBox.TabIndex = 36;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailTextBox.Location = new System.Drawing.Point(140, 190);
            this.emailTextBox.MaxLength = 100;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(308, 22);
            this.emailTextBox.TabIndex = 35;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userNameTextBox.Location = new System.Drawing.Point(140, 110);
            this.userNameTextBox.MaxLength = 100;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(248, 22);
            this.userNameTextBox.TabIndex = 33;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lastNameTextBox.Location = new System.Drawing.Point(140, 70);
            this.lastNameTextBox.MaxLength = 100;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(248, 22);
            this.lastNameTextBox.TabIndex = 32;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.firstNameTextBox.Location = new System.Drawing.Point(140, 30);
            this.firstNameTextBox.MaxLength = 100;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(248, 22);
            this.firstNameTextBox.TabIndex = 31;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordLabel.Location = new System.Drawing.Point(15, 310);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(71, 16);
            this.passwordLabel.TabIndex = 27;
            this.passwordLabel.Text = "Password:";
            // 
            // genderLabel
            // 
            this.genderLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.genderLabel.AutoSize = true;
            this.genderLabel.BackColor = System.Drawing.Color.Transparent;
            this.genderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.genderLabel.Location = new System.Drawing.Point(15, 390);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(56, 16);
            this.genderLabel.TabIndex = 29;
            this.genderLabel.Text = "Gender:";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmPasswordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(15, 350);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(118, 16);
            this.confirmPasswordLabel.TabIndex = 29;
            this.confirmPasswordLabel.Text = "Confirm password:";
            // 
            // secureAnsLabel
            // 
            this.secureAnsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.secureAnsLabel.AutoSize = true;
            this.secureAnsLabel.BackColor = System.Drawing.Color.Transparent;
            this.secureAnsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.secureAnsLabel.Location = new System.Drawing.Point(15, 270);
            this.secureAnsLabel.Name = "secureAnsLabel";
            this.secureAnsLabel.Size = new System.Drawing.Size(100, 16);
            this.secureAnsLabel.TabIndex = 26;
            this.secureAnsLabel.Text = "Secure answer:";
            // 
            // sequrityQuesLabel
            // 
            this.sequrityQuesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sequrityQuesLabel.AutoSize = true;
            this.sequrityQuesLabel.BackColor = System.Drawing.Color.Transparent;
            this.sequrityQuesLabel.Location = new System.Drawing.Point(15, 230);
            this.sequrityQuesLabel.Name = "sequrityQuesLabel";
            this.sequrityQuesLabel.Size = new System.Drawing.Size(114, 16);
            this.sequrityQuesLabel.TabIndex = 25;
            this.sequrityQuesLabel.Text = "Sequrity question:";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Location = new System.Drawing.Point(15, 190);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(45, 16);
            this.emailLabel.TabIndex = 24;
            this.emailLabel.Text = "Email:";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dOBLabel
            // 
            this.dOBLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dOBLabel.AutoSize = true;
            this.dOBLabel.BackColor = System.Drawing.Color.Transparent;
            this.dOBLabel.Location = new System.Drawing.Point(15, 150);
            this.dOBLabel.Name = "dOBLabel";
            this.dOBLabel.Size = new System.Drawing.Size(46, 16);
            this.dOBLabel.TabIndex = 23;
            this.dOBLabel.Text = "D.O.B:";
            this.dOBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Location = new System.Drawing.Point(15, 110);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(83, 16);
            this.userNameLabel.TabIndex = 22;
            this.userNameLabel.Text = "User Name: ";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastNameLabel.Location = new System.Drawing.Point(15, 70);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 16);
            this.lastNameLabel.TabIndex = 30;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstNameLabel.Location = new System.Drawing.Point(15, 30);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(76, 16);
            this.firstNameLabel.TabIndex = 21;
            this.firstNameLabel.Text = "First Name:";
            // 
            // salesmanMetroRadioButton
            // 
            this.salesmanMetroRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salesmanMetroRadioButton.AutoSize = true;
            this.salesmanMetroRadioButton.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.salesmanMetroRadioButton.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.salesmanMetroRadioButton.Location = new System.Drawing.Point(380, 42);
            this.salesmanMetroRadioButton.Name = "salesmanMetroRadioButton";
            this.salesmanMetroRadioButton.Size = new System.Drawing.Size(108, 25);
            this.salesmanMetroRadioButton.TabIndex = 0;
            this.salesmanMetroRadioButton.Text = "Salesman";
            this.salesmanMetroRadioButton.UseSelectable = true;
            // 
            // adminMetroRadioButton
            // 
            this.adminMetroRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminMetroRadioButton.AutoSize = true;
            this.adminMetroRadioButton.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.adminMetroRadioButton.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.adminMetroRadioButton.Location = new System.Drawing.Point(278, 42);
            this.adminMetroRadioButton.Name = "adminMetroRadioButton";
            this.adminMetroRadioButton.Size = new System.Drawing.Size(84, 25);
            this.adminMetroRadioButton.TabIndex = 0;
            this.adminMetroRadioButton.Text = "Admin";
            this.adminMetroRadioButton.UseSelectable = true;
            // 
            // deleteUserGroupBox
            // 
            this.deleteUserGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteUserGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteUserGroupBox.Controls.Add(this.submitMetroButtonDelete);
            this.deleteUserGroupBox.Controls.Add(this.resetMetroButtonDelete);
            this.deleteUserGroupBox.Controls.Add(this.salesmanNameTextBoxDelete);
            this.deleteUserGroupBox.Controls.Add(this.confirmManagerPasswordTextBox);
            this.deleteUserGroupBox.Controls.Add(this.managerPasswordTextBox);
            this.deleteUserGroupBox.Controls.Add(this.managerAdminPasswordLabel);
            this.deleteUserGroupBox.Controls.Add(this.managerPasswordLabel);
            this.deleteUserGroupBox.Controls.Add(this.salesmanUsernameLabelDelete);
            this.deleteUserGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserGroupBox.Location = new System.Drawing.Point(104, 318);
            this.deleteUserGroupBox.Name = "deleteUserGroupBox";
            this.deleteUserGroupBox.Size = new System.Drawing.Size(478, 225);
            this.deleteUserGroupBox.TabIndex = 0;
            this.deleteUserGroupBox.TabStop = false;
            this.deleteUserGroupBox.Text = "Delete user";
            // 
            // submitMetroButtonDelete
            // 
            this.submitMetroButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitMetroButtonDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.submitMetroButtonDelete.Location = new System.Drawing.Point(380, 175);
            this.submitMetroButtonDelete.Name = "submitMetroButtonDelete";
            this.submitMetroButtonDelete.Size = new System.Drawing.Size(75, 44);
            this.submitMetroButtonDelete.TabIndex = 42;
            this.submitMetroButtonDelete.Text = "Submit";
            this.submitMetroButtonDelete.UseSelectable = true;
            this.submitMetroButtonDelete.Click += new System.EventHandler(this.submitMetroButtonDelete_Click);
            // 
            // resetMetroButtonDelete
            // 
            this.resetMetroButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetMetroButtonDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.resetMetroButtonDelete.Location = new System.Drawing.Point(280, 175);
            this.resetMetroButtonDelete.Name = "resetMetroButtonDelete";
            this.resetMetroButtonDelete.Size = new System.Drawing.Size(75, 44);
            this.resetMetroButtonDelete.TabIndex = 43;
            this.resetMetroButtonDelete.Text = "Reset";
            this.resetMetroButtonDelete.UseSelectable = true;
            this.resetMetroButtonDelete.Click += new System.EventHandler(this.resetMetroButtonDelete_Click);
            // 
            // salesmanNameTextBoxDelete
            // 
            this.salesmanNameTextBoxDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.salesmanNameTextBoxDelete.Location = new System.Drawing.Point(116, 46);
            this.salesmanNameTextBoxDelete.MaxLength = 100;
            this.salesmanNameTextBoxDelete.Name = "salesmanNameTextBoxDelete";
            this.salesmanNameTextBoxDelete.Size = new System.Drawing.Size(244, 22);
            this.salesmanNameTextBoxDelete.TabIndex = 40;
            // 
            // confirmManagerPasswordTextBox
            // 
            this.confirmManagerPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.confirmManagerPasswordTextBox.Location = new System.Drawing.Point(116, 136);
            this.confirmManagerPasswordTextBox.MaxLength = 100;
            this.confirmManagerPasswordTextBox.Name = "confirmManagerPasswordTextBox";
            this.confirmManagerPasswordTextBox.PasswordChar = '*';
            this.confirmManagerPasswordTextBox.Size = new System.Drawing.Size(244, 22);
            this.confirmManagerPasswordTextBox.TabIndex = 40;
            // 
            // managerPasswordTextBox
            // 
            this.managerPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.managerPasswordTextBox.Location = new System.Drawing.Point(116, 90);
            this.managerPasswordTextBox.MaxLength = 100;
            this.managerPasswordTextBox.Name = "managerPasswordTextBox";
            this.managerPasswordTextBox.PasswordChar = '*';
            this.managerPasswordTextBox.Size = new System.Drawing.Size(244, 22);
            this.managerPasswordTextBox.TabIndex = 41;
            // 
            // managerAdminPasswordLabel
            // 
            this.managerAdminPasswordLabel.AutoSize = true;
            this.managerAdminPasswordLabel.Location = new System.Drawing.Point(16, 136);
            this.managerAdminPasswordLabel.Name = "managerAdminPasswordLabel";
            this.managerAdminPasswordLabel.Size = new System.Drawing.Size(89, 16);
            this.managerAdminPasswordLabel.TabIndex = 0;
            this.managerAdminPasswordLabel.Text = "Confirm pass:";
            // 
            // managerPasswordLabel
            // 
            this.managerPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.managerPasswordLabel.AutoSize = true;
            this.managerPasswordLabel.Location = new System.Drawing.Point(16, 96);
            this.managerPasswordLabel.Name = "managerPasswordLabel";
            this.managerPasswordLabel.Size = new System.Drawing.Size(72, 16);
            this.managerPasswordLabel.TabIndex = 0;
            this.managerPasswordLabel.Text = "Your pass:";
            // 
            // salesmanUsernameLabelDelete
            // 
            this.salesmanUsernameLabelDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.salesmanUsernameLabelDelete.AutoSize = true;
            this.salesmanUsernameLabelDelete.Location = new System.Drawing.Point(16, 49);
            this.salesmanUsernameLabelDelete.Name = "salesmanUsernameLabelDelete";
            this.salesmanUsernameLabelDelete.Size = new System.Drawing.Size(77, 16);
            this.salesmanUsernameLabelDelete.TabIndex = 0;
            this.salesmanUsernameLabelDelete.Text = "Username: ";
            // 
            // userListGroupBox
            // 
            this.userListGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userListGroupBox.Controls.Add(this.showAllMetroButton);
            this.userListGroupBox.Controls.Add(this.userListMetroListView);
            this.userListGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userListGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userListGroupBox.Location = new System.Drawing.Point(104, 28);
            this.userListGroupBox.Name = "userListGroupBox";
            this.userListGroupBox.Size = new System.Drawing.Size(478, 284);
            this.userListGroupBox.TabIndex = 0;
            this.userListGroupBox.TabStop = false;
            this.userListGroupBox.Text = "User list";
            // 
            // showAllMetroButton
            // 
            this.showAllMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showAllMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.showAllMetroButton.Location = new System.Drawing.Point(370, 226);
            this.showAllMetroButton.Name = "showAllMetroButton";
            this.showAllMetroButton.Size = new System.Drawing.Size(82, 44);
            this.showAllMetroButton.TabIndex = 2;
            this.showAllMetroButton.Text = "Show all";
            this.showAllMetroButton.UseSelectable = true;
            this.showAllMetroButton.Click += new System.EventHandler(this.showAllMetroButton_Click);
            // 
            // userListMetroListView
            // 
            this.userListMetroListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userListMetroListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.slNoColumnHeader,
            this.salesmanNameColumnHeader,
            this.typeColumnHeader});
            this.userListMetroListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.userListMetroListView.FullRowSelect = true;
            this.userListMetroListView.GridLines = true;
            this.userListMetroListView.Location = new System.Drawing.Point(24, 42);
            this.userListMetroListView.Name = "userListMetroListView";
            this.userListMetroListView.OwnerDraw = true;
            this.userListMetroListView.Size = new System.Drawing.Size(428, 178);
            this.userListMetroListView.TabIndex = 0;
            this.userListMetroListView.UseCompatibleStateImageBehavior = false;
            this.userListMetroListView.UseSelectable = true;
            this.userListMetroListView.View = System.Windows.Forms.View.Details;
            this.userListMetroListView.Click += new System.EventHandler(this.userListMetroListView_SelectedIndexChanged);
            // 
            // slNoColumnHeader
            // 
            this.slNoColumnHeader.Text = "Serial no";
            this.slNoColumnHeader.Width = 111;
            // 
            // salesmanNameColumnHeader
            // 
            this.salesmanNameColumnHeader.Text = "User Name";
            this.salesmanNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.salesmanNameColumnHeader.Width = 172;
            // 
            // typeColumnHeader
            // 
            this.typeColumnHeader.Text = "Type";
            this.typeColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.typeColumnHeader.Width = 121;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.Transparent;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.leftPanel.Location = new System.Drawing.Point(0, 64);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(21, 579);
            this.leftPanel.TabIndex = 11;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.Controls.Add(this.warningLabel);
            this.topPanel.Controls.Add(this.transactionMetroButton);
            this.topPanel.Controls.Add(this.editInfoMetroButton);
            this.topPanel.Controls.Add(this.logoutMetroButton);
            this.topPanel.Controls.Add(this.managerLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1303, 64);
            this.topPanel.TabIndex = 10;
            // 
            // warningLabel
            // 
            this.warningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(171, 14);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(202, 37);
            this.warningLabel.TabIndex = 28;
            this.warningLabel.Text = "Check stock";
            this.warningLabel.Click += new System.EventHandler(this.warningLabel_Click);
            // 
            // transactionMetroButton
            // 
            this.transactionMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.transactionMetroButton.Location = new System.Drawing.Point(30, 10);
            this.transactionMetroButton.Name = "transactionMetroButton";
            this.transactionMetroButton.Size = new System.Drawing.Size(109, 44);
            this.transactionMetroButton.TabIndex = 27;
            this.transactionMetroButton.Text = "Transaction";
            this.transactionMetroButton.UseSelectable = true;
            this.transactionMetroButton.Click += new System.EventHandler(this.transactionMetroButton_Click);
            // 
            // editInfoMetroButton
            // 
            this.editInfoMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editInfoMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.editInfoMetroButton.Location = new System.Drawing.Point(1100, 14);
            this.editInfoMetroButton.Name = "editInfoMetroButton";
            this.editInfoMetroButton.Size = new System.Drawing.Size(75, 44);
            this.editInfoMetroButton.TabIndex = 27;
            this.editInfoMetroButton.Text = "Edit info";
            this.editInfoMetroButton.UseSelectable = true;
            this.editInfoMetroButton.Click += new System.EventHandler(this.editInfoMetroButton_Click);
            // 
            // logoutMetroButton
            // 
            this.logoutMetroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.logoutMetroButton.Location = new System.Drawing.Point(1200, 14);
            this.logoutMetroButton.Name = "logoutMetroButton";
            this.logoutMetroButton.Size = new System.Drawing.Size(75, 44);
            this.logoutMetroButton.TabIndex = 4;
            this.logoutMetroButton.Text = "Logout";
            this.logoutMetroButton.UseSelectable = true;
            this.logoutMetroButton.Click += new System.EventHandler(this.logoutMetroButton_Click);
            // 
            // managerLabel
            // 
            this.managerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.managerLabel.AutoSize = true;
            this.managerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.managerLabel.Location = new System.Drawing.Point(580, 14);
            this.managerLabel.Name = "managerLabel";
            this.managerLabel.Size = new System.Drawing.Size(120, 31);
            this.managerLabel.TabIndex = 2;
            this.managerLabel.Text = "Manager";
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.Transparent;
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1303, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(21, 643);
            this.rightPanel.TabIndex = 12;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 643);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1324, 13);
            this.bottomPanel.TabIndex = 13;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.backgroundPanel);
            this.MinimumSize = new System.Drawing.Size(1364, 736);
            this.Name = "ManagerForm";
            this.Text = "Super shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.backgroundPanel.ResumeLayout(false);
            this.centerSplitContainer.Panel1.ResumeLayout(false);
            this.centerSplitContainer.Panel1.PerformLayout();
            this.centerSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.centerSplitContainer)).EndInit();
            this.centerSplitContainer.ResumeLayout(false);
            this.signUpGroupBox.ResumeLayout(false);
            this.signUpGroupBox.PerformLayout();
            this.deleteUserGroupBox.ResumeLayout(false);
            this.deleteUserGroupBox.PerformLayout();
            this.userListGroupBox.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.SplitContainer centerSplitContainer;
        private System.Windows.Forms.GroupBox signUpGroupBox;
        private MetroFramework.Controls.MetroButton submitMetroButton;
        private MetroFramework.Controls.MetroButton resetMetroButton;
        private MetroFramework.Controls.MetroDateTime dOBMetroDateTime;
        private MetroFramework.Controls.MetroRadioButton femaleMetroRadioButton;
        private MetroFramework.Controls.MetroRadioButton maleMetroRadioButton;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox secureAnswerTextBox;
        private System.Windows.Forms.TextBox sequrityQuestionTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label secureAnsLabel;
        private System.Windows.Forms.Label sequrityQuesLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label dOBLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private MetroFramework.Controls.MetroRadioButton salesmanMetroRadioButton;
        private MetroFramework.Controls.MetroRadioButton adminMetroRadioButton;
        private System.Windows.Forms.GroupBox deleteUserGroupBox;
        private MetroFramework.Controls.MetroButton submitMetroButtonDelete;
        private MetroFramework.Controls.MetroButton resetMetroButtonDelete;
        private System.Windows.Forms.TextBox salesmanNameTextBoxDelete;
        private System.Windows.Forms.TextBox confirmManagerPasswordTextBox;
        private System.Windows.Forms.TextBox managerPasswordTextBox;
        private System.Windows.Forms.Label managerAdminPasswordLabel;
        private System.Windows.Forms.Label managerPasswordLabel;
        private System.Windows.Forms.Label salesmanUsernameLabelDelete;
        private System.Windows.Forms.GroupBox userListGroupBox;
        private MetroFramework.Controls.MetroButton showAllMetroButton;
        private MetroFramework.Controls.MetroListView userListMetroListView;
        private System.Windows.Forms.ColumnHeader slNoColumnHeader;
        private System.Windows.Forms.ColumnHeader salesmanNameColumnHeader;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private MetroFramework.Controls.MetroButton logoutMetroButton;
        private System.Windows.Forms.Label managerLabel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private MetroFramework.Controls.MetroButton editInfoMetroButton;
        private System.Windows.Forms.ColumnHeader typeColumnHeader;
        private MetroFramework.Controls.MetroButton transactionMetroButton;
        private System.Windows.Forms.Label warningLabel;
    }
}