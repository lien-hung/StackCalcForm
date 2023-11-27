using System.Collections;

namespace StackCalcForm
{
    class CalcProcess
    {
        private static int Precedence(string? x)
        {
            if (x == "+" || x == "-") return 1;
            else if (x == "*" || x == "/") return 2;
            else if (x == "^") return 3;
            else return -1;
        }

        public static string ProcessExpression()
        {
            Stack addStack = new Stack();
            string postFix = string.Empty;
            string[] arrInAdds = Form1.InputAdds.ToArray();
            for (int i = 0; i < arrInAdds.Length; ++i)
            {
                string opr = arrInAdds[i];
                if (double.TryParse(opr, out double num))
                {
                    postFix += num + " ";
                }
                else if (opr == "(")
                {
                    addStack.Push(opr);
                }
                else if (opr == ")")
                {
                    while (addStack.Count > 0 && addStack.Peek()?.ToString() != "(")
                    {
                        postFix += addStack.Pop()?.ToString() + " ";
                    }
                    if (addStack.Count > 0 && addStack.Peek()?.ToString() != "(")
                    {
                        return "Error";
                    }
                    else if (addStack.Count > 0)
                    {
                        addStack.Pop();
                    }
                }
                else
                {
                    while (addStack.Count > 0
                        && Precedence(opr) <= Precedence(addStack.Peek()?.ToString()))
                    {
                        postFix += addStack.Pop()?.ToString() + " ";
                    }
                    addStack.Push(opr);
                }
            }
            while (addStack.Count > 0)
            {
                postFix += addStack.Pop()?.ToString() + " ";
            }
            return postFix;
        }

        public static double CalculateFromPostfix(string postFix)
        {
            Stack addStack = new Stack();
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
                    else if (addStack.Count == 1)
                    {
                        if (opr == "-")
                        {
                            double x = Convert.ToDouble(addStack.Pop());
                            addStack.Push(-x);
                        }
                    }
                    else
                    {
                        isValid = false;
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
