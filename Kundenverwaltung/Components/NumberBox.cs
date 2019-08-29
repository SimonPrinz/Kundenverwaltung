using System.Windows.Forms;

namespace Kundenverwaltung.Components
{
    public class NumberBox : TextBox
    {
        public double Number { get { return double.Parse(Text); } set { Text = value.ToString(); } }

        public NumberBox()
        {
            KeyPress += new KeyPressEventHandler((sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            });
        }
    }
}
