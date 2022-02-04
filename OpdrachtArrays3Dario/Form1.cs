namespace OpdrachtArrays3Dario
{
    public partial class FrmOpdrachtArrays3Dario : Form
    {
        public FrmOpdrachtArrays3Dario()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtTotaalBedrag.Clear();
            TxtResultaat.Clear();
            TxtTotaalBedrag.Focus();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            double getal;

            try 
            {
                getal = Convert.ToDouble(TxtTotaalBedrag.Text);
                if(getal < 0)
                {
                    MessageBox.Show("Geef een waarde hoger dan 0 in.", "Fout");
                    TxtTotaalBedrag.Clear();
                    TxtTotaalBedrag.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Geef een geldig numerieke waarde in.", "Fout");
                TxtTotaalBedrag.Clear();
                TxtTotaalBedrag.Focus();
                return;
            }



            TxtResultaat.Text =
                /* stuks + */ " stuks van " /* waarde */ + Environment.NewLine;
        }
    }
}