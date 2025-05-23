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
            // btnRefresh
            // 
            btnRefresh.BackgroundImage = (Image)resources.GetObject("btnRefresh.BackgroundImage");
            btnRefresh.BackgroundImageLayout = ImageLayout.Stretch;
            btnRefresh.Location = new Point(492, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(71, 50);
            btnRefresh.TabIndex = 1;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAflopend
            // 
            btnAflopend.BackgroundImage = (Image)resources.GetObject("btnAflopend.BackgroundImage");
            btnAflopend.BackgroundImageLayout = ImageLayout.Stretch;
            btnAflopend.Location = new Point(596, 12);
            btnAflopend.Name = "btnAflopend";
            btnAflopend.Size = new Size(71, 50);
            btnAflopend.TabIndex = 2;
            btnAflopend.UseVisualStyleBackColor = true;
            btnAflopend.Click += btnAflopend_Click;
            // 
            // btnOplopend
            // 
            btnOplopend.BackgroundImage = (Image)resources.GetObject("btnOplopend.BackgroundImage");
            btnOplopend.BackgroundImageLayout = ImageLayout.Stretch;
            btnOplopend.Location = new Point(702, 12);
            btnOplopend.Name = "btnOplopend";
            btnOplopend.Size = new Size(71, 50);
            btnOplopend.TabIndex = 3;
            btnOplopend.UseVisualStyleBackColor = true;
            btnOplopend.Click += btnOplopend_Click;
            // 
            // tbZoekTitel
            // 
            tbZoekTitel.Location = new Point(596, 87);
            tbZoekTitel.Name = "tbZoekTitel";
            tbZoekTitel.Size = new Size(177, 23);
            tbZoekTitel.TabIndex = 4;
            tbZoekTitel.TextChanged += tbZoekTitel_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(492, 90);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 5;
            label1.Text = "Zoeken op titel";
            // 
            // Gebruikerscherm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(tbZoekTitel);
            Controls.Add(btnOplopend);
            Controls.Add(btnAflopend);
            Controls.Add(btnRefresh);
            Controls.Add(tbBoekenlijst);
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
    }
}