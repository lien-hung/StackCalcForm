namespace StackCalcForm
{
    class CalcCtrls
    {
        private readonly IStackCalc _form;
        public CalcCtrls(IStackCalc form)
        {
            _form = form;
        }

        public void AddOpenParen()
        {
            if ((_form.Result == "0" || _form.Result == string.Empty)
                && !_form.Input.ToString().EndsWith(')'))
            {
                _form.Input += "(";
                Form1.InputAdds.Add("(");
            }
            else if (_form.Input.ToString().EndsWith(')'))
            {
                _form.Input += "*(";
                Form1.InputAdds.Add("*");
                Form1.InputAdds.Add("(");
            }
            else
            {
                _form.Input += _form.Result + "*(";
                Form1.InputAdds.Add(_form.Result.ToString());
                Form1.InputAdds.Add("*");
                Form1.InputAdds.Add("(");
            }
            _form.Result = "0";
        }

        public void AddCloseParen()
        {
            if (_form.Input.ToString().EndsWith('('))
            {
                _form.Input += _form.Result + ")";
                Form1.InputAdds.Add(_form.Result.ToString());
                Form1.InputAdds.Add(")");
            }
            else
            {
                string inputStr = _form.Input.ToString();
                if (inputStr.Count(c => c == '(') > inputStr.Count(c => c == ')'))
                {
                    _form.Input += _form.Result + ")";
                    Form1.InputAdds.Add(_form.Result.ToString());
                    Form1.InputAdds.Add(")");
                }
            }
            _form.Result = "0";
        }

        public void AddOperation(string c)
        {
            string inputStr = _form.Input.ToString();
            List<string> oprList = new List<string>() { "+", "-", "*", "/", "^" };
            if (oprList.Any(c => inputStr.EndsWith(c)) && _form.Result == "0")
            {
                _form.Input = inputStr.Remove(inputStr.Length - 1);
                _form.Input += c;
                Form1.InputAdds.RemoveAt(Form1.InputAdds.Count - 1);
                Form1.InputAdds.Add(c);
            }
            else if (inputStr.EndsWith(')'))
            {
                _form.Input += c;
                Form1.InputAdds.Add(c);
            }
            else
            {
                _form.Input += _form.Result + c;
                Form1.InputAdds.Add(_form.Result.ToString());
                Form1.InputAdds.Add(c);
            }
            _form.Result = "0";
        }

        public void AddDigit(string n)
        {
            if (n == "0" && _form.Result != "0")
            {
                _form.Result += "0";
            }
            else if (_form.Result == "0")
            {
                _form.Result = n;
            }
            else
            {
                _form.Result += n;
            }
        }

        public void Evaluate()
        {
            string inputStr = _form.Input.ToString();
            if (inputStr.Count(c => c == '(') > inputStr.Count(c => c == ')'))
            {
                _form.Input += _form.Result + ")";
                Form1.InputAdds.Add(_form.Result.ToString());
                Form1.InputAdds.Add(")");
            }
            else if (!inputStr.EndsWith(')'))
            {
                _form.Input += _form.Result;
                Form1.InputAdds.Add(_form.Result.ToString());
            }
            string postFix = CalcProcess.ProcessExpression();
            double result = CalcProcess.CalculateFromPostfix(postFix);
            Form1.InputAdds.Clear(); _form.Input = string.Empty;
            if (double.IsNegativeInfinity(result))
            {
                _form.Result = "Error";
            }
            else
            {
                _form.Result = result.ToString();
            }
        }

        public void Backspace()
        {
            if (_form.Result.Length == 1)
            {
                _form.Result = "0";
            }
            else
            {
                string inputNumStr = _form.Result.ToString();
                _form.Result = inputNumStr[..^1];
            }
        }
    }
}
