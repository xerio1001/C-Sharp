namespace Opdracht24Dario
{
    public partial class FrmOpdracht24Dario : Form
    {
        public FrmOpdracht24Dario()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtLand.Clear();
            TxtHuidigBevolk.Clear();
            TxtGroeiperc.Clear();
            TxtResultaat.Clear();
            TxtLand.Focus();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            string land;
            float huidigeBevolking;
            float groeiPercentage;
            int jaren = 0;

            try
            {
                land = TxtLand.Text;
                if (String.IsNullOrEmpty(land))
                {
                    MessageBox.Show("Geef een land in.");
                    TxtLand.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Geef een land in.");
                return;
            }

            try
            {
                huidigeBevolking = float.Parse(TxtHuidigBevolk.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in.");
                TxtHuidigBevolk.Focus();
                return;
            }

            try
            {
                groeiPercentage = float.Parse(TxtGroeiperc.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in.");
                TxtGroeiperc.Focus();
                return;
            }

            if (groeiPercentage <= 0)
            {
                MessageBox.Show("zonder een groeipercentage kan de bevolking niet verdubbelen.");
                TxtGroeiperc.Clear();
                TxtResultaat.Clear();
                TxtGroeiperc.Focus();
            }
            else
            {
                float maxBevolking = huidigeBevolking * 2;

                do
                {
                    huidigeBevolking = Convert.ToInt32(huidigeBevolking + (huidigeBevolking / 100 * groeiPercentage));
                    jaren++;
                }
                while (huidigeBevolking < maxBevolking);

                TxtResultaat.Text =
                    "Verdubbeling bevolking in " + land + " na " + jaren + " Jaren." + Environment.NewLine +
                    "Nieuw bevolkingsaantal op dat moment: " + huidigeBevolking + ".";
            }
        }
    }
}