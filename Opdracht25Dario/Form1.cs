namespace Opdracht25Dario
{
    public partial class FrmOpdracht25Dario : Form
    {
        public FrmOpdracht25Dario()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtGewenstBedrag.Clear();
            TxtResultaat.Clear();
            TxtVerhoging.Clear();
            TxtWeekgeld.Clear();
            TxtWeekgeld.Focus();
        }

        private void BtnBerekenen_Click(object sender, EventArgs e)
        {
            int weekgeld;
            int verhoging;
            int aantalWeken = 0;
            int totaalBedrag = 0;
            int tussenBedrag = 0;
            int totaalSpaarbedrag = 0;

            try
            {
                weekgeld = Convert.ToInt16(TxtWeekgeld.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in.");
            }

            try
            {
                verhoging = Convert.ToInt16(TxtVerhoging.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in.");
            }

            TxtResultaat.Text =
                "Spaarbedrag na " + aantalWeken.ToString() + " Weken: " + totaalBedrag.ToString("C") + Environment.NewLine +
                "Extra weekgeld op dat moment: " + tussenBedrag + Environment.NewLine +
                "Totaal spaargeld: " + totaalSpaarbedrag;

        }
    }
}