using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MidtermTemperatureConversionApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DoWork()
        {
            //Declare and initialize variables
            Double dStartValue = 0.0;
            Double dNewValue = 0.0;

            //Verify that the input is correct
            try//If the input is correct
            {
                //Convert the input into a number and store it
                dStartValue = Convert.ToDouble(txtInput.Text);

                //Calculate the equivalent in the other unit of measure and store it
                if (rdoF2C.Checked)
                {

                    //Convert the input from fahrenheit to celsius
                    dNewValue = (dStartValue - 32) / 1.8;
                    lblOutput.Text = dStartValue.ToString() + " degrees Fahrenheit equals "
                        + dNewValue.ToString() + " degrees Celsius.";
                }
                else
                {
                    //Convert the input from celsius to fahrenheit
                    dNewValue = (dStartValue * 1.8) + 32;
                    lblOutput.Text = dStartValue.ToString() + " degrees Celsius equals "
                        + dNewValue.ToString() + " degrees Fahrenheit.";
                }
            }//Display it to the user
            catch (Exception ex)//If the input is not correct
            {
                //Alert the user and
                MessageBox.Show("Invalid entry in the input window: " + ex.Message,
                    "Midterm Temperature Converstion Application",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                //Reset the form back to default
                Reset();
            }
        }

        private void Reset()
        {
            txtInput.Text = String.Empty;
            lblOutput.Text = String.Empty;
            rdoF2C.Checked = true;
            txtInput.Focus();
        }

        private void rdoF2C_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoF2C.Checked)
            {
                lblUnitsOfMeasure.Text = "in Fahrenheit.";
                tslStatus.Text = "Converting Fahrenheit to Celsius";
            }
            else
            {
                lblUnitsOfMeasure.Text = "in Celsius.";
                tslStatus.Text = "Converting Celsius to Fahrenheit";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            DoWork();
        }

        
    }
}
