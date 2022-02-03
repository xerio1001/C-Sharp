namespace OpdrachtArrays2Dario
{
    public partial class FrmOpdrachtArray2Dario : Form
    {
        public FrmOpdrachtArray2Dario()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtResultaat.Clear();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {

        }
    }
}