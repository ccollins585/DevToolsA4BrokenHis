using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChaseLab4
{
    /* Brayden Chase
     * November 17th 2022
     * Programming Lab 4 - this program lets you book trips */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Reset All Function
        * Sent: no data sent
        * Returned: no data returned
        * This function resets the form and selects default options */
        private void ResetTrip()
        {
            //this clears the textboxes and labels and selects the default options
            grpTripInfo.Visible = false;
            radCuba.Checked = true;
            txtPeople.Text = "";
            lblPrice.Text = "";
            radCredit.Checked = true;

            //this puts the cursor back on the textbox
            txtPeople.Focus();
        }//end ResetTrip function

        /*Set Flight Function
        * Sent: no data sent
        * Returned: no data returned
        * This function unchecks flight when florida is selected */
        private void SetFlight()
        {
            //this unchecks flight when florida is selected
            if (radFlorida.Checked)
                chkFlight.Checked = false;
            //this checks flight when anything else is selected
            else
                chkFlight.Checked = true;
        }//end SetFlight function

        /*Display Message Function
        * Sent: 2 strings sent
        * Returned: no data returned
        * This function displays a messagebox */
        private void DisplayMsg(string dspMessage, string dspTitle)
        {
            MessageBox.Show(dspMessage, dspTitle, MessageBoxButtons.OK);
        }
        //this resets the textbox and selects the deafults
        private void btnReset_Click(object sender, EventArgs e)
        {
            //this calls the ResetTrip function
            ResetTrip();
        }//end reset button event
        
        //this resets the textbox and selects the defaults
        private void Form1_Load(object sender, EventArgs e)
        {
            //this calls the ResetTrip function
            ResetTrip();
        }//end form load event
        
        //this calls the SetFlight function when cuba is checked
        private void radCuba_CheckedChanged(object sender, EventArgs e)
        {
            SetFlight();
        }//end cuba button event
       
        //this calls the SetFlight function when mexico is checked
        private void radMexico_CheckedChanged(object sender, EventArgs e)
        {
            SetFlight();
        }//end mexico button event
       
        //this is the Book button event
        private void btnBook_Click(object sender, EventArgs e)
        {
           //these are variables being declared
            const double MEXICO = 2300.79;
            const double OTHER = 2150.50;
            const double DISCOUNT = 0.1;
            int people;
            double price;
            string location;
            string flight = "Flight Included";
            string discount = "Cash Discount Applied";
           //this tests to see if the input is an integer
            bool goodData = int.TryParse(txtPeople.Text, out people);

           //this displays an error message if the input is not an integer
            if (goodData == false)
            {
                string dspMessage = "People must be a whole number";
                string dspTitle = "Input Error";
                DisplayMsg(dspMessage, dspTitle);
                //this puts the cursor on the textbox
                txtPeople.Focus();
                //this selects what was entered
                txtPeople.SelectAll();
            }//end if

            //this shows an error message if people isn't 1-10
            else if (people > 10 || people <= 0)
            {
                string dspMessage = "People must be between 1-10";
                string dspTitle = "Input Error";
                DisplayMsg(dspMessage, dspTitle);
                //this puts the cursor on the textbox
                txtPeople.Focus();
                //this selects what was entered
                txtPeople.SelectAll();
            }//end if

            else
            {
               //this calculates if mexico was chosen
                if (radMexico.Checked == true)
                {
                    price = people * MEXICO;
                }
               //this calculates if cuba or florida was chosen
                else 
                {
                    price= people * OTHER;
                }
                //this displays the price if cash was chosen
                if (radCash.Checked == true)
                {
                    price = price - (price * DISCOUNT);

                    lblPrice.Text = price.ToString("c2");
                }
               //this displays the price if credit was chosen
                else
                { 
                    lblPrice.Text = price.ToString("c2");
                }//end else

                
                //this changes the variable location depending on what is checked
                if (radCuba.Checked == true)

                    location = "cuba";

                else if (radFlorida.Checked == true)

                    location = "florida";

                else

                    location = "mexico";



                
                //this clears the label
                lblDisplay.Text = "";

                //these are variables to display the info for the trip
                string book = "Booked by Brayden Chase" + "\n\n" +
                    "People: " + people.ToString("d2") + "\n" +
                    "Location: " + location.ToUpper() + "\n";
                string dspPrice = "Price: " + lblPrice.Text;


                //this is the message if cash and flight are chosen
                if (radCash.Checked == true && chkFlight.Checked == true)
                    lblDisplay.Text = book +
                    flight + "\n" +
                    discount + "\n" +
                    dspPrice;

                //this is the message if credit and flight are chosen
                else if (radCredit.Checked == true && chkFlight.Checked == true)

                    lblDisplay.Text = book +
                        flight + "\n" +
                        dspPrice;
               
                //this is the message if cash and no flight is chosen
                else if (radCash.Checked == true && chkFlight.Checked == false)

                    lblDisplay.Text = book +
                        discount + "\n" +
                        dspPrice;

                //this is the message if neither cash or flight are chosen
                else
                lblDisplay.Text = book +
                    dspPrice;

                //this makes the groupbox visible
                grpTripInfo.Visible = true;


                //this disables the left groupbox
                grpBook.Enabled = false;

                //this shows the BOGO message if 1 or 3 are chosen
                switch (txtPeople.Text)
                {
                    case "1":
                    case "3":
                       string dspMessage = "Special when booking single or triple." + "\n" +
                            "BOGO Special - Call 555-1212 to receive another person free!";
                        string dspTitle = "Limited Time Offer";
                       DisplayMsg(dspMessage, dspTitle);
                        break;
                }//end switch



            }//end else

        }//end Book button event

        //this is the confirm event
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //this displays a message when confirm is clicked
            string dspMessage = "Trip booked and paid" + "\n" +
                "Price: " + lblPrice.Text;
            string dspTitle = "Confirmtion Email Sent";

            DisplayMsg(dspMessage, dspTitle);

            //this calls the ResetTrip function
            ResetTrip();
           
            //this enables the groupbox for booking
            grpBook.Enabled = true;

        }//end confirm event
    }
}


