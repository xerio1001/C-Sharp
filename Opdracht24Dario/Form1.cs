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

        }
    }
}