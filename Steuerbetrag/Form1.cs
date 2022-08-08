namespace Steuerbetrag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_berechnen_Click(object sender, EventArgs e)
        {
            double Steuerbetrag;

            switch (Convert.ToDouble(txt_gehalt.Text))
            {
                case double gehalt when (0 < gehalt && gehalt < 12000):
                    Steuerbetrag = gehalt * 0.12;
                    break;

                case double gehalt when (12000 < gehalt && gehalt < 20000):
                    Steuerbetrag = gehalt * 0.15;
                    break;

                case double gehalt when (20000 < gehalt && gehalt < 30000):
                    Steuerbetrag = gehalt * 0.2;
                    break;

                case double gehalt when (30000 < gehalt):
                    Steuerbetrag = gehalt * 0.25;
                    break;

                default:
                    Steuerbetrag = 0.0;
                    break;
            }

            lbl_steuerbetrag.Text = "Steurbetrag: " + Steuerbetrag;
        }

        private void txt_gehalt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}