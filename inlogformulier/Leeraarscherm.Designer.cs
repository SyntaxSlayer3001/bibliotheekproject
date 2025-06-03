namespace inlogformulier
{
    partial class Leeraarscherm
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
            tbBoekenlijst = new ListBox();
            btnAddboek = new Button();
            btnRefresh = new Button();
            btnBoekUpdaten = new Button();
            btnDeleteBoek = new Button();
            tbZoekTitel = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // tbBoekenlijst
            // 
            tbBoekenlijst.FormattingEnabled = true;
            tbBoekenlijst.Location = new Point(14, 16);
            tbBoekenlijst.Margin = new Padding(3, 4, 3, 4);
            tbBoekenlijst.Name = "tbBoekenlijst";
            tbBoekenlijst.Size = new Size(506, 564);
            tbBoekenlijst.TabIndex = 0;
            // 
            // btnAddboek
            // 
            btnAddboek.Location = new Point(550, 16);
            btnAddboek.Margin = new Padding(3, 4, 3, 4);
            btnAddboek.Name = "btnAddboek";
            btnAddboek.Size = new Size(351, 49);
            btnAddboek.TabIndex = 1;
            btnAddboek.Text = "Voeg boek toe";
            btnAddboek.UseVisualStyleBackColor = true;
            btnAddboek.Click += btnAddboek_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(550, 317);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(81, 67);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBoekUpdaten
            // 
            btnBoekUpdaten.Location = new Point(550, 97);
            btnBoekUpdaten.Name = "btnBoekUpdaten";
            btnBoekUpdaten.Size = new Size(351, 49);
            btnBoekUpdaten.TabIndex = 2;
            btnBoekUpdaten.Text = "Boek updaten";
            btnBoekUpdaten.UseVisualStyleBackColor = true;
            btnBoekUpdaten.Click += button1_Click;
            // 
            // btnDeleteBoek
            // 
            btnDeleteBoek.Location = new Point(550, 184);
            btnDeleteBoek.Name = "btnDeleteBoek";
            btnDeleteBoek.Size = new Size(351, 49);
            btnDeleteBoek.TabIndex = 3;
            btnDeleteBoek.Text = "Verwijder boek";
            btnDeleteBoek.UseVisualStyleBackColor = true;
            btnDeleteBoek.Click += btnDeleteBoek_Click;
            // 
            // tbZoekTitel
            // 
            tbZoekTitel.Location = new Point(700, 259);
            tbZoekTitel.Margin = new Padding(3, 4, 3, 4);
            tbZoekTitel.Name = "tbZoekTitel";
            tbZoekTitel.Size = new Size(202, 27);
            tbZoekTitel.TabIndex = 5;
            tbZoekTitel.TextChanged += tbZoekTitel_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(550, 259);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 6;
            label1.Text = "Zoeken op titel";
            // 
            // Leeraarscherm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(tbZoekTitel);
            Controls.Add(btnDeleteBoek);
            Controls.Add(btnBoekUpdaten);
            Controls.Add(btnRefresh);
            Controls.Add(btnAddboek);
            Controls.Add(tbBoekenlijst);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Leeraarscherm";
            Text = "Leeraarscherm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox tbBoekenlijst;
        private Button btnAddboek;
        private Button btnRefresh;
        private Button btnBoekUpdaten;
        private Button btnDeleteBoek;
        private TextBox tbZoekTitel;
        private Label label1;
    }
}