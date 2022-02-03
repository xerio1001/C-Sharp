namespace OpdrachtArrays1Dario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            int[] getal1 = new int[10];
            int[] getal2 = new int[10];
            int i = 0;
            int j = 0;

            Random rnd = new();

            do
            {
                int randomNum1 = rnd.Next(0, 11);
                getal1[i] = randomNum1;
                i++;
            }
            while(i < 10);


            do
            {
                int randomNum2 = rnd.Next(0, 11);
                getal2[j] = randomNum2;
                j++;
            }
            while (j < 10);


            for(int index = 0; index < getal1.Length; index++)
            {
                int resultaat = getal1[index] + getal2[index];
                TxtResultaat.AppendText(getal1[index] + " + " + getal2[index] + " = " + resultaat + Environment.NewLine);
            }

             
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtResultaat.Clear();
        }
    }
}