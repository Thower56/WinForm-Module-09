namespace Module_09___Super_bloc_notes
{
    partial class fPrincipale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private string filePath = null;
        private bool textChanged = false;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPrincipale));
            this.msMenuPrincipale = new System.Windows.Forms.MenuStrip();
            this.tsmiFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEnregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEnregistrerSous = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdition = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCouper = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColler = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTexte = new System.Windows.Forms.TextBox();
            this.msMenuPrincipale.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuPrincipale
            // 
            this.msMenuPrincipale.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenuPrincipale.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFichier,
            this.tsmiEdition});
            this.msMenuPrincipale.Location = new System.Drawing.Point(0, 0);
            this.msMenuPrincipale.Name = "msMenuPrincipale";
            this.msMenuPrincipale.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.msMenuPrincipale.Size = new System.Drawing.Size(782, 30);
            this.msMenuPrincipale.TabIndex = 0;
            this.msMenuPrincipale.Text = "menuStrip1";
            // 
            // tsmiFichier
            // 
            this.tsmiFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNouveau,
            this.tsmiOuvrir,
            this.tsmiEnregistrer,
            this.tsmiEnregistrerSous,
            this.toolStripSeparator1,
            this.tsmiQuitter});
            this.tsmiFichier.Name = "tsmiFichier";
            this.tsmiFichier.Size = new System.Drawing.Size(66, 24);
            this.tsmiFichier.Text = "&Fichier";
            // 
            // tsmiNouveau
            // 
            this.tsmiNouveau.Name = "tsmiNouveau";
            this.tsmiNouveau.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiNouveau.Size = new System.Drawing.Size(295, 26);
            this.tsmiNouveau.Text = "&Nouveau";
            this.tsmiNouveau.Click += new System.EventHandler(this.tsmiNouveau_Click);
            // 
            // tsmiOuvrir
            // 
            this.tsmiOuvrir.Name = "tsmiOuvrir";
            this.tsmiOuvrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOuvrir.Size = new System.Drawing.Size(295, 26);
            this.tsmiOuvrir.Text = "&Ouvrir";
            this.tsmiOuvrir.Click += new System.EventHandler(this.tsmiOuvrir_Click);
            // 
            // tsmiEnregistrer
            // 
            this.tsmiEnregistrer.Name = "tsmiEnregistrer";
            this.tsmiEnregistrer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiEnregistrer.Size = new System.Drawing.Size(295, 26);
            this.tsmiEnregistrer.Text = "&Enregistrer";
            this.tsmiEnregistrer.Click += new System.EventHandler(this.tsmiEnregistrer_Click);
            // 
            // tsmiEnregistrerSous
            // 
            this.tsmiEnregistrerSous.Name = "tsmiEnregistrerSous";
            this.tsmiEnregistrerSous.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiEnregistrerSous.Size = new System.Drawing.Size(295, 26);
            this.tsmiEnregistrerSous.Text = "&Enregistrer sous...";
            this.tsmiEnregistrerSous.Click += new System.EventHandler(this.tsmiEnregistrerSous_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(292, 6);
            // 
            // tsmiQuitter
            // 
            this.tsmiQuitter.Name = "tsmiQuitter";
            this.tsmiQuitter.Size = new System.Drawing.Size(295, 26);
            this.tsmiQuitter.Text = "&Quitter";
            this.tsmiQuitter.Click += new System.EventHandler(this.tsmiQuitter_Click);
            // 
            // tsmiEdition
            // 
            this.tsmiEdition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopier,
            this.tsmiCouper,
            this.tsmiColler});
            this.tsmiEdition.Name = "tsmiEdition";
            this.tsmiEdition.Size = new System.Drawing.Size(70, 24);
            this.tsmiEdition.Text = "Edition";
            // 
            // tsmiCopier
            // 
            this.tsmiCopier.Name = "tsmiCopier";
            this.tsmiCopier.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiCopier.Size = new System.Drawing.Size(224, 26);
            this.tsmiCopier.Text = "Copier";
            this.tsmiCopier.Click += new System.EventHandler(this.tsmiCopier_Click);
            // 
            // tsmiCouper
            // 
            this.tsmiCouper.Name = "tsmiCouper";
            this.tsmiCouper.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiCouper.Size = new System.Drawing.Size(224, 26);
            this.tsmiCouper.Text = "Couper";
            this.tsmiCouper.Click += new System.EventHandler(this.tsmiCouper_Click);
            // 
            // tsmiColler
            // 
            this.tsmiColler.Name = "tsmiColler";
            this.tsmiColler.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiColler.Size = new System.Drawing.Size(224, 26);
            this.tsmiColler.Text = "Coller";
            this.tsmiColler.Click += new System.EventHandler(this.tsmiColler_Click);
            // 
            // tbTexte
            // 
            this.tbTexte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTexte.Location = new System.Drawing.Point(14, 36);
            this.tbTexte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTexte.Multiline = true;
            this.tbTexte.Name = "tbTexte";
            this.tbTexte.Size = new System.Drawing.Size(754, 499);
            this.tbTexte.TabIndex = 1;
            this.tbTexte.TextChanged += new System.EventHandler(this.tbTexte_TextChanged);
            // 
            // fPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tbTexte);
            this.Controls.Add(this.msMenuPrincipale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenuPrincipale;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "fPrincipale";
            this.Text = "Super Bloc-notes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fPrincipale_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msMenuPrincipale.ResumeLayout(false);
            this.msMenuPrincipale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip msMenuPrincipale;
        private ToolStripMenuItem tsmiFichier;
        private ToolStripMenuItem tsmiNouveau;
        private ToolStripMenuItem tsmiOuvrir;
        private ToolStripMenuItem tsmiEnregistrer;
        private ToolStripMenuItem tsmiEnregistrerSous;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmiQuitter;
        private TextBox tbTexte;
        private ToolStripMenuItem tsmiEdition;
        private ToolStripMenuItem tsmiCopier;
        private ToolStripMenuItem tsmiCouper;
        private ToolStripMenuItem tsmiColler;
    }
}