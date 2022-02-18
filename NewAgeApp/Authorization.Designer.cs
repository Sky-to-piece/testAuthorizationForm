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
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTEnter = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.TBLogin = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BTCreateAccount = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.penelHeader = new System.Windows.Forms.Panel();
            this.headerText = new System.Windows.Forms.Label();
            this.BTMinBox = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.penelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(26)))), ((int)(((byte)(98)))));
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Consolas", 11F);
            this.buttonExit.Location = new System.Drawing.Point(570, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(30, 30);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.panel3.Location = new System.Drawing.Point(502, 207);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(70, 70);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(26)))), ((int)(((byte)(98)))));
            this.panel2.Location = new System.Drawing.Point(502, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 70);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Location = new System.Drawing.Point(502, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 70);
            this.panel1.TabIndex = 8;
            // 
            // BTEnter
            // 
            this.BTEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.BTEnter.FlatAppearance.BorderSize = 0;
            this.BTEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTEnter.Font = new System.Drawing.Font("Consolas", 20F);
            this.BTEnter.Location = new System.Drawing.Point(224, 270);
            this.BTEnter.Name = "BTEnter";
            this.BTEnter.Size = new System.Drawing.Size(167, 46);
            this.BTEnter.TabIndex = 5;
            this.BTEnter.Text = "Войти";
            this.BTEnter.UseVisualStyleBackColor = false;
            this.BTEnter.Click += new System.EventHandler(this.BTEnter_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Consolas", 11F);
            this.labelPassword.Location = new System.Drawing.Point(160, 177);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 18);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Пароль:";
            // 
            // TBLogin
            // 
            this.TBLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.TBLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBLogin.ForeColor = System.Drawing.Color.White;
            this.TBLogin.Location = new System.Drawing.Point(278, 142);
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.Size = new System.Drawing.Size(157, 25);
            this.TBLogin.TabIndex = 3;
            this.TBLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBLogin_KeyDown);
            // 
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.TBPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBPassword.ForeColor = System.Drawing.Color.White;
            this.TBPassword.Location = new System.Drawing.Point(278, 174);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(157, 25);
            this.TBPassword.TabIndex = 4;
            this.TBPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBPassword_KeyDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(502, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(70, 70);
            this.panel4.TabIndex = 8;
            // 
            // BTCreateAccount
            // 
            this.BTCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTCreateAccount.FlatAppearance.BorderSize = 0;
            this.BTCreateAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.BTCreateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.BTCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTCreateAccount.Font = new System.Drawing.Font("Consolas", 9F);
            this.BTCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.BTCreateAccount.Location = new System.Drawing.Point(224, 318);
            this.BTCreateAccount.Name = "BTCreateAccount";
            this.BTCreateAccount.Size = new System.Drawing.Size(167, 20);
            this.BTCreateAccount.TabIndex = 6;
            this.BTCreateAccount.TabStop = false;
            this.BTCreateAccount.Text = "создать аккаунт";
            this.BTCreateAccount.UseVisualStyleBackColor = false;
            this.BTCreateAccount.Click += new System.EventHandler(this.BTCreateAccount_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Consolas", 11F);
            this.labelLogin.Location = new System.Drawing.Point(160, 145);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(56, 18);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Логин:";
            // 
            // penelHeader
            // 
            this.penelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.penelHeader.Controls.Add(this.pictureBox1);
            this.penelHeader.Controls.Add(this.headerText);
            this.penelHeader.Controls.Add(this.BTMinBox);
            this.penelHeader.Controls.Add(this.buttonExit);
            this.penelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.penelHeader.Location = new System.Drawing.Point(0, 0);
            this.penelHeader.Name = "penelHeader";
            this.penelHeader.Size = new System.Drawing.Size(600, 30);
            this.penelHeader.TabIndex = 11;
            this.penelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.penelHeader_MouseDown);
            this.penelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.penelHeader_MouseMove);
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
            // BTMinBox
            // 
            this.BTMinBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.BTMinBox.FlatAppearance.BorderSize = 0;
            this.BTMinBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(26)))), ((int)(((byte)(98)))));
            this.BTMinBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BTMinBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTMinBox.Font = new System.Drawing.Font("Consolas", 11F);
            this.BTMinBox.Location = new System.Drawing.Point(534, 0);
            this.BTMinBox.Name = "BTMinBox";
            this.BTMinBox.Size = new System.Drawing.Size(30, 30);
            this.BTMinBox.TabIndex = 7;
            this.BTMinBox.Text = "—";
            this.BTMinBox.UseVisualStyleBackColor = false;
            this.BTMinBox.Click += new System.EventHandler(this.BTMinBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NewAgeApp.Properties.Resources.smoke;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.ControlBox = false;
            this.Controls.Add(this.penelHeader);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBLogin);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.BTCreateAccount);
            this.Controls.Add(this.BTEnter);
            this.Font = new System.Drawing.Font("Consolas", 11F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Authorization";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.penelHeader.ResumeLayout(false);
            this.penelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTEnter;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox TBLogin;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BTCreateAccount;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Panel penelHeader;
        private System.Windows.Forms.Button BTMinBox;
        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

