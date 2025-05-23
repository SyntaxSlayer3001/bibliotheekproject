namespace inlogformulier
{
    partial class UpdateBoek
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
            tbTitelUpdate = new TextBox();
            btnUpdateBoek = new Button();
            label2 = new Label();
            label3 = new Label();
            tbAuteurUpdate = new TextBox();
            label4 = new Label();
            tbUitgeverUpdate = new TextBox();
            tbTaalUpdate = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tbGraadUpdate = new TextBox();
            label7 = new Label();
            tbISBNUpdate = new TextBox();
            comboBoxUpdateGenre = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 25);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Titel";
            // 
            // tbTitelUpdate
            // 
            tbTitelUpdate.Location = new Point(164, 25);
            tbTitelUpdate.Margin = new Padding(3, 2, 3, 2);
            tbTitelUpdate.Name = "tbTitelUpdate";
            tbTitelUpdate.Size = new Size(497, 23);
            tbTitelUpdate.TabIndex = 0;
            // 
            // btnUpdateBoek
            // 
            btnUpdateBoek.Location = new Point(10, 272);
            btnUpdateBoek.Margin = new Padding(3, 2, 3, 2);
            btnUpdateBoek.Name = "btnUpdateBoek";
            btnUpdateBoek.Size = new Size(662, 39);
            btnUpdateBoek.TabIndex = 7;
            btnUpdateBoek.Text = "Update boek";
            btnUpdateBoek.UseVisualStyleBackColor = true;
            btnUpdateBoek.Click += btnUpdateBoek_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 59);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 92);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "Auteur";
            // 
            // tbAuteurUpdate
            // 
            tbAuteurUpdate.Location = new Point(164, 92);
            tbAuteurUpdate.Margin = new Padding(3, 2, 3, 2);
            tbAuteurUpdate.Name = "tbAuteurUpdate";
            tbAuteurUpdate.Size = new Size(497, 23);
            tbAuteurUpdate.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 124);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "Uitgever";
            // 
            // tbUitgeverUpdate
            // 
            tbUitgeverUpdate.Location = new Point(164, 124);
            tbUitgeverUpdate.Margin = new Padding(3, 2, 3, 2);
            tbUitgeverUpdate.Name = "tbUitgeverUpdate";
            tbUitgeverUpdate.Size = new Size(497, 23);
            tbUitgeverUpdate.TabIndex = 3;
            // 
            // tbTaalUpdate
            // 
            tbTaalUpdate.Location = new Point(164, 166);
            tbTaalUpdate.Margin = new Padding(3, 2, 3, 2);
            tbTaalUpdate.Name = "tbTaalUpdate";
            tbTaalUpdate.Size = new Size(497, 23);
            tbTaalUpdate.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 166);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 10;
            label5.Text = "Taal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 202);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 11;
            label6.Text = "Graad";
            // 
            // tbGraadUpdate
            // 
            tbGraadUpdate.Location = new Point(164, 202);
            tbGraadUpdate.Margin = new Padding(3, 2, 3, 2);
            tbGraadUpdate.Name = "tbGraadUpdate";
            tbGraadUpdate.Size = new Size(497, 23);
            tbGraadUpdate.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 236);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 13;
            label7.Text = "ISBN";
            // 
            // tbISBNUpdate
            // 
            tbISBNUpdate.Location = new Point(164, 236);
            tbISBNUpdate.Margin = new Padding(3, 2, 3, 2);
            tbISBNUpdate.Name = "tbISBNUpdate";
            tbISBNUpdate.Size = new Size(497, 23);
            tbISBNUpdate.TabIndex = 6;
            // 
            // comboBoxUpdateGenre
            // 
            comboBoxUpdateGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUpdateGenre.FormattingEnabled = true;
            comboBoxUpdateGenre.Location = new Point(164, 59);
            comboBoxUpdateGenre.Name = "comboBoxUpdateGenre";
            comboBoxUpdateGenre.Size = new Size(497, 23);
            comboBoxUpdateGenre.TabIndex = 1;
            // 
            // UpdateBoek
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(comboBoxUpdateGenre);
            Controls.Add(tbISBNUpdate);
            Controls.Add(label7);
            Controls.Add(tbGraadUpdate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbTaalUpdate);
            Controls.Add(tbUitgeverUpdate);
            Controls.Add(label4);
            Controls.Add(tbAuteurUpdate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnUpdateBoek);
            Controls.Add(tbTitelUpdate);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UpdateBoek";
            Text = "UpdateBoek";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbTitelUpdate;
        private Button btnUpdateBoek;
        private Label label2;
        private Label label3;
        private TextBox tbAuteurUpdate;
        private Label label4;
        private TextBox tbUitgeverUpdate;
        private TextBox tbTaalUpdate;
        private Label label5;
        private Label label6;
        private TextBox tbGraadUpdate;
        private Label label7;
        private TextBox tbISBNUpdate;
        private ComboBox comboBoxUpdateGenre;
    }
}