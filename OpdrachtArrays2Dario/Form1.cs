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
            Random rnd = new();
            int[] values = new int[6];
            int i = 0;

            do
            {
                int getal = rnd.Next(1, 46);
                bool inArray = false;

                foreach (int item in values)
                {
                    if(item == getal)
                    {
                        inArray = true; 
                        break; 
                    }
                }
                if (!inArray)
                {
                    values[i] = getal;
                    i++;
                }
            }
            while(i < 6);

            TxtResultaat.Text =
                "De 6 LOTTO-getallen zijn: " + Environment.NewLine +
                Environment.NewLine +
                "getal 1: " + values[0] + Environment.NewLine +
                "getal 2: " + values[1] + Environment.NewLine +
                "getal 3: " + values[2] + Environment.NewLine +
                "getal 4: " + values[3] + Environment.NewLine +
                "getal 5: " + values[4] + Environment.NewLine +
                "getal 6: " + values[5] + Environment.NewLine;
        }
    }
}