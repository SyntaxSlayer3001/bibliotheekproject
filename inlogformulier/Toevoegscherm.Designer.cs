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
            tbTitel = new TextBox();
            tbISBN = new TextBox();
            tbGenreId = new TextBox();
            tbAuteur = new TextBox();
            tbUitgever = new TextBox();
            tbTaal = new TextBox();
            tbGraad = new TextBox();
            btnToevoegen = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // tbTitel
            // 
            tbTitel.Location = new Point(211, 47);
            tbTitel.Name = "tbTitel";
            tbTitel.Size = new Size(469, 23);
            tbTitel.TabIndex = 0;
            // 
            // tbISBN
            // 
            tbISBN.Location = new Point(211, 343);
            tbISBN.Name = "tbISBN";
            tbISBN.Size = new Size(469, 23);
            tbISBN.TabIndex = 6;
            // 
            // tbGenreId
            // 
            tbGenreId.Location = new Point(211, 95);
            tbGenreId.Name = "tbGenreId";
            tbGenreId.Size = new Size(469, 23);
            tbGenreId.TabIndex = 1;
            // 
            // tbAuteur
            // 
            tbAuteur.Location = new Point(211, 140);
            tbAuteur.Name = "tbAuteur";
            tbAuteur.Size = new Size(469, 23);
            tbAuteur.TabIndex = 2;
            // 
            // tbUitgever
            // 
            tbUitgever.Location = new Point(211, 185);
            tbUitgever.Name = "tbUitgever";
            tbUitgever.Size = new Size(469, 23);
            tbUitgever.TabIndex = 3;
            // 
            // tbTaal
            // 
            tbTaal.Location = new Point(211, 240);
            tbTaal.Name = "tbTaal";
            tbTaal.Size = new Size(469, 23);
            tbTaal.TabIndex = 4;
            // 
            // tbGraad
            // 
            tbGraad.Location = new Point(211, 289);
            tbGraad.Name = "tbGraad";
            tbGraad.Size = new Size(469, 23);
            tbGraad.TabIndex = 5;
            // 
            // btnToevoegen
            // 
            btnToevoegen.Location = new Point(211, 390);
            btnToevoegen.Name = "btnToevoegen";
            btnToevoegen.Size = new Size(469, 37);
            btnToevoegen.TabIndex = 7;
            btnToevoegen.Text = "Voeg toe";
            btnToevoegen.UseVisualStyleBackColor = true;
            btnToevoegen.Click += btnToevoegen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 47);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 8;
            label1.Text = "Titel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 95);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 9;
            label2.Text = "GenreId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 140);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 10;
            label3.Text = "Auteur";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 185);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 11;
            label4.Text = "Uitgever";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 240);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 12;
            label5.Text = "Taal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(110, 289);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 13;
            label6.Text = "Graad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(110, 343);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 14;
            label7.Text = "ISBN";
            // 
            // Toevoegscherm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnToevoegen);
            Controls.Add(tbGraad);
            Controls.Add(tbTaal);
            Controls.Add(tbUitgever);
            Controls.Add(tbAuteur);
            Controls.Add(tbGenreId);
            Controls.Add(tbISBN);
            Controls.Add(tbTitel);
            Name = "Toevoegscherm";
            Text = "Toevoegscherm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTitel;
        private TextBox tbISBN;
        private TextBox tbGenreId;
        private TextBox tbAuteur;
        private TextBox tbUitgever;
        private TextBox tbTaal;
        private TextBox tbGraad;
        private Button btnToevoegen;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}