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
            double weekgeld;
            double verhoging;
            double gewenstBedrag;
            double totaalBedrag = 0;
            int aantalWeken = 0;
            double tussenBedrag = 0;
            double totaalVerhoging = 0;
            

            try
            {
                weekgeld = Convert.ToDouble(TxtWeekgeld.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in.");
                return;
            }


            try
            {
                verhoging = Convert.ToDouble(TxtVerhoging.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in.");
                return;
            }


            try
            {
                gewenstBedrag = Convert.ToDouble(TxtGewenstBedrag.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in.");
                return;
            }



            do
            {
                totaalBedrag += weekgeld + verhoging;
                tussenBedrag += weekgeld;
                totaalVerhoging += verhoging;

                aantalWeken++;
            }
            while (totaalBedrag < gewenstBedrag);



            TxtResultaat.Text = 
                "Na " + aantalWeken.ToString() + " weken heb je: " + tussenBedrag.ToString("C") + Environment.NewLine +
                Environment.NewLine +
                "Extra weekgeld verdient op dat moment: " + totaalVerhoging.ToString("C") + Environment.NewLine +
                Environment.NewLine +
                "Totaal spaargeld: " + totaalBedrag.ToString("C");
        }
    }
}