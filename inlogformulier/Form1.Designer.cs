namespace inlogformulier
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tbEmail = new TextBox();
            tbWachtwoord = new TextBox();
            label1 = new Label();
            label2 = new Label();
            loginButton = new Button();
            btnShowPassword = new Button();
            SuspendLayout();
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(162, 48);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(561, 27);
            tbEmail.TabIndex = 0;
            // 
            // tbWachtwoord
            // 
            tbWachtwoord.Location = new Point(162, 175);
            tbWachtwoord.Name = "tbWachtwoord";
            tbWachtwoord.Size = new Size(561, 27);
            tbWachtwoord.TabIndex = 1;
            tbWachtwoord.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 48);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 175);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 3;
            label2.Text = "Wachtwoord";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(21, 261);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(767, 75);
            loginButton.TabIndex = 4;
            loginButton.Text = "Inloggen";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // btnShowPassword
            // 
            btnShowPassword.Location = new Point(723, 175);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(40, 27);
            btnShowPassword.TabIndex = 5;
            btnShowPassword.Text = "👁";
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.MouseDown += btnShowPassword_MouseDown;
            btnShowPassword.MouseUp += btnShowPassword_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 451);
            Controls.Add(btnShowPassword);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbWachtwoord);
            Controls.Add(tbEmail);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbEmail;
        private TextBox tbWachtwoord;
        private Label label1;
        private Label label2;
        private Button loginButton;
        private Button btnShowPassword;
    }
}
