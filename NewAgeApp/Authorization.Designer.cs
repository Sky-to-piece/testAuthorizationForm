namespace NewAgeApp
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.BTExit = new System.Windows.Forms.Button();
            this.BTMinBox = new System.Windows.Forms.Button();
            this.headerText = new System.Windows.Forms.Label();
            this.penelHeader = new System.Windows.Forms.Panel();
            this.PBTheme = new System.Windows.Forms.PictureBox();
            this.PBHeaderLogo = new System.Windows.Forms.PictureBox();
            this.BTEnter = new System.Windows.Forms.Button();
            this.BTCreateAccount = new System.Windows.Forms.Button();
            this.TBLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.PBHide = new System.Windows.Forms.PictureBox();
            this.PBView = new System.Windows.Forms.PictureBox();
            this.penelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBHeaderLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBView)).BeginInit();
            this.SuspendLayout();
            // 
            // BTExit
            // 
            this.BTExit.FlatAppearance.BorderSize = 0;
            this.BTExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTExit.Font = new System.Drawing.Font("Consolas", 11F);
            this.BTExit.Location = new System.Drawing.Point(570, 0);
            this.BTExit.Name = "BTExit";
            this.BTExit.Size = new System.Drawing.Size(30, 30);
            this.BTExit.TabIndex = 0;
            this.BTExit.TabStop = false;
            this.BTExit.Text = "X";
            this.BTExit.UseVisualStyleBackColor = false;
            this.BTExit.Click += new System.EventHandler(this.BTExit_Click);
            // 
            // BTMinBox
            // 
            this.BTMinBox.FlatAppearance.BorderSize = 0;
            this.BTMinBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTMinBox.Font = new System.Drawing.Font("Consolas", 11F);
            this.BTMinBox.Location = new System.Drawing.Point(534, 0);
            this.BTMinBox.Name = "BTMinBox";
            this.BTMinBox.Size = new System.Drawing.Size(30, 30);
            this.BTMinBox.TabIndex = 0;
            this.BTMinBox.TabStop = false;
            this.BTMinBox.Text = "—";
            this.BTMinBox.UseVisualStyleBackColor = false;
            this.BTMinBox.Click += new System.EventHandler(this.BTMinBox_Click);
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Location = new System.Drawing.Point(47, 6);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(96, 18);
            this.headerText.TabIndex = 9;
            this.headerText.Text = "header text";
            // 
            // penelHeader
            // 
            this.penelHeader.Controls.Add(this.PBTheme);
            this.penelHeader.Controls.Add(this.PBHeaderLogo);
            this.penelHeader.Controls.Add(this.headerText);
            this.penelHeader.Controls.Add(this.BTMinBox);
            this.penelHeader.Controls.Add(this.BTExit);
            this.penelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.penelHeader.Location = new System.Drawing.Point(0, 0);
            this.penelHeader.Name = "penelHeader";
            this.penelHeader.Size = new System.Drawing.Size(600, 30);
            this.penelHeader.TabIndex = 11;
            this.penelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.penelHeader_MouseDown);
            this.penelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.penelHeader_MouseMove);
            // 
            // PBTheme
            // 
            this.PBTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBTheme.Image = global::NewAgeApp.Properties.Resources.nightZZZ;
            this.PBTheme.Location = new System.Drawing.Point(499, 0);
            this.PBTheme.Name = "PBTheme";
            this.PBTheme.Size = new System.Drawing.Size(29, 29);
            this.PBTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBTheme.TabIndex = 12;
            this.PBTheme.TabStop = false;
            this.PBTheme.Click += new System.EventHandler(this.PBTheme_Click);
            // 
            // PBHeaderLogo
            // 
            this.PBHeaderLogo.Image = global::NewAgeApp.Properties.Resources.smoke;
            this.PBHeaderLogo.Location = new System.Drawing.Point(3, 0);
            this.PBHeaderLogo.Name = "PBHeaderLogo";
            this.PBHeaderLogo.Size = new System.Drawing.Size(29, 29);
            this.PBHeaderLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBHeaderLogo.TabIndex = 12;
            this.PBHeaderLogo.TabStop = false;
            // 
            // BTEnter
            // 
            this.BTEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BTEnter.FlatAppearance.BorderSize = 0;
            this.BTEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTEnter.Font = new System.Drawing.Font("Consolas", 20F);
            this.BTEnter.Location = new System.Drawing.Point(230, 236);
            this.BTEnter.Name = "BTEnter";
            this.BTEnter.Size = new System.Drawing.Size(170, 40);
            this.BTEnter.TabIndex = 15;
            this.BTEnter.Text = "Войти";
            this.BTEnter.UseVisualStyleBackColor = false;
            this.BTEnter.Click += new System.EventHandler(this.BTEnter_Click);
            // 
            // BTCreateAccount
            // 
            this.BTCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTCreateAccount.FlatAppearance.BorderSize = 0;
            this.BTCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTCreateAccount.Font = new System.Drawing.Font("Consolas", 9F);
            this.BTCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.BTCreateAccount.Location = new System.Drawing.Point(230, 282);
            this.BTCreateAccount.Name = "BTCreateAccount";
            this.BTCreateAccount.Size = new System.Drawing.Size(170, 20);
            this.BTCreateAccount.TabIndex = 16;
            this.BTCreateAccount.TabStop = false;
            this.BTCreateAccount.Text = "создать аккаунт";
            this.BTCreateAccount.UseVisualStyleBackColor = false;
            this.BTCreateAccount.Click += new System.EventHandler(this.BTCreateAccount_Click);
            // 
            // TBLogin
            // 
            this.TBLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBLogin.Location = new System.Drawing.Point(230, 168);
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.Size = new System.Drawing.Size(170, 25);
            this.TBLogin.TabIndex = 17;
            this.TBLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBLogin_KeyDown);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Consolas", 11F);
            this.labelPassword.Location = new System.Drawing.Point(142, 207);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 18);
            this.labelPassword.TabIndex = 19;
            this.labelPassword.Text = "Пароль:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Consolas", 11F);
            this.labelLogin.Location = new System.Drawing.Point(150, 170);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(56, 18);
            this.labelLogin.TabIndex = 18;
            this.labelLogin.Text = "Логин:";
            // 
            // TBPassword
            // 
            this.TBPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBPassword.Location = new System.Drawing.Point(230, 205);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(170, 25);
            this.TBPassword.TabIndex = 20;
            this.TBPassword.UseSystemPasswordChar = true;
            this.TBPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBPassword_KeyDown);
            // 
            // PBHide
            // 
            this.PBHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBHide.Image = global::NewAgeApp.Properties.Resources.hide;
            this.PBHide.Location = new System.Drawing.Point(406, 205);
            this.PBHide.Name = "PBHide";
            this.PBHide.Size = new System.Drawing.Size(25, 25);
            this.PBHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBHide.TabIndex = 12;
            this.PBHide.TabStop = false;
            this.PBHide.Click += new System.EventHandler(this.PBHide_Click);
            // 
            // PBView
            // 
            this.PBView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBView.Image = global::NewAgeApp.Properties.Resources.view;
            this.PBView.Location = new System.Drawing.Point(406, 205);
            this.PBView.Name = "PBView";
            this.PBView.Size = new System.Drawing.Size(25, 25);
            this.PBView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBView.TabIndex = 12;
            this.PBView.TabStop = false;
            this.PBView.Click += new System.EventHandler(this.PBView_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.ControlBox = false;
            this.Controls.Add(this.PBHide);
            this.Controls.Add(this.PBView);
            this.Controls.Add(this.TBLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.BTEnter);
            this.Controls.Add(this.BTCreateAccount);
            this.Controls.Add(this.penelHeader);
            this.Font = new System.Drawing.Font("Consolas", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(243)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.penelHeader.ResumeLayout(false);
            this.penelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBHeaderLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTExit;
        private System.Windows.Forms.Button BTMinBox;
        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.PictureBox PBHeaderLogo;
        private System.Windows.Forms.Panel penelHeader;
        private System.Windows.Forms.PictureBox PBTheme;
        private System.Windows.Forms.Button BTEnter;
        private System.Windows.Forms.Button BTCreateAccount;
        private System.Windows.Forms.TextBox TBLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.PictureBox PBView;
        private System.Windows.Forms.PictureBox PBHide;
    }
}

