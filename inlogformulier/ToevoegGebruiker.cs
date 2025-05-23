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
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace inlogformulier
{
    public partial class ToevoegGebruiker : Form
    {
        Controller conn = new Controller();
        public ToevoegGebruiker()
        {
            InitializeComponent();
        }

        private void btnToevoegenGebruiker_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();
            string naam = tbNaam.Text.Trim();
            string voornaam = tbVoornaam.Text.Trim();
            string wachtwoord = tbWachtwoord.Text.Trim();
            int rechtId = int.TryParse(tbRechtID.Text, out int id) ? id : 0;

            MessageBox.Show("Gebruiker toegevoegd");
            conn.InsertGebruiker(email, naam, voornaam, wachtwoord, rechtId);

            tbEmail.Clear();
            tbNaam.Clear();
            tbVoornaam.Clear();
            tbWachtwoord.Clear();
            tbRechtID.Clear();
        }
    }
}
