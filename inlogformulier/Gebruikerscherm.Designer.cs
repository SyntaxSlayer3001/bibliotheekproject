namespace inlogformulier
{
    partial class Gebruikerscherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gebruikerscherm));
            tbBoekenlijst = new ListBox();
            btnRefresh = new Button();
            btnAflopend = new Button();
            btnOplopend = new Button();
            tbZoekTitel = new TextBox();
            label1 = new Label();
            btnUitloggen = new Button();
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
            // btnRefresh
            // 
            btnRefresh.BackgroundImage = (Image)resources.GetObject("btnRefresh.BackgroundImage");
            btnRefresh.BackgroundImageLayout = ImageLayout.Stretch;
            btnRefresh.Location = new Point(562, 91);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(81, 67);
            btnRefresh.TabIndex = 1;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAflopend
            // 
            btnAflopend.BackgroundImage = (Image)resources.GetObject("btnAflopend.BackgroundImage");
            btnAflopend.BackgroundImageLayout = ImageLayout.Stretch;
            btnAflopend.Location = new Point(678, 91);
            btnAflopend.Margin = new Padding(3, 4, 3, 4);
            btnAflopend.Name = "btnAflopend";
            btnAflopend.Size = new Size(81, 67);
            btnAflopend.TabIndex = 2;
            btnAflopend.UseVisualStyleBackColor = true;
            btnAflopend.Click += btnAflopend_Click;
            // 
            // btnOplopend
            // 
            btnOplopend.BackgroundImage = (Image)resources.GetObject("btnOplopend.BackgroundImage");
            btnOplopend.BackgroundImageLayout = ImageLayout.Stretch;
            btnOplopend.Location = new Point(799, 91);
            btnOplopend.Margin = new Padding(3, 4, 3, 4);
            btnOplopend.Name = "btnOplopend";
            btnOplopend.Size = new Size(81, 67);
            btnOplopend.TabIndex = 3;
            btnOplopend.UseVisualStyleBackColor = true;
            btnOplopend.Click += btnOplopend_Click;
            // 
            // tbZoekTitel
            // 
            tbZoekTitel.Location = new Point(678, 191);
            tbZoekTitel.Margin = new Padding(3, 4, 3, 4);
            tbZoekTitel.Name = "tbZoekTitel";
            tbZoekTitel.Size = new Size(202, 27);
            tbZoekTitel.TabIndex = 4;
            tbZoekTitel.TextChanged += tbZoekTitel_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(562, 191);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 5;
            label1.Text = "Zoeken op titel";
            // 
            // btnUitloggen
            // 
            btnUitloggen.Location = new Point(562, 12);
            btnUitloggen.Name = "btnUitloggen";
            btnUitloggen.Size = new Size(318, 67);
            btnUitloggen.TabIndex = 6;
            btnUitloggen.Text = "Uitloggen";
            btnUitloggen.UseVisualStyleBackColor = true;
            btnUitloggen.Click += btnUitloggen_Click;
            // 
            // Gebruikerscherm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnUitloggen);
            Controls.Add(label1);
            Controls.Add(tbZoekTitel);
            Controls.Add(btnOplopend);
            Controls.Add(btnAflopend);
            Controls.Add(btnRefresh);
            Controls.Add(tbBoekenlijst);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Gebruikerscherm";
            Text = "Gebruikerscherm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox tbBoekenlijst;
        private Button btnRefresh;
        private Button btnAflopend;
        private Button btnOplopend;
        private TextBox tbZoekTitel;
        private Label label1;
        private Button btnUitloggen;
    }
}