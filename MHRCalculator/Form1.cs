namespace MHRCalculator
{
    public partial class Form1 : Form
    {
        PersonF23 person;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            person = new PersonF23();
            person.IsFemale = femaleRB.Checked;
            person.Age = (int)ageNUD.Value;
            person.ActivityLevel = (ACTIVITY_LEVEL)activityCBB.SelectedIndex;
            MHR_FORMULA formula = (MHR_FORMULA)formulaCBB.SelectedIndex;

            // calculate Heart Rates
            person.CalculateMaxHeartRateF23(formula);
            person.CalculateTargetHeartRatesF23();

            // display heart rates
            mhrTB.Text = person.MaxHeartRate.ToString();
            lowHRTB.Text = person.TargetMinHR.ToString();
            highHRTB.Text = person.TargetMaxHR.ToString();
        }
    }
}