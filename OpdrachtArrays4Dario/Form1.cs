namespace OpdrachtArrays4Dario
{
    public partial class OpdrachtArrays4Dario : Form
    {
        public OpdrachtArrays4Dario()
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
            TxtAantalSeconden.Clear();
            TxtNaamAtleet.Clear();
            TxtNaamAtleet.Focus();
        }

        private void BtnToonVolgorde_Click(object sender, EventArgs e)
        {

        }

        private void BtnNieuwInvoer_Click(object sender, EventArgs e)
        {
            string naam = "";
            double second = 0;

            string[] namen = new string[100];
            double[] seconden = new double[100];

            try
            {
                naam = TxtNaamAtleet.Text.Trim();
            }
            catch
            {
                MessageBox.Show("Geef een juiste waarde in.", "Error");
            }

            try
            {
                second = Convert.ToDouble(TxtAantalSeconden.Text);
            }
            catch
            {
                MessageBox.Show("Geef een juiste numerieke waarde in.", "Error");
            }

            namen.Append(naam);
            seconden.Append(second);
        }
    }
}