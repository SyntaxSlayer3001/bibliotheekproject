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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBoek));
            label1 = new Label();
            tbTitelUpdate = new TextBox();
            btnUpdateBoek = new Button();
            label2 = new Label();
            label3 = new Label();
            tbAuteurUpdate = new TextBox();
            label4 = new Label();
            tbUitgeverUpdate = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tbGraadUpdate = new TextBox();
            label7 = new Label();
            tbISBNUpdate = new TextBox();
            comboBoxUpdateGenre = new ComboBox();
            comboBoxUpdateTaal = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 33);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Titel";
            // 
            // tbTitelUpdate
            // 
            tbTitelUpdate.Location = new Point(187, 33);
            tbTitelUpdate.Name = "tbTitelUpdate";
            tbTitelUpdate.Size = new Size(567, 27);
            tbTitelUpdate.TabIndex = 0;
            // 
            // btnUpdateBoek
            // 
            btnUpdateBoek.Location = new Point(11, 363);
            btnUpdateBoek.Name = "btnUpdateBoek";
            btnUpdateBoek.Size = new Size(757, 52);
            btnUpdateBoek.TabIndex = 7;
            btnUpdateBoek.Text = "Update boek";
            btnUpdateBoek.UseVisualStyleBackColor = true;
            btnUpdateBoek.Click += btnUpdateBoek_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 79);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 3;
            label2.Text = "Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 123);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 5;
            label3.Text = "Auteur";
            // 
            // tbAuteurUpdate
            // 
            tbAuteurUpdate.Location = new Point(187, 123);
            tbAuteurUpdate.Name = "tbAuteurUpdate";
            tbAuteurUpdate.Size = new Size(567, 27);
            tbAuteurUpdate.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 165);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 7;
            label4.Text = "Uitgever";
            // 
            // tbUitgeverUpdate
            // 
            tbUitgeverUpdate.Location = new Point(187, 165);
            tbUitgeverUpdate.Name = "tbUitgeverUpdate";
            tbUitgeverUpdate.Size = new Size(567, 27);
            tbUitgeverUpdate.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 221);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 10;
            label5.Text = "Taal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 269);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 11;
            label6.Text = "Graad";
            // 
            // tbGraadUpdate
            // 
            tbGraadUpdate.Location = new Point(187, 269);
            tbGraadUpdate.Name = "tbGraadUpdate";
            tbGraadUpdate.Size = new Size(567, 27);
            tbGraadUpdate.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(61, 315);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 13;
            label7.Text = "ISBN";
            // 
            // tbISBNUpdate
            // 
            tbISBNUpdate.Location = new Point(187, 315);
            tbISBNUpdate.Name = "tbISBNUpdate";
            tbISBNUpdate.Size = new Size(567, 27);
            tbISBNUpdate.TabIndex = 6;
            // 
            // comboBoxUpdateGenre
            // 
            comboBoxUpdateGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUpdateGenre.FormattingEnabled = true;
            comboBoxUpdateGenre.Location = new Point(187, 79);
            comboBoxUpdateGenre.Margin = new Padding(3, 4, 3, 4);
            comboBoxUpdateGenre.Name = "comboBoxUpdateGenre";
            comboBoxUpdateGenre.Size = new Size(567, 28);
            comboBoxUpdateGenre.TabIndex = 1;
            // 
            // comboBoxUpdateTaal
            // 
            comboBoxUpdateTaal.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUpdateTaal.FormattingEnabled = true;
            comboBoxUpdateTaal.Location = new Point(187, 221);
            comboBoxUpdateTaal.Margin = new Padding(3, 4, 3, 4);
            comboBoxUpdateTaal.Name = "comboBoxUpdateTaal";
            comboBoxUpdateTaal.Size = new Size(567, 28);
            comboBoxUpdateTaal.TabIndex = 14;
            // 
            // UpdateBoek
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 451);
            Controls.Add(comboBoxUpdateTaal);
            Controls.Add(comboBoxUpdateGenre);
            Controls.Add(tbISBNUpdate);
            Controls.Add(label7);
            Controls.Add(tbGraadUpdate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbUitgeverUpdate);
            Controls.Add(label4);
            Controls.Add(tbAuteurUpdate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnUpdateBoek);
            Controls.Add(tbTitelUpdate);
            Controls.Add(label1);
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
        private ComboBox comboBoxUpdateTaal;
    }
}