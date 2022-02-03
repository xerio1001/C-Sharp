namespace DebugTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
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