using Domain_bib.Business;
using Domain_bib.Persistence;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inlogformulier
{
    public partial class UpdateBoek : Form
    {
        private int _boekenId;

        public UpdateBoek(int boekenId)
        {
            InitializeComponent();
            _boekenId = boekenId;
        }

        Controller conn = new Controller();

        private void btnUpdateBoek_Click(object sender, EventArgs e)
        {
            // Verzamel de nieuwe waarden
            string titel = tbTitelUpdate.Text.Trim();
            int genreId = int.TryParse(tbGenreIDUpdate.Text, out int id) ? id : 0;
            string auteur = tbAuteurUpdate.Text.Trim();
            string uitgever = tbUitgeverUpdate.Text.Trim();
            string taal = tbTaalUpdate.Text.Trim();
            int graad = int.TryParse(tbGraadUpdate.Text, out int graadId) ? graadId : 0;
            string isbn = tbISBNUpdate.Text.Trim();

            // Update het boek
            conn.UpdateBoek(_boekenId, titel, genreId, auteur, uitgever, taal, graad, isbn);
            MessageBox.Show("Boek geüpdatet");

            // Velden leegmaken
            tbAuteurUpdate.Clear();
            tbGenreIDUpdate.Clear();
            tbGraadUpdate.Clear();
            tbISBNUpdate.Clear();
            tbTitelUpdate.Clear();
            tbTaalUpdate.Clear();
            tbUitgeverUpdate.Clear();
        }
    }
}
