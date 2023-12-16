namespace StackCalcForm
{
    class CalcCtrls
    {
        private readonly IStackCalc form;
        public CalcCtrls(IStackCalc form)
        {
            this.form = form;
        }
        /// <summary>
        /// Thêm dấu mở ngoặc đơn (kèm theo số, nếu có) vào ô Input
        /// </summary>
        public void AddOpenParen()
        {
            if ((form.Result == "0" || form.Result == string.Empty)
                && !form.Input.EndsWith(')'))
            {
                form.Input += "(";
                CalcForm.InputAdds.Add("("); 
            }
            else if (form.Input.EndsWith(')'))
            {
                form.Input += "*(";
                CalcForm.InputAdds.AddRange(new string[] { "*", "(" });
            }
            else
            {
                if (form.Result.StartsWith("-")) 
                    form.Input += $"({form.Result})" + "*(";
                else 
                    form.Input += form.Result + "*(";
                CalcForm.InputAdds.AddRange(new string[] { form.Result, "*", "(" });
            }
            form.Result = "0";
        }
        /// <summary>
        /// Thêm dấu đóng ngoặc đơn (kèm theo số, nếu có) vào ô Input,
        /// nếu các dấu ngoặc không đi đầy đủ theo cặp
        /// </summary>
        public void AddCloseParen()
        {
            if (form.Input.EndsWith('('))
            {
                if (form.Result.StartsWith("-")) 
                    form.Input += $"({form.Result})" + ")";
                else 
                    form.Input += form.Result + ")";
                CalcForm.InputAdds.AddRange(new string[] { form.Result, ")" });
            }
            else
            {
                string inputStr = form.Input;
                if (inputStr.Count(c => c == '(') > inputStr.Count(c => c == ')'))
                {
                    if (form.Result.StartsWith("-"))
                        form.Input += $"({form.Result})" + ")";
                    else
                        form.Input += form.Result + ")";
                    CalcForm.InputAdds.AddRange(new string[] { form.Result, ")" });
                }
            }
            form.Result = "0";
        }
        /// <summary>
        /// Thêm một trong các dấu phép toán cộng, trừ, nhân, chia hoặc lũy thừa
        /// vào cuối biểu thức trong ô Input, hoặc thay dấu phép toán ở cuối biểu
        /// thức thành dấu mới do người dùng nhập vào
        /// </summary>
        /// <param name="c">Dấu phép toán cần thêm</param>
        public void AddOperation(string c)
        {
            string inputStr = form.Input;
            List<string> oprList = new List<string>() { "+", "-", "*", "/", "^" };
            if (oprList.Any(c => inputStr.EndsWith(c))
                && (form.Result == "0" || form.Result == string.Empty))
            {
                form.Input = inputStr.Remove(inputStr.Length - 1);
                form.Input += c;
                CalcForm.InputAdds.RemoveAt(CalcForm.InputAdds.Count - 1);
                CalcForm.InputAdds.Add(c);
            }
            else if (inputStr.EndsWith(')'))
            {
                form.Input += c;
                CalcForm.InputAdds.Add(c);
            }
            else
            {
                if (form.Result.StartsWith("-"))
                    form.Input += $"({form.Result})" + c;
                else
                    form.Input += form.Result + c;
                CalcForm.InputAdds.AddRange(new string[] { form.Result, c });
            }
            form.Result = "0";
        }
        /// <summary>
        /// Thêm một trong các hàm logarit hoặc lượng giác mà ứng dụng hỗ trợ
        /// vào biểu thức trong ô Input
        /// </summary>
        /// <param name="func">Hàm cần thêm vào</param>
        public void AddFunction(string func)
        {
            List<string> inputs = CalcForm.InputAdds.ToList();
            string[] funcList = { "log", "ln", "sin", "cos", "tan" };
            if (form.Input.EndsWith(")") && funcList.Contains(func))
            {
                int counter = 0; string after = string.Empty;
                for (int i = inputs.Count - 1; i >= 0; i--)
                {
                    if (inputs[i] == ")")
                    {
                        counter++;
                    }
                    else if (inputs[i] == "(")
                    {
                        counter--;
                    }
                    if (counter == 0)
                    {
                        if (funcList.Contains(inputs[i - 1]))
                        {
                            inputs.InsertRange(i - 1, new string[] { func, "(" });
                            inputs.Add(")");
                        }
                        else
                        {
                            inputs.Insert(i, func);
                        }
                        break;
                    }
                }
                foreach (string input in inputs)
                {
                    after += input;
                }
                CalcForm.InputAdds = inputs.ToList();
                form.Input = after;
            }
            else
            {
                form.Input += func + $"({form.Result})";
                CalcForm.InputAdds.AddRange(new string[] { func, "(", form.Result, ")" });
            }
            form.Result = "0";
        }
        /// <summary>
        /// Thêm một chữ số vào số đang hiển thị trong ô Result
        /// (chỉ có tác dụng khi người dùng nhấn vào nút bấm)
        /// </summary>
        /// <param name="n"></param>
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
        /// <summary>
        /// Thêm hằng số vào biểu thức trong ô Input
        /// </summary>
        /// <param name="c">Hằng số cần thêm</param>
        public void AddConst(string c)
        {
            if (c == "pi")
            {
                form.Result = Math.PI.ToString();
            }
            else if (c == "e")
            {
                form.Result = Math.E.ToString();
            }
        }
        /// <summary>
        /// Thêm tối đa một dấu thập phân vào số trong ô Result
        /// </summary>
        public void AddDot()
        {
            string inputNum = form.Result;
            if (!inputNum.Any(c => c == '.'))
            {
                form.Result += ".";
            }
        }
        /// <summary>
        /// Chuyển một số dương trong ô Result thành số âm (hoặc ngược lại)
        /// </summary>
        public void Negate()
        {
            string inputNumStr = form.Result;
            if (inputNumStr.StartsWith("-"))
            {
                form.Result = inputNumStr.TrimStart('-');
            }
            else
            {
                form.Result = inputNumStr.Insert(0, "-");
            }
        }
        /// <summary>
        /// Tính giá trị biểu thức mà người dùng nhập và thông báo kết quả
        /// </summary>
        public void Evaluate()
        {
            string inputStr = form.Input;
            if (inputStr.Count(c => c == '(') > inputStr.Count(c => c == ')'))
            {
                if (form.Result.StartsWith("-"))
                    form.Input += $"({form.Result})" + ")";
                else
                    form.Input += form.Result + ")";
                CalcForm.InputAdds.AddRange(new string[] { form.Result, ")" });
            }
            else if (!inputStr.EndsWith(')'))
            {
                if (form.Result.StartsWith("-"))
                    form.Input += $"({form.Result})";
                else
                    form.Input += form.Result;
                CalcForm.InputAdds.Add(form.Result);
            }
            string postFix = CalcProcess.ProcessExpression();
            double result = CalcProcess.CalculateFromPostfix(postFix);
            CalcForm.InputAdds.Clear(); form.Input = string.Empty;
            if (double.IsNegativeInfinity(result))
            {
                form.Result = "Error";
            }
            else
            {
                form.Result = result.ToString();
            }
        }
        /// <summary>
        /// Loại bỏ chữ số tận cùng của số trong ô Result
        /// </summary>
        public void Backspace()
        {
            if (form.Result.Length == 1)
            {
                form.Result = "0";
            }
            else
            {
                string inputNumStr = form.Result;
                form.Result = inputNumStr[..^1];
            }
        }
    }
}