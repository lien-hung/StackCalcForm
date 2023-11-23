namespace StackCalcForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddOpenParen()
        {
            if ((ResultExpr.Text == "0" || ResultExpr.Text == string.Empty) 
                && !InputExpr.Text.ToString().EndsWith(')'))
            {
                InputExpr.AppendText("(");
                inAdds.Add("(");
            }
            else if (InputExpr.Text.ToString().EndsWith(')'))
            {
                InputExpr.AppendText("*(");
                inAdds.Add("*");
                inAdds.Add("(");
            }
            else
            {
                InputExpr.AppendText(ResultExpr.Text + "*(");
                inAdds.Add(ResultExpr.Text.ToString());
                inAdds.Add("*");
                inAdds.Add("(");
            }
            ResultExpr.Text = "0";
            ResultExpr.SelectionStart = ResultExpr.Text.Length;
            ResultExpr.SelectionLength = 0;
        }

        private void AddCloseParen()
        {
            if (InputExpr.Text.ToString().EndsWith('('))
            {
                InputExpr.AppendText(ResultExpr.Text + ")");
                inAdds.Add(ResultExpr.Text.ToString());
                inAdds.Add(")");
            }
            else
            {
                string inputStr = InputExpr.Text.ToString();
                if (inputStr.Count(c => c == '(') > inputStr.Count(c => c == ')'))
                {
                    InputExpr.AppendText(ResultExpr.Text + ")");
                    inAdds.Add(ResultExpr.Text.ToString());
                    inAdds.Add(")");
                }
            }
            ResultExpr.Text = "0";
            ResultExpr.SelectionStart = ResultExpr.Text.Length;
            ResultExpr.SelectionLength = 0;
        }

        private void AddOperation(string c)
        {
            string inputStr = InputExpr.Text.ToString();
            List<string> oprList = new List<string>() { "+", "-", "*", "/", "^" };
            if (oprList.Any(c => inputStr.EndsWith(c)) && ResultExpr.Text == "0")
            {
                InputExpr.Text = inputStr.Remove(inputStr.Length - 1);
                InputExpr.AppendText(c);
                inAdds.RemoveAt(inAdds.Count - 1);
                inAdds.Add(c);
            }
            else if (inputStr.EndsWith(')'))
            {
                InputExpr.AppendText(c);
                inAdds.Add(c);
            }
            else
            {
                InputExpr.AppendText(ResultExpr.Text + c);
                inAdds.Add(ResultExpr.Text.ToString());
                inAdds.Add(c);
            }
            ResultExpr.Text = "0";
            ResultExpr.SelectionStart = ResultExpr.Text.Length;
            ResultExpr.SelectionLength = 0;
        }

        private void AddDigit(string n)
        {
            if (n == "0" && ResultExpr.Text != "0")
            {
                ResultExpr.AppendText("0");
            }
            else if (ResultExpr.Text == "0")
            {
                ResultExpr.Text = n;
            }
            else
            {
                ResultExpr.AppendText(n);
            }
        }

        private void Evaluate()
        {
            string inputStr = InputExpr.Text.ToString();
            if (inputStr.Count(c => c == '(') > inputStr.Count(c => c == ')'))
            {
                InputExpr.AppendText(ResultExpr.Text + ")");
                inAdds.Add(ResultExpr.Text.ToString());
                inAdds.Add(")");
            }
            else if (!inputStr.EndsWith(')'))
            {
                InputExpr.AppendText(ResultExpr.Text.ToString());
                inAdds.Add(ResultExpr.Text.ToString());
            }
            string postFix = ProcessExpression();
            double result = CalculateFromPostfix(postFix);
            inAdds.Clear(); InputExpr.Clear();
            if (double.IsNegativeInfinity(result))
            {
                ResultExpr.Text = "Error";
            }
            else
            {
                ResultExpr.Text = result.ToString();
            }
        }

        private void Backspace()
        {
            if (ResultExpr.Text.Length == 1)
            {
                ResultExpr.Text = "0";
            }
            else
            {
                string inputNumStr = ResultExpr.Text.ToString();
                ResultExpr.Text = inputNumStr[..^1];
            }
            ResultExpr.SelectionStart = ResultExpr.Text.Length;
            ResultExpr.SelectionLength = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResultExpr.Text = "0";
        }

        private void ButtonOpenParen_Click(object sender, EventArgs e)
        {
            AddOpenParen();
        }

        private void ButtonCloseParen_Click(object sender, EventArgs e)
        {
            AddCloseParen();
        }

        private void ButtonPower_Click(object sender, EventArgs e)
        {
            AddOperation("^");
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            AddOperation("+");
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            AddOperation("-");
        }

        private void ButtonMulti_Click(object sender, EventArgs e)
        {
            AddOperation("*");
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            AddOperation("/");
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            AddDigit("0");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddDigit("1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AddDigit("2");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AddDigit("3");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AddDigit("4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            AddDigit("5");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            AddDigit("6");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            AddDigit("7");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            AddDigit("8");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            AddDigit("9");
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            string inputNum = ResultExpr.Text.ToString();
            if (!inputNum.Any(c => c == '.'))
            {
                ResultExpr.AppendText(".");
            }
        }

        private void ButtonPlusMinus_Click(object sender, EventArgs e)
        {
            string inputNumStr = ResultExpr.Text.ToString();
            if (inputNumStr.StartsWith("-"))
            {
                ResultExpr.Text = inputNumStr.TrimStart('-');
            }
            else
            {
                ResultExpr.Text = inputNumStr.Insert(0, "-");
            }
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            InputExpr.Text = string.Empty;
            ResultExpr.Text = "0";
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            Backspace();
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            Evaluate();
        }

        private void ResultExpr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.D9)
            {
                AddOpenParen();
            }
            if (e.Shift && e.KeyCode == Keys.D0)
            {
                AddCloseParen();
            }
            if (e.Shift && e.KeyCode == Keys.D6)
            {
                AddOperation("^");
            }
            if (e.Shift && e.KeyCode == Keys.Oemplus)
            {
                AddOperation("+");
            }
            if (e.KeyCode == Keys.OemMinus)
            {
                AddOperation("-");
            }
            if (e.Shift && e.KeyCode == Keys.D8)
            {
                AddOperation("*");
            }
            if (e.KeyData == Keys.OemQuestion)
            {
                AddOperation("/");
            }
            if (e.KeyCode == Keys.OemPeriod)
            {
                string inputNum = ResultExpr.Text.ToString();
                if (!inputNum.Any(c => c == '.'))
                {
                    ResultExpr.AppendText(".");
                }
            }
            if (e.KeyCode == Keys.C)
            {
                InputExpr.Text = string.Empty;
                ResultExpr.Text = "0";
            }
            if (e.KeyCode == Keys.Back)
            {
                Backspace();
            }
            if (e.KeyCode == Keys.Enter)
            {
                Evaluate();
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