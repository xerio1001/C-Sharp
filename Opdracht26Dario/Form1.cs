namespace Opdracht26Dario
{
    public partial class FrmOpdracht26Dario : Form
    {
        public FrmOpdracht26Dario()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtGewenstKap.Clear();
            TxtIntrest.Clear();
            TxtResultaat.Clear();
            TxtbeginKap.Clear();
            TxtbeginKap.Focus();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            double beginKap = 0;
            double gewenstKap = 0;
            double intrestVoet = 0;
            int aantalJaren = 0;

            try
            {
                beginKap = Convert.ToDouble(TxtbeginKap.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in.");
            }

            try
            {
                gewenstKap = Convert.ToDouble(TxtGewenstKap.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in.");
            }

            try
            {
                intrestVoet = Convert.ToDouble(TxtIntrest.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in.");
            }

            do
            {
                beginKap += beginKap / 100 * intrestVoet;
                aantalJaren += 1;

                TxtResultaat.AppendText("Waarde na " + aantalJaren.ToString() + " jaren: " + beginKap.ToString("C") + Environment.NewLine);
            }
            while(beginKap < gewenstKap);
        }
    }
}