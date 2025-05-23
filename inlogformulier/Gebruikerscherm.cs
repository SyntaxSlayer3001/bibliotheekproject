using Domain_bib.Persistence;
using Domain_bib.Business;
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
    public partial class Gebruikerscherm : Form
    {
        private List<Boek> boekenlijst = new List<Boek>();

        public Gebruikerscherm()
        {
            InitializeComponent();
            LoadBoeken();
        }

        private void LoadBoeken()
        {
            var mapper = new Boekmapper();
            boekenlijst = mapper.GetBoeken();
            UpdateListBox(boekenlijst);
        }

        private void UpdateListBox(IEnumerable<Boek> boeken)
        {
            tbBoekenlijst.Items.Clear();
            foreach (var boek in boeken)
            {
                tbBoekenlijst.Items.Add(boek); // ToString() wordt automatisch gebruikt
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBoeken();
        }

        private void btnAflopend_Click(object sender, EventArgs e)
        {
            var sorted = boekenlijst.OrderBy(b => b.Titel).ToList();
            UpdateListBox(sorted);
        }

        private void btnOplopend_Click(object sender, EventArgs e)
        {
            var sorted = boekenlijst.OrderByDescending(b => b.Titel).ToList();
            UpdateListBox(sorted);
        }
    }
}
