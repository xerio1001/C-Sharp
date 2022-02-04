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
            TxtResultaat.Clear();
            double getal;
            int getalInt;
            string[] waardes = { "500", "200", "100", "50", "20", "10", "5", "2", "1", "0.5", "0.2", "0.1", "0.05", "0.02", "0.01" };
            int[] values = { 50000, 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] resultaten = new int[15];

            try
            {
                getal = Convert.ToDouble(TxtTotaalBedrag.Text);
                getal *= 100;
                getalInt = Convert.ToInt32(getal);

                if (getalInt <= 0)
                {
                    MessageBox.Show("Geef een waarde hoger dan 0 in.", "Error");
                    TxtTotaalBedrag.Clear();
                    TxtTotaalBedrag.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Geef een geldig numerieke waarde in.", "Error");
                TxtTotaalBedrag.Clear();
                TxtTotaalBedrag.Focus();
                return;
            }

            for (int i = 0; i < values.Length; i++)
            {
                resultaten[i] = getalInt / values[i];
                getalInt %= values[i];
                if(resultaten[i] > 0)
                {
                    TxtResultaat.AppendText(resultaten[i] + " muntstukken van " + waardes[i] + Environment.NewLine);
                } 
            }
                
        }
    }
}