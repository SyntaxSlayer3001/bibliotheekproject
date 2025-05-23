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
            tbBoekenlijst = new ListBox();
            btnAddboek = new Button();
            btnAddUser = new Button();
            btnRefresh = new Button();
            button1 = new Button();
            btnDeleteBoek = new Button();
            SuspendLayout();
            // 
            // tbBoekenlijst
            // 
            tbBoekenlijst.FormattingEnabled = true;
            tbBoekenlijst.Location = new Point(14, 16);
            tbBoekenlijst.Margin = new Padding(3, 4, 3, 4);
            tbBoekenlijst.Name = "tbBoekenlijst";
            tbBoekenlijst.Size = new Size(506, 564);
            tbBoekenlijst.TabIndex = 2;
            // 
            // btnAddboek
            // 
            btnAddboek.Location = new Point(550, 16);
            btnAddboek.Margin = new Padding(3, 4, 3, 4);
            btnAddboek.Name = "btnAddboek";
            btnAddboek.Size = new Size(351, 49);
            btnAddboek.TabIndex = 3;
            btnAddboek.Text = "Voeg boek toe";
            btnAddboek.UseVisualStyleBackColor = true;
            btnAddboek.Click += btnAddboek_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(550, 97);
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
            btnRefresh.Location = new Point(550, 337);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(81, 67);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // button1
            // 
            button1.Location = new Point(550, 176);
            button1.Name = "button1";
            button1.Size = new Size(351, 49);
            button1.TabIndex = 6;
            button1.Text = "Boek updaten";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnDeleteBoek
            // 
            btnDeleteBoek.Location = new Point(550, 261);
            btnDeleteBoek.Name = "btnDeleteBoek";
            btnDeleteBoek.Size = new Size(351, 49);
            btnDeleteBoek.TabIndex = 7;
            btnDeleteBoek.Text = "Verwijder boek";
            btnDeleteBoek.UseVisualStyleBackColor = true;
            btnDeleteBoek.Click += btnDeleteBoek_Click;
            // 
            // Beheerderscherm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
    }
}