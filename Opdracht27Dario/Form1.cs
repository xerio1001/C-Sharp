namespace Opdracht27Dario
{
    public partial class FrmOpdracht27Dario : Form
    {
        public FrmOpdracht27Dario()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOpnieuw_Click(object sender, EventArgs e)
        {
            TxtResultaat.Clear();
            TxtHexaDecGetal.Clear();
            TxtHexaDecGetal.Focus();
        }

        private void BtnOmzetten_Click(object sender, EventArgs e)
        {
            long getal;

            try
            {
                getal = Convert.ToInt64(TxtHexaDecGetal.Text, 16);
            }
            catch
            {
                MessageBox.Show("Geef een geldige waarde in.");
                return;
            }

            TxtResultaat.Text = getal.ToString("N");
        }

        private void TxtHexaDecGetal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 'A' || e.KeyChar > 'F') && (e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }
    }
}