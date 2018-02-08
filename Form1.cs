using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnWeightCost_Click(object sender, EventArgs e)
        {

            try
            {
                //Local variables
                double weight, costUSWeight, costCanadaWeight;

                try
                {
                    weight = double.Parse(weightInput.Text);
                    
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + " " + err.ToString());
                    return;
                }

                //Get input from user
                weight = double.Parse(weightInput.Text);
                
                

                //Compute cost in USD for Weight
                costUSWeight = 1000 + (weight * 0.5);

                //compute cost in Canada Dollars for Weight
                //is this how to do formula???? costCanadaWeight = 1000 + (weight * 0.75);
                costCanadaWeight = ((1000 + (weight * 0.5)) * 1.25);



                //Display USD cost for Weight
                USDollarsWeightOutput.Text = costUSWeight.ToString("C");

                //Display Canada cost for weight
                CanadaDollarsWeightOutput.Text = costCanadaWeight.ToString("C");

               

            }//end try 

            catch (Exception error)
            {
                MessageBox.Show(error.Message + " : " + error.ToString());

                return;

            }

        }

        private void btnMilesCost_Click(Object sender, EventArgs e)
        {
                try
                {
                    //Local variables
                    double miles, costUSMiles, costCanadaMiles;

                    
                    //Get input from user

                    miles = double.Parse(milesInput.Text);

                    

                  
                    //compute cost in USD for Miles
                    costUSMiles = 500 + (miles * 1);

                    //compute cost in Canada Dollars for Miles
                    costCanadaMiles = ((500 + (miles * 1)) *  1.25);

                   
                    //Display USD cost for Miles
                    USDollarsMilesOutput.Text = costUSMiles.ToString("C");

                    //Display Canada cost for Miles
                    CanadaDollarsMilesOutput.Text = costCanadaMiles.ToString("C");


                }//end try 

                catch (Exception error)
                {
                    MessageBox.Show(error.Message + " : " + error.ToString());
                    return;

                }
        }

        private void btnClearWeight_Click(object sender, EventArgs e)
        {
            try
            {
                weightInput.Clear();

                USDollarsWeightOutput.Clear();

                CanadaDollarsWeightOutput.Clear();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message + " : " + error.ToString());
            }
        }

        private void btnClearMiles_Click(object sender, EventArgs e)
        {
            try
            {
                milesInput.Clear();

                USDollarsMilesOutput.Clear();

                CanadaDollarsMilesOutput.Clear();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + " : " + error.ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

