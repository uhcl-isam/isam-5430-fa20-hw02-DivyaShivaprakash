using System;

namespace FuelEconomy
{
    public partial class Form1 :Form
    {
        //============================================================
        // system generated code creates the GUI
        public Form1()
        {
            InitializeComponent();
        }

        //============================================================        
        // Calculate & Display MPG
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // numeric variables declared here
            int miles, gallons;
            double mpg;

            // Get miles driven, convert and assign to miles
            miles = int.Parse(txtMiles.Text);

            // Get gallons used, convert and assign to gallons
            gallons = int.Parse(txtGallons.Text);

            // Calculate MPG. MUST (cast) variables to force decimal math.
            // integer math discards fractions so 3/2 is simply 1 and not 1.5
            mpg = (double)miles / (double)gallons;

            // Convert number to string and display the MPG with 3 decimal places (rounds)
            lblMPG.Text = mpg.ToString("N3");
        }


        //============================================================        
        // End the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}