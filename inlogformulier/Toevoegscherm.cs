using Domain_bib.Business;
using Domain_bib.Persistence;
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
    public partial class Toevoegscherm : Form
    {
        Controller conn = new Controller();
        public Toevoegscherm()
        {
            InitializeComponent();
        }
        

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            string Titel = tbTitel.Text;
            int GenreId = Convert.ToInt32(tbGenreId.Text);
            string Auteur = tbAuteur.Text;
            string Uitgever = tbUitgever.Text;
            string Taal = tbTaal.Text;
            int graad = Convert.ToInt32(tbGraad.Text);
            string isbn = tbISBN.Text;

            conn.InsertBoek(Titel, GenreId, Auteur, Uitgever, Taal, graad, isbn);

            MessageBox.Show("Boek is toegevoegd");

            tbTitel.Clear();
            tbGenreId.Clear();
            tbAuteur.Clear();
            tbUitgever.Clear();
            tbTaal.Clear();
            tbGraad.Clear();
            tbISBN.Clear();
        }

       
    }
}
