﻿using System.Collections;

namespace StackCalcForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private List<string> inAdds = new List<string>();
        private Stack addStack = new Stack();

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private static int Precedence(string x)
        {
            if (x == "+" || x == "-") return 1;
            else if (x == "*" || x == "/") return 2;
            else if (x == "^") return 3;
            else return -1;
        }

        private string ProcessExpression()
        {
            string postFix = string.Empty;
            string[] arrInAdds = inAdds.ToArray();
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
                    while (addStack.Count > 0 && addStack.Peek().ToString() != "(")
                    {
                        postFix += addStack.Pop().ToString() + " ";
                    }
                    if (addStack.Count > 0 && addStack.Peek().ToString() != "(")
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
                        && Precedence(opr) <= Precedence(addStack.Peek().ToString()))
                    {
                        postFix += addStack.Pop().ToString() + " ";
                    }
                    addStack.Push(opr);
                }
            }
            while (addStack.Count > 0)
            {
                postFix += addStack.Pop().ToString() + " ";
            }
            return postFix;
        }

        private double CalculateFromPostfix(string postFix)
        {
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InputExpr = new TextBox();
            ResultExpr = new TextBox();
            ButtonC = new Button();
            ButtonDel = new Button();
            ButtonPlus = new Button();
            ButtonMinus = new Button();
            ButtonMulti = new Button();
            ButtonDiv = new Button();
            ButtonEqual = new Button();
            Button9 = new Button();
            Button6 = new Button();
            Button3 = new Button();
            ButtonPower = new Button();
            Button8 = new Button();
            Button5 = new Button();
            Button2 = new Button();
            Button1 = new Button();
            Button4 = new Button();
            Button7 = new Button();
            ButtonOpenParen = new Button();
            ButtonCloseParen = new Button();
            Button0 = new Button();
            ButtonPlusMinus = new Button();
            ButtonDot = new Button();
            SuspendLayout();
            // 
            // InputExpr
            // 
            InputExpr.Enabled = false;
            InputExpr.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            InputExpr.Location = new Point(12, 12);
            InputExpr.Name = "InputExpr";
            InputExpr.Size = new Size(310, 23);
            InputExpr.TabIndex = 0;
            // 
            // ResultExpr
            // 
            ResultExpr.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            ResultExpr.Location = new Point(12, 41);
            ResultExpr.Name = "ResultExpr";
            ResultExpr.Size = new Size(310, 38);
            ResultExpr.TabIndex = 2;
            ResultExpr.KeyDown += ResultExpr_KeyDown;
            ResultExpr.KeyPress += ResultExpr_KeyPress;
            // 
            // ButtonC
            // 
            ButtonC.BackColor = Color.Red;
            ButtonC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonC.ForeColor = Color.White;
            ButtonC.Location = new Point(170, 86);
            ButtonC.Name = "ButtonC";
            ButtonC.Size = new Size(73, 45);
            ButtonC.TabIndex = 3;
            ButtonC.Text = "C";
            ButtonC.UseVisualStyleBackColor = false;
            ButtonC.Click += ButtonC_Click;
            // 
            // ButtonDel
            // 
            ButtonDel.BackColor = Color.Red;
            ButtonDel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonDel.ForeColor = Color.White;
            ButtonDel.Location = new Point(249, 86);
            ButtonDel.Name = "ButtonDel";
            ButtonDel.Size = new Size(73, 45);
            ButtonDel.TabIndex = 4;
            ButtonDel.Text = "⌫";
            ButtonDel.UseVisualStyleBackColor = false;
            ButtonDel.Click += ButtonDel_Click;
            // 
            // ButtonPlus
            // 
            ButtonPlus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonPlus.Location = new Point(249, 137);
            ButtonPlus.Name = "ButtonPlus";
            ButtonPlus.Size = new Size(73, 45);
            ButtonPlus.TabIndex = 5;
            ButtonPlus.Text = "+";
            ButtonPlus.UseVisualStyleBackColor = true;
            ButtonPlus.Click += ButtonPlus_Click;
            // 
            // ButtonMinus
            // 
            ButtonMinus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonMinus.Location = new Point(249, 188);
            ButtonMinus.Name = "ButtonMinus";
            ButtonMinus.Size = new Size(73, 45);
            ButtonMinus.TabIndex = 6;
            ButtonMinus.Text = "−";
            ButtonMinus.UseVisualStyleBackColor = true;
            ButtonMinus.Click += ButtonMinus_Click;
            // 
            // ButtonMulti
            // 
            ButtonMulti.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonMulti.Location = new Point(249, 239);
            ButtonMulti.Name = "ButtonMulti";
            ButtonMulti.Size = new Size(73, 45);
            ButtonMulti.TabIndex = 7;
            ButtonMulti.Text = "×";
            ButtonMulti.UseVisualStyleBackColor = true;
            ButtonMulti.Click += ButtonMulti_Click;
            // 
            // ButtonDiv
            // 
            ButtonDiv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonDiv.Location = new Point(249, 290);
            ButtonDiv.Name = "ButtonDiv";
            ButtonDiv.Size = new Size(73, 45);
            ButtonDiv.TabIndex = 8;
            ButtonDiv.Text = "÷";
            ButtonDiv.UseVisualStyleBackColor = true;
            ButtonDiv.Click += ButtonDiv_Click;
            // 
            // ButtonEqual
            // 
            ButtonEqual.BackColor = Color.Blue;
            ButtonEqual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonEqual.ForeColor = Color.White;
            ButtonEqual.Location = new Point(249, 341);
            ButtonEqual.Name = "ButtonEqual";
            ButtonEqual.Size = new Size(73, 45);
            ButtonEqual.TabIndex = 9;
            ButtonEqual.Text = "=";
            ButtonEqual.UseVisualStyleBackColor = false;
            ButtonEqual.Click += ButtonEqual_Click;
            // 
            // Button9
            // 
            Button9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Button9.Location = new Point(170, 188);
            Button9.Name = "Button9";
            Button9.Size = new Size(73, 45);
            Button9.TabIndex = 10;
            Button9.Text = "9";
            Button9.UseVisualStyleBackColor = true;
            Button9.Click += Button9_Click;
            // 
            // Button6
            // 
            Button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Button6.Location = new Point(170, 239);
            Button6.Name = "Button6";
            Button6.Size = new Size(73, 45);
            Button6.TabIndex = 11;
            Button6.Text = "6";
            Button6.UseVisualStyleBackColor = true;
            Button6.Click += Button6_Click;
            // 
            // Button3
            // 
            Button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Button3.Location = new Point(170, 290);
            Button3.Name = "Button3";
            Button3.Size = new Size(73, 45);
            Button3.TabIndex = 12;
            Button3.Text = "3";
            Button3.UseVisualStyleBackColor = true;
            Button3.Click += Button3_Click;
            // 
            // ButtonPower
            // 
            ButtonPower.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonPower.Location = new Point(170, 137);
            ButtonPower.Name = "ButtonPower";
            ButtonPower.Size = new Size(73, 45);
            ButtonPower.TabIndex = 13;
            ButtonPower.Text = "x^y";
            ButtonPower.UseVisualStyleBackColor = true;
            ButtonPower.Click += ButtonPower_Click;
            // 
            // Button8
            // 
            Button8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Button8.Location = new Point(91, 188);
            Button8.Name = "Button8";
            Button8.Size = new Size(73, 45);
            Button8.TabIndex = 14;
            Button8.Text = "8";
            Button8.UseVisualStyleBackColor = true;
            Button8.Click += Button8_Click;
            // 
            // Button5
            // 
            Button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Button5.Location = new Point(91, 239);
            Button5.Name = "Button5";
            Button5.Size = new Size(73, 45);
            Button5.TabIndex = 15;
            Button5.Text = "5";
            Button5.UseVisualStyleBackColor = true;
            Button5.Click += Button5_Click;
            // 
            // Button2
            // 
            Button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Button2.Location = new Point(91, 290);
            Button2.Name = "Button2";
            Button2.Size = new Size(73, 45);
            Button2.TabIndex = 16;
            Button2.Text = "2";
            Button2.UseVisualStyleBackColor = true;
            Button2.Click += Button2_Click;
            // 
            // Button1
            // 
            Button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Button1.Location = new Point(12, 290);
            Button1.Name = "Button1";
            Button1.Size = new Size(73, 45);
            Button1.TabIndex = 17;
            Button1.Text = "1";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // Button4
            // 
            Button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Button4.Location = new Point(12, 239);
            Button4.Name = "Button4";
            Button4.Size = new Size(73, 45);
            Button4.TabIndex = 18;
            Button4.Text = "4";
            Button4.UseVisualStyleBackColor = true;
            Button4.Click += Button4_Click;
            // 
            // Button7
            // 
            Button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Button7.Location = new Point(12, 188);
            Button7.Name = "Button7";
            Button7.Size = new Size(73, 45);
            Button7.TabIndex = 19;
            Button7.Text = "7";
            Button7.UseVisualStyleBackColor = true;
            Button7.Click += Button7_Click;
            // 
            // ButtonOpenParen
            // 
            ButtonOpenParen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonOpenParen.Location = new Point(12, 137);
            ButtonOpenParen.Name = "ButtonOpenParen";
            ButtonOpenParen.Size = new Size(73, 45);
            ButtonOpenParen.TabIndex = 20;
            ButtonOpenParen.Text = "(";
            ButtonOpenParen.UseVisualStyleBackColor = true;
            ButtonOpenParen.Click += ButtonOpenParen_Click;
            // 
            // ButtonCloseParen
            // 
            ButtonCloseParen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonCloseParen.Location = new Point(91, 137);
            ButtonCloseParen.Name = "ButtonCloseParen";
            ButtonCloseParen.Size = new Size(73, 45);
            ButtonCloseParen.TabIndex = 21;
            ButtonCloseParen.Text = ")";
            ButtonCloseParen.UseVisualStyleBackColor = true;
            ButtonCloseParen.Click += ButtonCloseParen_Click;
            // 
            // Button0
            // 
            Button0.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Button0.Location = new Point(12, 341);
            Button0.Name = "Button0";
            Button0.Size = new Size(73, 45);
            Button0.TabIndex = 22;
            Button0.Text = "0";
            Button0.UseVisualStyleBackColor = true;
            Button0.Click += Button0_Click;
            // 
            // ButtonPlusMinus
            // 
            ButtonPlusMinus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonPlusMinus.Location = new Point(170, 341);
            ButtonPlusMinus.Name = "ButtonPlusMinus";
            ButtonPlusMinus.Size = new Size(73, 45);
            ButtonPlusMinus.TabIndex = 23;
            ButtonPlusMinus.Text = "+/-";
            ButtonPlusMinus.UseVisualStyleBackColor = true;
            ButtonPlusMinus.Click += ButtonPlusMinus_Click;
            // 
            // ButtonDot
            // 
            ButtonDot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonDot.Location = new Point(91, 341);
            ButtonDot.Name = "ButtonDot";
            ButtonDot.Size = new Size(73, 45);
            ButtonDot.TabIndex = 24;
            ButtonDot.Text = ".";
            ButtonDot.UseVisualStyleBackColor = true;
            ButtonDot.Click += ButtonDot_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 398);
            Controls.Add(ButtonDot);
            Controls.Add(ButtonPlusMinus);
            Controls.Add(Button0);
            Controls.Add(ButtonCloseParen);
            Controls.Add(ButtonOpenParen);
            Controls.Add(Button7);
            Controls.Add(Button4);
            Controls.Add(Button1);
            Controls.Add(Button2);
            Controls.Add(Button5);
            Controls.Add(Button8);
            Controls.Add(ButtonPower);
            Controls.Add(Button3);
            Controls.Add(Button6);
            Controls.Add(Button9);
            Controls.Add(ButtonEqual);
            Controls.Add(ButtonDiv);
            Controls.Add(ButtonMulti);
            Controls.Add(ButtonMinus);
            Controls.Add(ButtonPlus);
            Controls.Add(ButtonDel);
            Controls.Add(ButtonC);
            Controls.Add(ResultExpr);
            Controls.Add(InputExpr);
            KeyPreview = true;
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputExpr;
        private TextBox ResultExpr;
        private Button ButtonC;
        private Button ButtonDel;
        private Button ButtonPlus;
        private Button ButtonMinus;
        private Button ButtonMulti;
        private Button ButtonDiv;
        private Button ButtonPower;
        private Button Button0;
        private Button Button1;
        private Button Button2;
        private Button Button3;
        private Button Button4;
        private Button Button5;
        private Button Button6;
        private Button Button7;
        private Button Button8;
        private Button Button9;
        private Button ButtonOpenParen;
        private Button ButtonCloseParen;
        private Button ButtonPlusMinus;
        private Button ButtonDot;
        private Button ButtonEqual;
    }
}