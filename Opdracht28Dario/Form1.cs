using Microsoft.VisualBasic;

namespace Opdracht28Dario
{
    public partial class FrmOpdracht28Dario : Form
    {
        public FrmOpdracht28Dario()
        {
            InitializeComponent();
            PicBoxResultaat.Image = null;
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            PicBoxResultaat.Image = null;
            Random rnd = new Random();
            int uitkomst = rnd.Next(0,101);
            int beurten = 1;

            do { 
                try
                {
                    string input = Interaction.InputBox("Geef een getal tussen 0 en 100", "Raadspel");
                    int getal = Convert.ToInt16(input);


                    if (getal <= 100 && getal >= 0)
                    {

                        if (getal < uitkomst)
                        {
                            PicBoxResultaat.Image = Properties.Resources.arrowUpSmall;
                            MessageBox.Show("Raad hoger", "Raadspel");
                        }
                        else if (getal > uitkomst)
                        {
                            PicBoxResultaat.Image = Properties.Resources.arrowDownSmall;
                            MessageBox.Show("Raad lager", "Raadspel");
                        }
                        else
                        {
                            PicBoxResultaat.Image = Properties.Resources.goodJobSmall;
                            MessageBox.Show("U heeft het getal geraden in " + beurten.ToString() + " beurten!", "Proficiat!");
                            break;
                        }

                        beurten += 1;

                    }
                    else
                    {
                        MessageBox.Show("De waarde die u heeft ingegeven is buiten de aangegeven grenzen.", "Fout");
                    }
                }
                catch
                {
                    MessageBox.Show("U heeft niks ingevuld.", "Fout");
                }
            } while (true);
        }
    }
}