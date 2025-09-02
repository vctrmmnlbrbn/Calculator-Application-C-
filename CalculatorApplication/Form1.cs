namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        CalculatorClass cal;

        double num1, num2, result;
        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);
            string op = cbOperator.Text;

            if (op == "+")
            {
               cal.CalculateEvent += cal.GetSum;
            }
            else if (op == "-")
            {
               cal.CalculateEvent += cal.GetSubtraction;
            }
            else if (op == "*")
            {
                cal.CalculateEvent += cal.GetProduct;
            }
            else if (op == "/")
                cal.CalculateEvent += cal.GetQuotient;
            else
            {
                MessageBox.Show("Invalid operator. Use +, -, *, or /.");
                return;
            }

            result=cal.calculate_Event?.Invoke(num1, num2) ?? 0.0;
            lblDisplayTotal.Text = result.ToString();

        }
    }
}
