using Kundenverwaltung.Data;
using Kundenverwaltung.Data.Models;
using LinqToDB;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Kundenverwaltung.Views
{
    public partial class FormMain : Form
    {
        private Database _Database;

        private BindingSource _SearchBindingSource;

        private Kunde CurrentKunde
        {
            get
            {
                if (dgvKunden.SelectedRows.Count > 0)
                {
                    Kunde lKunde = dgvKunden.SelectedRows[0].DataBoundItem as Kunde;
                    if (lKunde != null)
                    {
                        return lKunde;
                    }
                }
                return null;
            }
        }

        public FormMain()
        {
            InitializeComponent();
            _SearchBindingSource = new BindingSource();
            dgvKunden.DataSource = _SearchBindingSource;

            _Database = new Database();
            RefreshView();
        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            using (FormEditKunde tEditKunde = new FormEditKunde())
            {
                DialogResult lResult = tEditKunde.ShowDialog();
                if (lResult == DialogResult.OK)
                {
                    _Database.Insert(tEditKunde.Kunde);
                    RefreshView();
                }
            }
        }

        private async void RefreshView()
        {
            List<Kunde> lKunden = await _Database.Kunden.Take(() => 10).ToListAsync();
            _SearchBindingSource.DataSource = lKunden;
        }

        private void dgvKunden_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Kunde lKunde = CurrentKunde;
            if (lKunde != null)
            {
                using (FormEditKunde tEditKunde = new FormEditKunde(lKunde))
                {
                    DialogResult lResult = tEditKunde.ShowDialog();
                    if (lResult == DialogResult.OK)
                    {
                        if (tEditKunde.Kunde == null)
                            _Database.Delete(lKunde);
                        else
                            _Database.Update(lKunde);
                        RefreshView();
                    }
                }
            }
        }

        private string lasttext = "";
        private async void txbSuche_KeyUp(object sender, KeyEventArgs e)
        {
            string lSuche = txbSuche.Text;
            if (string.IsNullOrWhiteSpace(lSuche))
            {
                RefreshView();
                return;
            }
            if (lasttext == lSuche)
                return;
            lasttext = lSuche;

            List<Kunde> lKunden = await _Database.Kunden.Where(
                k =>
                    k.Firmenname.Contains(lSuche) ||
                    k.Ansprechpartner.Contains(lSuche) ||
                    k.Ort.Contains(lSuche) ||
                    k.PLZ == lSuche).Take(() => 10).ToListAsync();
            _SearchBindingSource.DataSource = lKunden;
        }
    }
}
