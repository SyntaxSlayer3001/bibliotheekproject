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
    public partial class Beheerderscherm : Form
    {
        Controller conn = new Controller();
        public Beheerderscherm()
        {
            InitializeComponent();
            LoadBoeken();
        }

        private void LoadBoeken()
        {
            var mapper = new Boekmapper();
            var boekenlijst = mapper.GetBoeken();
            tbBoekenlijst.Items.Clear();
            foreach (var boeken in boekenlijst)
            {
                tbBoekenlijst.Items.Add(boeken); // ToString() wordt automatisch gebruikt
            }
        }

        private void btnAddboek_Click(object sender, EventArgs e)
        {
            Form form = new Toevoegscherm();
            form.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBoeken();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Form form = new ToevoegGebruiker();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Vraag om het BoekID
            string input = Interaction.InputBox("Geef het BoekID van het boek dat je wilt updaten:", "BoekID invoeren", "");
            if (!int.TryParse(input, out int boekenId) || boekenId <= 0)
            {
                MessageBox.Show("Ongeldig BoekID.");
                return;
            }
            Form form = new UpdateBoek(boekenId); // Geef het ID mee
            form.ShowDialog();
        }

        private void btnDeleteBoek_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Geef het BoekID van het boek dat je wilt verwijderen:", "BoekID invoeren", "");
            if (!int.TryParse(input, out int boekenId) || boekenId <= 0)
            {
                MessageBox.Show("Ongeldig BoekID.");
                return;
            }
            else
            {                 conn.DeleteBoek(boekenId);
                MessageBox.Show("Boek is verwijderd.");
                LoadBoeken();
            }
        }
    }
}
