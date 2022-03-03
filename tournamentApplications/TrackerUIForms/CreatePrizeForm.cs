﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAcces;
using TrackerLibrary.Models;

namespace TrackerUIForms
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingForm;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();
            
            callingForm = caller;
        }

        private void BtnCreatePrize_Click(object sender, EventArgs e)
        {
            if (Validateform())
            {
                PrizeModel model = new PrizeModel(
                    PlaceNameValue.Text, 
                    PlaceNumberValue.Text, 
                    PrizeAmountValue.Text, 
                    PrizePercentageValue.Text);

                GlobalConfig.Connection.CreatePrize(model);

                callingForm.PrizeComplete(model);

                this.Close();

                //PlaceNameValue.Text = "";
                //PlaceNumberValue.Text = "";
                //PrizeAmountValue.Text = "0";
                //PrizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("this form has invalid information. Please check it and try again.");
                PlaceNumberValue.Focus();
            }
        }

        private bool Validateform()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(PlaceNumberValue.Text, out placeNumber);

            if (!placeNumberValidNumber)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (PlaceNameValue.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(PrizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(PrizePercentageValue.Text, out prizePercentage);

            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
