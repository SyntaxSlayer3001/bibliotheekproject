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
            SuspendLayout();
            // 
            // tbBoekenlijst
            // 
            tbBoekenlijst.FormattingEnabled = true;
            tbBoekenlijst.ItemHeight = 15;
            tbBoekenlijst.Location = new Point(12, 12);
            tbBoekenlijst.Name = "tbBoekenlijst";
            tbBoekenlijst.Size = new Size(443, 424);
            tbBoekenlijst.TabIndex = 0;
            // 
            // btnAddboek
            // 
            btnAddboek.Location = new Point(481, 12);
            btnAddboek.Name = "btnAddboek";
            btnAddboek.Size = new Size(307, 37);
            btnAddboek.TabIndex = 1;
            btnAddboek.Text = "Voeg boek toe";
            btnAddboek.UseVisualStyleBackColor = true;
            btnAddboek.Click += btnAddboek_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(481, 202);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(71, 50);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBoekUpdaten
            // 
            btnBoekUpdaten.Location = new Point(481, 73);
            btnBoekUpdaten.Margin = new Padding(3, 2, 3, 2);
            btnBoekUpdaten.Name = "btnBoekUpdaten";
            btnBoekUpdaten.Size = new Size(307, 37);
            btnBoekUpdaten.TabIndex = 2;
            btnBoekUpdaten.Text = "Boek updaten";
            btnBoekUpdaten.UseVisualStyleBackColor = true;
            btnBoekUpdaten.Click += button1_Click;
            // 
            // btnDeleteBoek
            // 
            btnDeleteBoek.Location = new Point(481, 138);
            btnDeleteBoek.Margin = new Padding(3, 2, 3, 2);
            btnDeleteBoek.Name = "btnDeleteBoek";
            btnDeleteBoek.Size = new Size(307, 37);
            btnDeleteBoek.TabIndex = 3;
            btnDeleteBoek.Text = "Verwijder boek";
            btnDeleteBoek.UseVisualStyleBackColor = true;
            btnDeleteBoek.Click += btnDeleteBoek_Click;
            // 
            // Leeraarscherm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteBoek);
            Controls.Add(btnBoekUpdaten);
            Controls.Add(btnRefresh);
            Controls.Add(btnAddboek);
            Controls.Add(tbBoekenlijst);
            Name = "Leeraarscherm";
            Text = "Leeraarscherm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox tbBoekenlijst;
        private Button btnAddboek;
        private Button btnRefresh;
        private Button btnBoekUpdaten;
        private Button btnDeleteBoek;
    }
}