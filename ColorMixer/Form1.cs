namespace ColorMixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rdoRed1.Checked = true;
            rdoRed2.Checked = true;
        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            // the logic for when both boxes are red
            if (rdoRed1.Checked && rdoRed2.Checked)
            {
                // colroing the background to red
                this.BackColor = Color.Red;
            }
            // the logic for when red and blue are checked on either side
            if (rdoRed1.Checked && rdoBlue2.Checked || rdoRed2.Checked && rdoBlue1.Checked)
            {
                // coloring the background to purple
                this.BackColor = Color.Purple;
            }
            // the logic for when red and yellow are checked
            if (rdoRed1.Checked && rdoYellow2.Checked || rdoRed2.Checked && rdoYellow1.Checked)
            {
                // coloring the background to orange
                this.BackColor = Color.Orange;
            }
            // the logic for when blue and blue bottons are checked
            if (rdoBlue1.Checked && rdoBlue2.Checked)
            {
                // colroing the background to blue
                this.BackColor = Color.Blue;
            }
            // the logic for when blue and yellow are checked
            if (rdoBlue1.Checked && rdoYellow2.Checked || rdoBlue2.Checked && rdoYellow1.Checked)
            {
                // colroing the background to green
                this.BackColor = Color.Green;
            }
            // the logic for when yellow and yellow are checked
            if (rdoYellow1.Checked && rdoYellow2.Checked)
            {
                // colroing the background to yellow
                this.BackColor = Color.Yellow;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Ending the program and closes it.
            this.Close();
        }
    }
}