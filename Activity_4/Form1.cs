namespace Activity_4
{
    public partial class SecondsConvertor : Form
    {
        public SecondsConvertor()
        {
            InitializeComponent();
        }
        private void SecondsConvertorButton_Click(object sender, EventArgs e)
        {
            //Tryparsing input if code fails to do aht it is supposed to do, tryParse will show an error
            if (int.TryParse(UserInputTextbox.Text, out int seconds))
            {

                //if statement to show an error if second is less than 0 0r negative
                if (seconds > 0)
                {
                    //if value is equalt to or more than 60 convert or display in minutes
                    if (seconds >= 60)
                    {
                        int minutes = seconds / 60;
                        ResultsDisplayTextbox.Text = minutes + " minutes";

                        //if value is equal to or more than 3600 convert and display in hours
                        if (seconds >= 3600)
                        {
                            int hours = seconds / 3600;
                            ResultsDisplayTextbox.Text = hours + " hours";

                            //if value is equal to or more than 86400 convert and display in days
                            if (seconds >= 86400)
                            {
                                int days = seconds / 86400;
                                ResultsDisplayTextbox.Text = days + " days";
                            }

                        }

                    }
                    //if value is less than 60, diplay in seconds
                    else if (seconds < 60)
                    {
                        int second = seconds;
                        ResultsDisplayTextbox.Text = second + " seconds";

                    }

                }
                //if value is negative, then diplay error message to advice user that negative numbers can't be used
                else
                {
                    MessageBox.Show("Negative numbers can't be used");
                }

            }
            //if value is not a number of in valid, diplay error message
            else
            {
                MessageBox.Show("Please enter a valid number");
            }
        }
    }
}
