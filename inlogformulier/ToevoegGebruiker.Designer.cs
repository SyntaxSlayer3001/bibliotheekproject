namespace inlogformulier
{
    partial class ToevoegGebruiker
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
            label1 = new Label();
            tbEmail = new TextBox();
            btnToevoegenGebruiker = new Button();
            label2 = new Label();
            tbWachtwoord = new TextBox();
            label3 = new Label();
            tbNaam = new TextBox();
            label4 = new Label();
            tbVoornaam = new TextBox();
            label5 = new Label();
            tbRechtID = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 41);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(251, 41);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(525, 27);
            tbEmail.TabIndex = 0;
            // 
            // btnToevoegenGebruiker
            // 
            btnToevoegenGebruiker.Location = new Point(138, 328);
            btnToevoegenGebruiker.Margin = new Padding(3, 4, 3, 4);
            btnToevoegenGebruiker.Name = "btnToevoegenGebruiker";
            btnToevoegenGebruiker.Size = new Size(639, 31);
            btnToevoegenGebruiker.TabIndex = 5;
            btnToevoegenGebruiker.Text = "Voeg gebruiker toe";
            btnToevoegenGebruiker.UseVisualStyleBackColor = true;
            btnToevoegenGebruiker.Click += btnToevoegenGebruiker_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 265);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 3;
            label2.Text = "Wachtwoord";
            // 
            // tbWachtwoord
            // 
            tbWachtwoord.Location = new Point(251, 265);
            tbWachtwoord.Margin = new Padding(3, 4, 3, 4);
            tbWachtwoord.Name = "tbWachtwoord";
            tbWachtwoord.Size = new Size(525, 27);
            tbWachtwoord.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 98);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Naam";
            // 
            // tbNaam
            // 
            tbNaam.Location = new Point(251, 98);
            tbNaam.Margin = new Padding(3, 4, 3, 4);
            tbNaam.Name = "tbNaam";
            tbNaam.Size = new Size(525, 27);
            tbNaam.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(157, 153);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 7;
            label4.Text = "Voornaam";
            // 
            // tbVoornaam
            // 
            tbVoornaam.Location = new Point(251, 153);
            tbVoornaam.Margin = new Padding(3, 4, 3, 4);
            tbVoornaam.Name = "tbVoornaam";
            tbVoornaam.Size = new Size(525, 27);
            tbVoornaam.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(173, 215);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 9;
            label5.Text = "RechtID";
            // 
            // tbRechtID
            // 
            tbRechtID.Location = new Point(251, 215);
            tbRechtID.Margin = new Padding(3, 4, 3, 4);
            tbRechtID.Name = "tbRechtID";
            tbRechtID.Size = new Size(525, 27);
            tbRechtID.TabIndex = 3;
            // 
            // ToevoegGebruiker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tbRechtID);
            Controls.Add(label5);
            Controls.Add(tbVoornaam);
            Controls.Add(label4);
            Controls.Add(tbNaam);
            Controls.Add(label3);
            Controls.Add(tbWachtwoord);
            Controls.Add(label2);
            Controls.Add(btnToevoegenGebruiker);
            Controls.Add(tbEmail);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ToevoegGebruiker";
            Text = "ToevoegGebruiker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbEmail;
        private Button btnToevoegenGebruiker;
        private Label label2;
        private TextBox tbWachtwoord;
        private Label label3;
        private TextBox tbNaam;
        private Label label4;
        private TextBox tbVoornaam;
        private Label label5;
        private TextBox tbRechtID;
    }
}