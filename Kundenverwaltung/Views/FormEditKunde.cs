using Kundenverwaltung.Data.Models;
using System.Windows.Forms;

namespace Kundenverwaltung.Views
{
    public partial class FormEditKunde : Form
    {
        public Kunde Kunde { get; private set; }

        public FormEditKunde(Kunde pKunde = null)
        {
            InitializeComponent();

            Kunde = pKunde;

            if (Kunde == null)
                Text = "Neuer Kunde";
            else
                Text = $"Kunde bearbeiten - {Kunde.Firmenname} ({Kunde.Id})";

            if (Kunde != null)
            {
                txbId.Text = "" + Kunde.Id;
                txbFirmenname.Text = Kunde.Firmenname;
                txbAnsprechpartner.Text = Kunde.Ansprechpartner;
                txbPLZ.Text = Kunde.PLZ;
                txbOrt.Text = Kunde.Ort;
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (Kunde == null)
                Kunde = new Kunde();
            Kunde.Firmenname = txbFirmenname.Text;
            Kunde.Ansprechpartner = txbAnsprechpartner.Text;
            Kunde.PLZ = txbPLZ.Text;
            Kunde.Ort = txbOrt.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            DialogResult lResult = MessageBox.Show(this, "Sind sie sicher das Sie diesen Kunden löschen möchten?", "Kunde löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (lResult == DialogResult.Yes)
            {
                Kunde.Deleted = true;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
