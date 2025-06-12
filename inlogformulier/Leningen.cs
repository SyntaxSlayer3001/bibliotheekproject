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
    public partial class Leningen : Form
    {
        private List<Lening> leninglijst = new();
        public Leningen()
        {
            InitializeComponent();
            LoadLeningen();
        }
        private void LoadLeningen()
        {
            var mapper = new Boekmapper();
            leninglijst = mapper.getleningen(); // Gebruik de juiste methode om leningen op te halen
            lbUitleningen.Items.Clear();
            foreach (var lening in leninglijst)
            {
                lbUitleningen.Items.Add(lening);
            }
        }
        private void btnLening_Click(object sender, EventArgs e)
        {
            try
            {
                // Voorbeeld: twee DateTimePickers op je formulier: dtpStartdatum en dtpEinddatum
                DateOnly startdatum = DateOnly.FromDateTime(dtpStartdatum.Value);
                DateOnly einddatum = DateOnly.FromDateTime(dtpEinddatum.Value);

                var mapper = new Boekmapper();
                mapper.InsertLening(startdatum, einddatum);

                MessageBox.Show("Lening succesvol toegevoegd!");
                LoadLeningen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij toevoegen lening: " + ex.Message);
            }
        }
    }
}
