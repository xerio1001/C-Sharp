namespace DebugTest
{
    public partial class FrmDebuggen : Form
    {
        public FrmDebuggen()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            // Dit programma is geschreven om te leren 'debuggen'.
            int i = 0;

            do
            {
                i += 1;
                TxtResultaat.AppendText("Test " + i + Environment.NewLine);
            }
            while(true);
        }
    }
}