﻿namespace StackCalcForm
{
    class CalcProcess
    {
        static readonly string[] funcList = { "log", "ln", "sin", "cos", "tan" };
        /// <summary>
        /// Xác định độ ưu tiên của toán tử hoặc hàm
        /// </summary>
        /// <param name="x">Dấu toán tử hoặc hàm</param>
        /// <returns>Số nguyên chỉ độ ưu tiên của toán tử hoặc hàm</returns>
        private static int Precedence(string? x)
        {
            if (x == "+" || x == "-") return 1;
            else if (x == "*" || x == "/") return 2;
            else if (x == "^") return 3;
            else if (funcList.Contains(x)) return 4;
            else return -1;
        }
        /// <summary>
        /// Chuyển biểu thức mà người dùng nhập từ dạng trung tố sang hậu tố,
        /// dựa trên danh sách hàm, toán tử và toán hạng mà chương trình đang lưu
        /// </summary>
        /// <returns>Biểu thức dạng hậu tố</returns>
        public static string ProcessExpression()
        {
            CalcStack<object> addStack = new CalcStack<object>(CalcForm.InputAdds.Count);
            string postFix = string.Empty;
            string[] arrInAdds = CalcForm.InputAdds.ToArray();
            for (int i = 0; i < arrInAdds.Length; ++i)
            {
                string opr = arrInAdds[i];
                if (double.TryParse(opr, out double num))
                {
                    postFix += num + " ";
                }
                else if (funcList.Contains(opr))
                {
                    addStack.Push(opr);
                }
                else if (opr == "(")
                {
                    addStack.Push(opr);
                }
                else if (opr == ")")
                {
                    while (!addStack.IsEmpty() && addStack.Peek()?.ToString() != "(")
                    {
                        postFix += addStack.Pop()?.ToString() + " ";
                    }
                    if (!addStack.IsEmpty() && addStack.Peek()?.ToString() != "(")
                    {
                        return "Error";
                    }
                    else if (!addStack.IsEmpty())
                    {
                        addStack.Pop();
                    }
                }
                else
                {
                    while (!addStack.IsEmpty()
                        && Precedence(opr) <= Precedence(addStack.Peek()?.ToString()))
                    {
                        postFix += addStack.Pop()?.ToString() + " ";
                    }
                    addStack.Push(opr);
                }
            }
            while (!addStack.IsEmpty())
            {
                postFix += addStack.Pop()?.ToString() + " ";
            }
            return postFix.Trim();
        }
        /// <summary>
        /// Tính giá trị biểu thức mà người dùng nhập dựa trên dạng hậu tố của nó
        /// </summary>
        /// <param name="postFix">Biểu thức, dạng hậu tố</param>
        /// <returns>Số chỉ kết quả tính toán của biểu thức</returns>
        public static double CalculateFromPostfix(string postFix)
        {
            CalcStack<object> addStack = new CalcStack<object>(CalcForm.InputAdds.Count);
            string[] adds = postFix.Split(' ');
            bool isValid = true;
            for (int i = 0; i < adds.Length; i++)
            {
                if (double.TryParse(adds[i], out double num))
                {
                    addStack.Push(num);
                }
                else
                {
                    string opr = adds[i];
                    if (funcList.Contains(opr))
                    {
                        double x = Convert.ToDouble(addStack.Pop());
                        switch (opr)
                        {
                            case "log": addStack.Push(Math.Log10(x)); break;
                            case "ln": addStack.Push(Math.Log(x)); break;
                            case "sin": addStack.Push(Math.Sin(x)); break;
                            case "cos": addStack.Push(Math.Cos(x)); break;
                            case "tan": addStack.Push(Math.Tan(x)); break;
                            default: isValid = false; break;
                        }
                    }
                    else
                    {
                        if (addStack.Count > 1)
                        {
                            double a = Convert.ToDouble(addStack.Pop());
                            double b = Convert.ToDouble(addStack.Pop());
                            switch (opr)
                            {
                                case "+": addStack.Push(b + a); break;
                                case "-": addStack.Push(b - a); break;
                                case "*": addStack.Push(b * a); break;
                                case "/": addStack.Push(b / a); break;
                                case "^": addStack.Push(Math.Pow(b, a)); break;
                                default: isValid = false; break;
                            }
                        }
                        else
                        {
                            isValid = false;
                        }
                    }
                }
            }
            if (!isValid)
            {
                return double.NegativeInfinity;
            }
            double result = Convert.ToDouble(addStack.Pop());
            return result;
        }
    }
}