namespace HowManyClicks
{
    public partial class Form1 : Form
    {
        //1) maak hier een variable (int met als naam clicks)
        private int clicks=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {

            //2) tel hier 1 op bij clicks (zie boven in de klas)
            clicks += 1;
            clicksAmountText.Text = clicks.ToString();
        }
    }
}
