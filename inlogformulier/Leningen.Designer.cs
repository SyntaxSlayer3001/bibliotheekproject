namespace inlogformulier
{
    partial class Leningen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leningen));
            lbUitleningen = new ListBox();
            btnLening = new Button();
            dtpStartdatum = new DateTimePicker();
            dtpEinddatum = new DateTimePicker();
            SuspendLayout();
            // 
            // lbUitleningen
            // 
            lbUitleningen.FormattingEnabled = true;
            lbUitleningen.Location = new Point(12, 12);
            lbUitleningen.Name = "lbUitleningen";
            lbUitleningen.Size = new Size(407, 424);
            lbUitleningen.TabIndex = 0;
            // 
            // btnLening
            // 
            btnLening.Location = new Point(473, 139);
            btnLening.Name = "btnLening";
            btnLening.Size = new Size(273, 59);
            btnLening.TabIndex = 1;
            btnLening.Text = "Nieuwe lening";
            btnLening.UseVisualStyleBackColor = true;
            btnLening.Click += btnLening_Click;
            // 
            // dtpStartdatum
            // 
            dtpStartdatum.Location = new Point(473, 12);
            dtpStartdatum.Name = "dtpStartdatum";
            dtpStartdatum.Size = new Size(250, 27);
            dtpStartdatum.TabIndex = 2;
            // 
            // dtpEinddatum
            // 
            dtpEinddatum.Location = new Point(473, 82);
            dtpEinddatum.Name = "dtpEinddatum";
            dtpEinddatum.Size = new Size(250, 27);
            dtpEinddatum.TabIndex = 3;
            // 
            // Leningen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(dtpEinddatum);
            Controls.Add(dtpStartdatum);
            Controls.Add(btnLening);
            Controls.Add(lbUitleningen);
            Name = "Leningen";
            Text = "Leningen";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbUitleningen;
        private Button btnLening;
        private DateTimePicker dtpStartdatum;
        private DateTimePicker dtpEinddatum;
    }
}