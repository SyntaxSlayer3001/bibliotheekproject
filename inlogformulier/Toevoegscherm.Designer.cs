namespace inlogformulier
{
    partial class Toevoegscherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toevoegscherm));
            tbTitel = new TextBox();
            tbISBN = new TextBox();
            tbUitgever = new TextBox();
            tbGraad = new TextBox();
            btnToevoegen = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBoxGenreId = new ComboBox();
            tbAuteur = new TextBox();
            comboBoxTaalId = new ComboBox();
            SuspendLayout();
            // 
            // tbTitel
            // 
            tbTitel.Location = new Point(241, 63);
            tbTitel.Margin = new Padding(3, 4, 3, 4);
            tbTitel.Name = "tbTitel";
            tbTitel.Size = new Size(535, 27);
            tbTitel.TabIndex = 0;
            // 
            // tbISBN
            // 
            tbISBN.Location = new Point(241, 457);
            tbISBN.Margin = new Padding(3, 4, 3, 4);
            tbISBN.Name = "tbISBN";
            tbISBN.Size = new Size(535, 27);
            tbISBN.TabIndex = 6;
            // 
            // tbUitgever
            // 
            tbUitgever.Location = new Point(241, 247);
            tbUitgever.Margin = new Padding(3, 4, 3, 4);
            tbUitgever.Name = "tbUitgever";
            tbUitgever.Size = new Size(535, 27);
            tbUitgever.TabIndex = 3;
            // 
            // tbGraad
            // 
            tbGraad.Location = new Point(241, 385);
            tbGraad.Margin = new Padding(3, 4, 3, 4);
            tbGraad.Name = "tbGraad";
            tbGraad.Size = new Size(535, 27);
            tbGraad.TabIndex = 5;
            // 
            // btnToevoegen
            // 
            btnToevoegen.Location = new Point(241, 520);
            btnToevoegen.Margin = new Padding(3, 4, 3, 4);
            btnToevoegen.Name = "btnToevoegen";
            btnToevoegen.Size = new Size(536, 49);
            btnToevoegen.TabIndex = 7;
            btnToevoegen.Text = "Voeg toe";
            btnToevoegen.UseVisualStyleBackColor = true;
            btnToevoegen.Click += btnToevoegen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 63);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 8;
            label1.Text = "Titel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 127);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 9;
            label2.Text = "Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 187);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 10;
            label3.Text = "Auteur";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 247);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 11;
            label4.Text = "Uitgever";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 320);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 12;
            label5.Text = "Taal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(126, 385);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 13;
            label6.Text = "Graad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(126, 457);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 14;
            label7.Text = "ISBN";
            // 
            // comboBoxGenreId
            // 
            comboBoxGenreId.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenreId.FormattingEnabled = true;
            comboBoxGenreId.Location = new Point(241, 127);
            comboBoxGenreId.Margin = new Padding(3, 4, 3, 4);
            comboBoxGenreId.Name = "comboBoxGenreId";
            comboBoxGenreId.Size = new Size(535, 28);
            comboBoxGenreId.TabIndex = 1;
            // 
            // tbAuteur
            // 
            tbAuteur.Location = new Point(241, 187);
            tbAuteur.Margin = new Padding(3, 4, 3, 4);
            tbAuteur.Name = "tbAuteur";
            tbAuteur.Size = new Size(535, 27);
            tbAuteur.TabIndex = 2;
            // 
            // comboBoxTaalId
            // 
            comboBoxTaalId.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTaalId.FormattingEnabled = true;
            comboBoxTaalId.Location = new Point(242, 320);
            comboBoxTaalId.Margin = new Padding(3, 4, 3, 4);
            comboBoxTaalId.Name = "comboBoxTaalId";
            comboBoxTaalId.Size = new Size(535, 28);
            comboBoxTaalId.TabIndex = 4;
            // 
            // Toevoegscherm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 600);
            Controls.Add(comboBoxTaalId);
            Controls.Add(comboBoxGenreId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnToevoegen);
            Controls.Add(tbGraad);
            Controls.Add(tbUitgever);
            Controls.Add(tbAuteur);
            Controls.Add(tbISBN);
            Controls.Add(tbTitel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Toevoegscherm";
            Text = "Toevoegscherm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTitel;
        private TextBox tbISBN;
        private TextBox tbUitgever;
        private TextBox tbGraad;
        private Button btnToevoegen;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxGenreId;
        private TextBox tbAuteur;
        private ComboBox comboBoxTaalId;
    }
}