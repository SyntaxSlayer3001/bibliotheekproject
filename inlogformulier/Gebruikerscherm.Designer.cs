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
            btnRefresh.Location = new Point(562, 16);
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
            btnAflopend.Location = new Point(681, 16);
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
            btnOplopend.Location = new Point(802, 16);
            btnOplopend.Margin = new Padding(3, 4, 3, 4);
            btnOplopend.Name = "btnOplopend";
            btnOplopend.Size = new Size(81, 67);
            btnOplopend.TabIndex = 3;
            btnOplopend.UseVisualStyleBackColor = true;
            btnOplopend.Click += btnOplopend_Click;
            // 
            // Gebruikerscherm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnOplopend);
            Controls.Add(btnAflopend);
            Controls.Add(btnRefresh);
            Controls.Add(tbBoekenlijst);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Gebruikerscherm";
            Text = "Gebruikerscherm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox tbBoekenlijst;
        private Button btnRefresh;
        private Button btnAflopend;
        private Button btnOplopend;
    }
}