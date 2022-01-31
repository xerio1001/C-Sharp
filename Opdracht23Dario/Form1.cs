namespace Opdracht23Dario
{
    public partial class FrmOpdracht23Dario : Form
    {
        public FrmOpdracht23Dario()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            int i = 0;
            int getal;
            Random rnd = new Random();

            do
            {
                getal = rnd.Next(1, 7);

                i++;

                TxtResultaat.AppendText("Worp " + i.ToString() + " Geeft " + getal.ToString() + Environment.NewLine);
            }
            while (getal != 6);
        }

        private void BtnOpnieuw_Click(object sender, EventArgs e)
        {
            TxtResultaat.Clear();
            BtnStart.Focus();
        }
    }
}