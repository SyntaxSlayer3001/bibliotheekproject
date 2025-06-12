namespace inlogformulier
{
    partial class Beheerderscherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beheerderscherm));
            tbBoekenlijst = new ListBox();
            btnAddboek = new Button();
            btnAddUser = new Button();
            btnRefresh = new Button();
            button1 = new Button();
            btnDeleteBoek = new Button();
            btnDeleteUser = new Button();
            btnUpdateUser = new Button();
            listBoxGebruikers = new ListBox();
            btnUitloggen = new Button();
            SuspendLayout();
            // 
            // tbBoekenlijst
            // 
            tbBoekenlijst.FormattingEnabled = true;
            tbBoekenlijst.Location = new Point(14, 16);
            tbBoekenlijst.Margin = new Padding(3, 4, 3, 4);
            tbBoekenlijst.Name = "tbBoekenlijst";
            tbBoekenlijst.Size = new Size(390, 564);
            tbBoekenlijst.TabIndex = 0;
            // 
            // btnAddboek
            // 
            btnAddboek.Location = new Point(859, 16);
            btnAddboek.Margin = new Padding(3, 4, 3, 4);
            btnAddboek.Name = "btnAddboek";
            btnAddboek.Size = new Size(351, 49);
            btnAddboek.TabIndex = 1;
            btnAddboek.Text = "Voeg boek toe";
            btnAddboek.UseVisualStyleBackColor = true;
            btnAddboek.Click += btnAddboek_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(859, 286);
            btnAddUser.Margin = new Padding(3, 4, 3, 4);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(351, 49);
            btnAddUser.TabIndex = 4;
            btnAddUser.Text = "Voeg een gebruiker toe";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(859, 538);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(351, 49);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // button1
            // 
            button1.Location = new Point(859, 104);
            button1.Name = "button1";
            button1.Size = new Size(351, 49);
            button1.TabIndex = 2;
            button1.Text = "Boek updaten";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBoek
            // 
            btnDeleteBoek.Location = new Point(859, 198);
            btnDeleteBoek.Name = "btnDeleteBoek";
            btnDeleteBoek.Size = new Size(351, 49);
            btnDeleteBoek.TabIndex = 3;
            btnDeleteBoek.Text = "Verwijder boek";
            btnDeleteBoek.UseVisualStyleBackColor = true;
            btnDeleteBoek.Click += btnDeleteBoek_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(859, 455);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(351, 49);
            btnDeleteUser.TabIndex = 6;
            btnDeleteUser.Text = "Verwijder een gebruiker";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Location = new Point(859, 370);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(351, 49);
            btnUpdateUser.TabIndex = 5;
            btnUpdateUser.Text = "Update een gebruiker";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // listBoxGebruikers
            // 
            listBoxGebruikers.FormattingEnabled = true;
            listBoxGebruikers.Location = new Point(424, 16);
            listBoxGebruikers.Name = "listBoxGebruikers";
            listBoxGebruikers.Size = new Size(387, 564);
            listBoxGebruikers.TabIndex = 7;
            // 
            // btnUitloggen
            // 
            btnUitloggen.Location = new Point(1222, 16);
            btnUitloggen.Name = "btnUitloggen";
            btnUitloggen.Size = new Size(94, 137);
            btnUitloggen.TabIndex = 8;
            btnUitloggen.Text = "Uitloggen";
            btnUitloggen.UseVisualStyleBackColor = true;
            btnUitloggen.Click += btnUitloggen_Click;
            // 
            // Beheerderscherm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1328, 600);
            Controls.Add(btnUitloggen);
            Controls.Add(listBoxGebruikers);
            Controls.Add(btnUpdateUser);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnDeleteBoek);
            Controls.Add(button1);
            Controls.Add(btnRefresh);
            Controls.Add(btnAddUser);
            Controls.Add(btnAddboek);
            Controls.Add(tbBoekenlijst);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Beheerderscherm";
            Text = "Beheerderscherm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox tbBoekenlijst;
        private Button btnAddboek;
        private Button btnAddUser;
        private Button btnRefresh;
        private Button button1;
        private Button btnDeleteBoek;
        private Button btnDeleteUser;
        private Button btnUpdateUser;
        private ListBox listBoxGebruikers;
        private Button btnUitloggen;
    }
}