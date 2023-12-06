namespace StackCalcForm
{
    class CalcCtrls
    {
        private readonly IStackCalc form;
        public CalcCtrls(IStackCalc form)
        {
            this.form = form;
        }

        public void AddOpenParen()
        {
            if ((form.Result == "0" || form.Result == string.Empty)
                && !form.Input.ToString().EndsWith(')'))
            {
                form.Input += "(";
                Form1.InputAdds.Add("(");
            }
            else if (form.Input.ToString().EndsWith(')'))
            {
                form.Input += "*(";
                Form1.InputAdds.Add("*");
                Form1.InputAdds.Add("(");
            }
            else
            {
                form.Input += form.Result + "*(";
                Form1.InputAdds.Add(form.Result.ToString());
                Form1.InputAdds.Add("*");
                Form1.InputAdds.Add("(");
            }
            form.Result = "0";
        }

        public void AddCloseParen()
        {
            if (form.Input.ToString().EndsWith('('))
            {
                form.Input += form.Result + ")";
                Form1.InputAdds.Add(form.Result.ToString());
                Form1.InputAdds.Add(")");
            }
            else
            {
                string inputStr = form.Input.ToString();
                if (inputStr.Count(c => c == '(') > inputStr.Count(c => c == ')'))
                {
                    form.Input += form.Result + ")";
                    Form1.InputAdds.Add(form.Result.ToString());
                    Form1.InputAdds.Add(")");
                }
            }
            form.Result = "0";
        }

        public void AddOperation(string c)
        {
            string inputStr = form.Input.ToString();
            List<string> oprList = new List<string>() { "+", "-", "*", "/", "^" };
            if (oprList.Any(c => inputStr.EndsWith(c)) && form.Result == "0")
            {
                form.Input = inputStr.Remove(inputStr.Length - 1);
                form.Input += c;
                Form1.InputAdds.RemoveAt(Form1.InputAdds.Count - 1);
                Form1.InputAdds.Add(c);
            }
            else if (inputStr.EndsWith(')'))
            {
                form.Input += c;
                Form1.InputAdds.Add(c);
            }
            else
            {
                form.Input += form.Result + c;
                Form1.InputAdds.Add(form.Result.ToString());
                Form1.InputAdds.Add(c);
            }
            form.Result = "0";
        }

        public void AddDigit(string n)
        {
            if (n == "0" && form.Result != "0")
            {
                form.Result += "0";
            }
            else if (form.Result == "0")
            {
                form.Result = n;
            }
            else
            {
                form.Result += n;
            }
        }

        public void Evaluate()
        {
            string inputStr = form.Input.ToString();
            if (inputStr.Count(c => c == '(') > inputStr.Count(c => c == ')'))
            {
                form.Input += form.Result + ")";
                Form1.InputAdds.Add(form.Result.ToString());
                Form1.InputAdds.Add(")");
            }
            else if (!inputStr.EndsWith(')'))
            {
                form.Input += form.Result;
                Form1.InputAdds.Add(form.Result.ToString());
            }
            string postFix = CalcProcess.ProcessExpression();
            double result = CalcProcess.CalculateFromPostfix(postFix);
            Form1.InputAdds.Clear(); form.Input = string.Empty;
            if (double.IsNegativeInfinity(result))
            {
                form.Result = "Error";
            }
            else
            {
                form.Result = result.ToString();
            }
        }

        public void Backspace()
        {
            if (form.Result.Length == 1)
            {
                form.Result = "0";
            }
            else
            {
                string inputNumStr = form.Result.ToString();
                form.Result = inputNumStr[..^1];
            }
        }
    }
}
