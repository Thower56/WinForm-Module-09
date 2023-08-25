using System.Security.Cryptography;

namespace Module_09___Super_bloc_notes
{
    public partial class fPrincipale : Form
    {
        public fPrincipale()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tsmiNouveau_Click(object sender, EventArgs e)
        {
            if (!textChanged || tbTexte.Text == string.Empty)
            {
                this.filePath = null;
                tbTexte.ResetText();
            }
            else 
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save before?", "Nouveau", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    this.tsmiEnregistrer_Click(sender, e);
                    tbTexte.ResetText();
                    this.filePath = null;
                }
                else 
                {
                    tbTexte.ResetText();
                    this.filePath = null;
                }
            }
        }

        private void tbTexte_TextChanged(object sender, EventArgs e)
        {
            this.textChanged = true;
        }

        private void tsmiOuvrir_Click(object sender, EventArgs e)
        {
            if (!textChanged)
            {
                openFile();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save before?", "Ouvrir", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    this.tsmiEnregistrer_Click(sender, e);
                }
                else
                {
                    openFile();
                }
            }
            
        }

        private void tsmiEnregistrer_Click(object sender, EventArgs e)
        {
            if (filePath != null)
            {
                File.WriteAllText(filePath, tbTexte.Text);
            }
            else 
            {
                saveFile();
            }
        }

        private void tsmiEnregistrerSous_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void fPrincipale_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tbTexte.Text != string.Empty)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save before quitting ?", "Quitter", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    this.tsmiEnregistrer_Click(sender, e);
                }
            }
        }

        private void tsmiQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFile() 
        {
            Stream myStream = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fichier Text (*.txt)|*.txt";

            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                filePath = ofd.FileName;
                try
                {
                    tbTexte.Text = File.ReadAllText(ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: N'a pas pu ouvrir le fichier");
                }
            }
        }
        private void saveFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            DialogResult dr = sfd.ShowDialog();
            sfd.Filter = "Fichier Text (*.txt)|*.txt";
            //sfd.DefaultExt = "txt";
            //sfd.AddExtension = true;
            sfd.FilterIndex = 0;
            if (dr == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, tbTexte.Text);
            }
        }

        private void tsmiCopier_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbTexte.Text);
        }

        private void tsmiCouper_Click(object sender, EventArgs e)
        {
            tbTexte.Cut();
        }

        private void tsmiColler_Click(object sender, EventArgs e)
        {
            tbTexte.SelectedText = Clipboard.GetText();
        }
    }
}