namespace StackCalcForm
{
    interface IStackCalc
    {
        string Input { get; set; }
        string Result { get; set; }
    }
    public partial class CalcForm : Form, IStackCalc
    {
        public string Input
        {
            get { return InputExpr.Text; }
            set { InputExpr.Text = value; }
        }
        public string Result
        {
            get { return ResultExpr.Text; }
            set { ResultExpr.Text = value; }
        }
        public static List<string> InputAdds = new List<string>();
        private readonly CalcCtrls ctrls;

        public CalcForm()
        {
            InitializeComponent();
            ctrls = new CalcCtrls(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResultExpr.Text = "0";
        }

        private void ButtonOpenParen_Click(object sender, EventArgs e)
        {
            ctrls.AddOpenParen();
        }

        private void ButtonCloseParen_Click(object sender, EventArgs e)
        {
            ctrls.AddCloseParen();
        }

        private void ButtonPower_Click(object sender, EventArgs e)
        {
            ctrls.AddOperation("^");
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            ctrls.AddOperation("+");
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            ctrls.AddOperation("-");
        }

        private void ButtonMulti_Click(object sender, EventArgs e)
        {
            ctrls.AddOperation("*");
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            ctrls.AddOperation("/");
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            ctrls.AddDigit("0");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ctrls.AddDigit("1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ctrls.AddDigit("2");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ctrls.AddDigit("3");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ctrls.AddDigit("4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ctrls.AddDigit("5");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ctrls.AddDigit("6");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ctrls.AddDigit("7");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ctrls.AddDigit("8");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            ctrls.AddDigit("9");
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            ctrls.AddDot();
        }

        private void ButtonPlusMinus_Click(object sender, EventArgs e)
        {
            ctrls.Negate();
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            InputExpr.Text = string.Empty;
            ResultExpr.Text = "0";
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            ctrls.Backspace();
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            ctrls.Evaluate();
        }

        private void ResultExpr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.D9)
            {
                ctrls.AddOpenParen();
            }
            if (e.Shift && e.KeyCode == Keys.D0)
            {
                ctrls.AddCloseParen();
            }
            if (e.Shift && e.KeyCode == Keys.D6)
            {
                ctrls.AddOperation("^");
            }
            if (e.Shift && e.KeyCode == Keys.Oemplus)
            {
                ctrls.AddOperation("+");
            }
            if (e.KeyCode == Keys.OemMinus)
            {
                ctrls.AddOperation("-");
            }
            if (e.Shift && e.KeyCode == Keys.D8)
            {
                ctrls.AddOperation("*");
            }
            if (e.KeyCode == Keys.OemQuestion)
            {
                ctrls.AddOperation("/");
            }
            if (e.KeyCode == Keys.OemPeriod)
            {
                ctrls.AddDot();
            }
            if (e.Shift && e.KeyCode == Keys.N)
            {
                ctrls.Negate();
            }
            if (e.KeyCode == Keys.C)
            {
                InputExpr.Text = string.Empty;
                ResultExpr.Text = "0";
            }
            if (e.KeyCode == Keys.Back)
            {
                ctrls.Backspace();
            }
            if (e.KeyCode == Keys.Enter)
            {
                ctrls.Evaluate();
            }
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && ResultExpr.Text == "0")
            {
                ResultExpr.Text = string.Empty;
            }
        }

        private void ResultExpr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
        }
    }
}