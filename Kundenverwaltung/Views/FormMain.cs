using Kundenverwaltung.Data;
using Kundenverwaltung.Data.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
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

        private bool _Changed = false;

        public FormMain()
        {
            InitializeComponent();

            _SearchBindingSource = new BindingSource();
            dgvKunden.DataSource = _SearchBindingSource;
            
            RefreshView();
        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            using (FormEditKunde tEditKunde = new FormEditKunde())
            {
                DialogResult lResult = tEditKunde.ShowDialog();
                if (lResult == DialogResult.OK)
                {
                    tEditKunde.Kunde.Id = _Database.LastKundenID() + 1;
                    _Database.Kunden.Add(tEditKunde.Kunde);
                    _Changed = true;
                    RefreshView();
                }
            }
        }

        private async void RefreshView()
        {
            // update title
            StringBuilder sb = new StringBuilder("Kundenverwaltung");
            if (_Database != null)
            {
                sb.Append(" - ");
                if (_Changed)
                    sb.Append("*");
                sb.Append(_Database.FileName);
            }
            Text = sb.ToString();

            // disable / enable fields
            btnNew.Enabled =
                txbSuche.Enabled =
                dgvKunden.Enabled =
                speichernToolStripMenuItem.Enabled = 
                speichernAlsToolStripMenuItem.Enabled = _Database != null;

            if (_Database == null)
            {
                _SearchBindingSource.DataSource = null;
                return;
            }
            List<Kunde> lKunden = _Database.Kunden.Take(10).ToList();
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
                        { 
                            _Database.Kunden.Remove(tEditKunde.Kunde);
                        }
                        else
                        {
                            _Database.Kunden.Remove(tEditKunde.Kunde);
                            _Database.Kunden.Add(tEditKunde.Kunde);
                        }
                        _Changed = true;
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

            List<Kunde> lKunden = _Database.Kunden.Where(
                k =>
                    k.Firmenname.Contains(lSuche) ||
                    k.Ansprechpartner.Contains(lSuche) ||
                    k.Ort.Contains(lSuche) ||
                    k.PLZ == lSuche).Take(10).ToList();
            _SearchBindingSource.DataSource = lKunden;
        }

        private bool SaveCheck()
        {
            if (_Database == null)
                return true;

            if (_Changed)
            {
                DialogResult lResult = MessageBox.Show(this, "Sie haben noch ungespeicherte Änderungen. Wollen Sie wirklich fortfahren, Herr Hüther?", "Kundenverwaltung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (lResult != DialogResult.Yes)
                    return false;
            }
            return true;
        }

        private void beendenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!SaveCheck())
                return;

            // murder :o
            Process.GetCurrentProcess().Kill();
        }

        private void neuToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!SaveCheck())
                return;

            _Database = new Database(null);
            RefreshView();
        }

        private void datenbanköffnenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!SaveCheck())
                return;

            using (OpenFileDialog tDialog = new OpenFileDialog())
            {
                tDialog.CheckFileExists = true;
                tDialog.Filter = "Kundendaten|*.cdat";
                tDialog.Multiselect = false;
                tDialog.AddExtension = true;
                DialogResult lResult = tDialog.ShowDialog(this);
                if (lResult != DialogResult.OK)
                    return;
                _Database = new Database(tDialog.FileName);
                if (!_Database.Load())
                {
                    MessageBox.Show(this, "Die ausgewählte Datei konnte nicht geladen werden. Bitte stellen Sie sicher, dass es eine Kundendaten Datei ist.", "Kundenverwaltung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _Database = null;
                    RefreshView();
                    return;
                }
            }

            RefreshView();
        }

        private void speichernToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_Database == null)
                return;

            if (_Database.FileName == null)
            {
                speichernAlsToolStripMenuItem_Click(sender, e);
                return;
            }

            if (!_Database.Save())
            {
                DialogResult lResult = MessageBox.Show(this, "Die Datenbank konnte nicht gespeichert werden.", "Kundenverwaltung", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (lResult == DialogResult.Retry)
                {
                    speichernToolStripMenuItem_Click(sender, e);
                }
                return;
            }
            _Changed = false;
            RefreshView();
        }

        private void speichernAlsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_Database == null)
                return;

            using (SaveFileDialog tDialog = new SaveFileDialog())
            {
                tDialog.CheckFileExists = false;
                tDialog.DefaultExt = ".cdat";
                tDialog.Filter = "Kundendaten|*.cdat";
                DialogResult lResult = tDialog.ShowDialog(this);
                if (lResult != DialogResult.OK)
                    return;
                _Database.FileName = tDialog.FileName;
                speichernToolStripMenuItem_Click(sender, e);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            beendenToolStripMenuItem_Click(sender, e);
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control)
                return;

            if (e.KeyCode == Keys.S)
            {
                speichernToolStripMenuItem_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.O)
            {
                datenbanköffnenToolStripMenuItem_Click(sender, e);
            }
        }

        private void dgvKunden_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
            _Database.Kunden.Remove(CurrentKunde);
            _Changed = true;
            RefreshView();
        }
    }
}
