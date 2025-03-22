namespace AnimeClient
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelReviews;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnGetAnime = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtSearchTitle = new System.Windows.Forms.TextBox();
            this.txtSearchGenre = new System.Windows.Forms.TextBox();
            this.txtSearchYear = new System.Windows.Forms.TextBox();
            this.txtMinRating = new System.Windows.Forms.TextBox();
            this.txtMaxRating = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(50, 50);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 26);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.Location = new System.Drawing.Point(50, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogin.Location = new System.Drawing.Point(50, 150);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(50, 200);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(96, 20);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Сообщение";
            this.lblMessage.Visible = false;
            // 
            // btnGetAnime
            // 
            this.btnGetAnime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGetAnime.Location = new System.Drawing.Point(300, 50);
            this.btnGetAnime.Name = "btnGetAnime";
            this.btnGetAnime.Size = new System.Drawing.Size(200, 40);
            this.btnGetAnime.TabIndex = 4;
            this.btnGetAnime.Text = "Поиск";
            this.btnGetAnime.UseVisualStyleBackColor = true;
            this.btnGetAnime.Click += new System.EventHandler(this.btnGetAnime_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(300, 100);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(96, 20);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Сообщение";
            this.lblDescription.Visible = false;
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchTitle.Location = new System.Drawing.Point(550, 50);
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.Size = new System.Drawing.Size(150, 26);
            this.txtSearchTitle.TabIndex = 7;
            this.txtSearchTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSearchGenre
            // 
            this.txtSearchGenre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchGenre.Location = new System.Drawing.Point(550, 100);
            this.txtSearchGenre.Name = "txtSearchGenre";
            this.txtSearchGenre.Size = new System.Drawing.Size(150, 26);
            this.txtSearchGenre.TabIndex = 7;
            this.txtSearchGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSearchYear
            // 
            this.txtSearchYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchYear.Location = new System.Drawing.Point(550, 150);
            this.txtSearchYear.Name = "txtSearchYear";
            this.txtSearchYear.Size = new System.Drawing.Size(150, 26);
            this.txtSearchYear.TabIndex = 7;
            // 
            // txtMinRating
            // 
            this.txtMinRating.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMinRating.Location = new System.Drawing.Point(550, 200);
            this.txtMinRating.Name = "txtMinRating";
            this.txtMinRating.Size = new System.Drawing.Size(150, 26);
            this.txtMinRating.TabIndex = 7;
            // 
            // txtMaxRating
            // 
            this.txtMaxRating.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaxRating.Location = new System.Drawing.Point(550, 250);
            this.txtMaxRating.Name = "txtMaxRating";
            this.txtMaxRating.Size = new System.Drawing.Size(150, 26);
            this.txtMaxRating.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegister.Location = new System.Drawing.Point(50, 250);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(200, 40);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Регистрация";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnOpenRegisterForm_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Название";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Жанр";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Год";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Минимальная оценка";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Максимальная оценка";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(300, 291);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(500, 300);
            this.flowLayoutPanel.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaxRating);
            this.Controls.Add(this.txtMinRating);
            this.Controls.Add(this.txtSearchYear);
            this.Controls.Add(this.txtSearchGenre);
            this.Controls.Add(this.txtSearchTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnGetAnime);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Anime Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnGetAnime;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtSearchTitle;
        private System.Windows.Forms.TextBox txtSearchGenre;
        private System.Windows.Forms.TextBox txtSearchYear;
        private System.Windows.Forms.TextBox txtMinRating;
        private System.Windows.Forms.TextBox txtMaxRating;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}