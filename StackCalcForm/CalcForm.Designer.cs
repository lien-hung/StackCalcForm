namespace StackCalcForm
{
    partial class CalcForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcForm));
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
            ButtonLog = new Button();
            ButtonLn = new Button();
            ButtonSin = new Button();
            ButtonCos = new Button();
            ButtonTan = new Button();
            ButtonPi = new Button();
            ButtonE = new Button();
            SuspendLayout();
            // 
            // InputExpr
            // 
            InputExpr.Enabled = false;
            InputExpr.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            InputExpr.Location = new Point(12, 12);
            InputExpr.Name = "InputExpr";
            InputExpr.Size = new Size(389, 23);
            InputExpr.TabIndex = 0;
            // 
            // ResultExpr
            // 
            ResultExpr.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            ResultExpr.Location = new Point(12, 41);
            ResultExpr.Name = "ResultExpr";
            ResultExpr.Size = new Size(389, 38);
            ResultExpr.TabIndex = 2;
            ResultExpr.KeyDown += ResultExpr_KeyDown;
            ResultExpr.KeyPress += ResultExpr_KeyPress;
            // 
            // ButtonC
            // 
            ButtonC.BackColor = Color.Red;
            ButtonC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonC.ForeColor = Color.White;
            ButtonC.Location = new Point(249, 85);
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
            ButtonDel.Location = new Point(328, 85);
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
            ButtonPlus.Location = new Point(328, 136);
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
            ButtonMinus.Location = new Point(328, 187);
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
            ButtonMulti.Location = new Point(328, 238);
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
            ButtonDiv.Location = new Point(328, 289);
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
            ButtonEqual.Location = new Point(328, 340);
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
            Button9.Location = new Point(249, 187);
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
            Button6.Location = new Point(249, 238);
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
            Button3.Location = new Point(249, 289);
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
            ButtonPower.Location = new Point(249, 136);
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
            Button8.Location = new Point(170, 187);
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
            Button5.Location = new Point(170, 238);
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
            Button2.Location = new Point(170, 289);
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
            Button1.Location = new Point(91, 289);
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
            Button4.Location = new Point(91, 238);
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
            Button7.Location = new Point(91, 187);
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
            ButtonOpenParen.Location = new Point(91, 136);
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
            ButtonCloseParen.Location = new Point(170, 136);
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
            Button0.Location = new Point(91, 340);
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
            ButtonPlusMinus.Location = new Point(249, 340);
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
            ButtonDot.Location = new Point(170, 340);
            ButtonDot.Name = "ButtonDot";
            ButtonDot.Size = new Size(73, 45);
            ButtonDot.TabIndex = 24;
            ButtonDot.Text = ".";
            ButtonDot.UseVisualStyleBackColor = true;
            ButtonDot.Click += ButtonDot_Click;
            // 
            // ButtonLog
            // 
            ButtonLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonLog.Location = new Point(12, 136);
            ButtonLog.Name = "ButtonLog";
            ButtonLog.Size = new Size(73, 45);
            ButtonLog.TabIndex = 25;
            ButtonLog.Text = "log";
            ButtonLog.UseVisualStyleBackColor = true;
            ButtonLog.Click += ButtonLog_Click;
            // 
            // ButtonLn
            // 
            ButtonLn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonLn.Location = new Point(12, 187);
            ButtonLn.Name = "ButtonLn";
            ButtonLn.Size = new Size(73, 45);
            ButtonLn.TabIndex = 26;
            ButtonLn.Text = "ln";
            ButtonLn.UseVisualStyleBackColor = true;
            ButtonLn.Click += ButtonLn_Click;
            // 
            // ButtonSin
            // 
            ButtonSin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSin.Location = new Point(12, 238);
            ButtonSin.Name = "ButtonSin";
            ButtonSin.Size = new Size(73, 45);
            ButtonSin.TabIndex = 27;
            ButtonSin.Text = "sin";
            ButtonSin.UseVisualStyleBackColor = true;
            ButtonSin.Click += ButtonSin_Click;
            // 
            // ButtonCos
            // 
            ButtonCos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonCos.Location = new Point(12, 289);
            ButtonCos.Name = "ButtonCos";
            ButtonCos.Size = new Size(73, 45);
            ButtonCos.TabIndex = 28;
            ButtonCos.Text = "cos";
            ButtonCos.UseVisualStyleBackColor = true;
            ButtonCos.Click += ButtonCos_Click;
            // 
            // ButtonTan
            // 
            ButtonTan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonTan.Location = new Point(12, 340);
            ButtonTan.Name = "ButtonTan";
            ButtonTan.Size = new Size(73, 45);
            ButtonTan.TabIndex = 29;
            ButtonTan.Text = "tan";
            ButtonTan.UseVisualStyleBackColor = true;
            ButtonTan.Click += ButtonTan_Click;
            // 
            // ButtonPi
            // 
            ButtonPi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonPi.Location = new Point(12, 85);
            ButtonPi.Name = "ButtonPi";
            ButtonPi.Size = new Size(73, 45);
            ButtonPi.TabIndex = 30;
            ButtonPi.Text = "π";
            ButtonPi.UseVisualStyleBackColor = true;
            ButtonPi.Click += ButtonPi_Click;
            // 
            // ButtonE
            // 
            ButtonE.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonE.Location = new Point(91, 85);
            ButtonE.Name = "ButtonE";
            ButtonE.Size = new Size(73, 45);
            ButtonE.TabIndex = 31;
            ButtonE.Text = "e";
            ButtonE.UseVisualStyleBackColor = true;
            ButtonE.Click += ButtonE_Click;
            // 
            // CalcForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 396);
            Controls.Add(ButtonE);
            Controls.Add(ButtonPi);
            Controls.Add(ButtonTan);
            Controls.Add(ButtonCos);
            Controls.Add(ButtonSin);
            Controls.Add(ButtonLn);
            Controls.Add(ButtonLog);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "CalcForm";
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
        private Button ButtonLog;
        private Button ButtonLn;
        private Button ButtonSin;
        private Button ButtonCos;
        private Button ButtonTan;
        private Button ButtonPi;
        private Button ButtonE;
        private Button ButtonDot;
        private Button ButtonEqual;
    }
}