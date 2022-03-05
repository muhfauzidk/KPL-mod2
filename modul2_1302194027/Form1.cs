namespace modul2_1302194027
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        public Form1()
        {
            InitializeComponent();
        }
        float num1, ans;
        int count;

        private void buttonResult_Click(object sender, EventArgs e)
        {
            compute(count);
        }
        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 + float.Parse(txtResult.Text);
                    txtResult.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

        private void NumEvent(object sender, EventArgs e)
        {
            if (txtResult.Text == "Label Output")
                txtResult.Clear();

            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtResult.Text);
            txtResult.Clear();
            txtResult.Focus();
            count = 1;
        }
    }
}