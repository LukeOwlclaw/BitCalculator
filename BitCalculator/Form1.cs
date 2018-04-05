using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExpressionEvaluation;

namespace BitCalculator
{
    public partial class Form1 : Form
    {
        List<CheckBox> SrcBits = new List<CheckBox>();
        List<CheckBox> DestBits = new List<CheckBox>();
        List<CheckBox> Bits = new List<CheckBox>();
        ExpressionEval eval = new ExpressionEval();
        List<string> EvalArray = new List<string>();
        /*indicates the current position in EvalArray. 0 is the last entry. 1 the second to last...*/
        int EvalArrayPosition = 0;
        string EvalHelp = "Set variable: a=1\r\nAccess variable: a\r\nList all variables: listvar\r\nShow some supported functions: longhelp\r\nClear this text box: clear\r\nNote: Binary operator ^ is XOR. The power operator is ^^.";
        string EvalLongHelp = "Some supported functions:\r\n$sin(), $cos(), $tan(), $sec(), $csc(), $cot(), $asin(), $acos(), $atan(), $sinh(), $cosh(), $tanh(), $abs(), $sqrt(), $ciel(), $floor(), $exp(), $log10(), $log(), $max(), $min(), $pow(), $round(), $trun(), $e(), $pi(), $time(), $now(), $today()";
        public Form1()
        {
            InitializeComponent();
            SrcBits.Add(SrcBit0);
            SrcBits.Add(SrcBit1);
            SrcBits.Add(SrcBit2);
            SrcBits.Add(SrcBit3);
            SrcBits.Add(SrcBit4);
            SrcBits.Add(SrcBit5);
            SrcBits.Add(SrcBit6);
            SrcBits.Add(SrcBit7);

            DestBits.Add(DestBit0);
            DestBits.Add(DestBit1);
            DestBits.Add(DestBit2);
            DestBits.Add(DestBit3);
            DestBits.Add(DestBit4);
            DestBits.Add(DestBit5);
            DestBits.Add(DestBit6);
            DestBits.Add(DestBit7);

            Bits.Add(Bit0);
            Bits.Add(Bit1);
            Bits.Add(Bit2);
            Bits.Add(Bit3);
            Bits.Add(Bit4);
            Bits.Add(Bit5);
            Bits.Add(Bit6);
            Bits.Add(Bit7);

            CalcResult.Text = EvalHelp;
        }
        private int BitsToByte(List<CheckBox> Bits)
        {
            int Byte = 0;
            for (int i = Bits.Count - 1; i >= 0; i--)
            {
                Byte = Byte * 2 + (Bits[i].Checked ? 1 : 0);
            }
            return Byte;
        }
        private void SrcBit_CheckedChanged(object sender, EventArgs e)
        {
            SrcByte.Text = BitsToByte(SrcBits).ToString();
            SrcToDest();
        }
        private void DestBit_CheckedChanged(object sender, EventArgs e)
        {
            DestByte.Text = BitsToByte(DestBits).ToString();
        }
        private void SrcToDest()
        {
            for (int i = 0; i < 8; i++)
            {
                if (Bits[i].CheckState == CheckState.Indeterminate)
                    DestBits[i].CheckState = SrcBits[i].CheckState;
                else
                    DestBits[i].CheckState = Bits[i].CheckState;
            }
        }

        private void Bit_CheckedChanged(object sender, EventArgs e)
        {
            SrcToDest();
            string ret = "";
            string or = "";
            string and = "";
            int test = 7;
            test = (test & ~(1 << 2) & ~(1 << 0)) | (1 << 3) | (1 << 4);
            for (int i = 0; i < 8; i++) 
            {
                if (Bits[i].CheckState == CheckState.Checked)
                {                    
                    or += " | 1 << " + i;
                }
                else if (Bits[i].CheckState == CheckState.Unchecked)
                {                   
                    and += " & ~(1 << " + i + ")";
                }
            }
            ret = "( var " + and + ")" + or;

            Calc.Text = ret;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
//http://stackoverflow.com/questions/47981/how-do-you-set-clear-and-toggle-a-single-bit-in-c
//http://stackoverflow.com/questions/1192487/swap-bits-in-a-number-in-c
            //toggle bit (not quite yet...)
            int c = 7;
            int firstbit = 1; //2
            int secondbit = 3; //8
            c = ((c & (1 << firstbit)) >> (secondbit - firstbit)) | ((c & (1 << secondbit)) << (secondbit - firstbit));

            int var = 45;
            var = (var & ~(1 << 5) & ~(1 << 1)) | ((1 << 5) & var) >> (5 - 1) | ((1 << 1) & var) << (5 - 1);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            string var = "var";
            //position of first bit:
            int l = Convert.ToInt32(numericUpDown1.Value);
            //position of second bit:
            int r = Convert.ToInt32(numericUpDown2.Value);
            //test number
            int test = 254;
            //left first bit
            int a = (1 << l) & test;
            //right (second) bit
            int b = (1 << r) & test;
            //move left to right:
            a = a >> (l-r);
            //move right to left:
            b = b << (l-r);
            //erase both positions in test:
            test = (test & ~(1 << l) & ~(1 << r));
            //combine (OR) a,b,test
            test = test | a | b;

            if (!(l > r)) WarningLabel.Visible = true;
            else WarningLabel.Visible = false;


            BitSwitch.Text = "//position of first bit:\r\n" +
            "int l = " + Convert.ToInt32(numericUpDown1.Value).ToString() + ";\r\n" +
            "//position of second bit:\r\n" +
            "int r = "+Convert.ToInt32(numericUpDown2.Value)+";\r\n" +
            "//test number\r\n" +
            "int test = 254;\r\n" +
            "//left first bit\r\n" +
            "int a = (1 << l) & test;\r\n" +
            "//right (second) bit\r\n" +
            "int b = (1 << r) & test;\r\n" +
            "//move left to right:\r\n" +
            "a = a >> (l-r);\r\n" +
            "//move right to left:\r\n" +
            "b = b << (l-r);\r\n" +
            "//erase both positions in test:\r\n" +
            "test = (test & ~(1 << l) & ~(1 << r));\r\n" +
            "//combine (OR) a,b,test\r\n" +
            "test = test | a | b;";

            BitSwitchShort.Text = "(" + var + " & ~(1 << " + l + ") & ~(1 << " + r + ")) | ((1 << " + l + ") & " + var + ") >> (" + l + "-" + r + ") | ((1 << " + r + ") & " + var + ") << (" + l + "-" + r + ")";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Shift1_Left_TextChanged(object sender, EventArgs e)
        {
            Shift1.Text = (Convert.ToInt32(Shift1_Left.Text) << Convert.ToInt32(Shift1_Right.Text)).ToString();
        }

        private void Shift2_Left_TextChanged(object sender, EventArgs e)
        {
            Shift2.Text = (Convert.ToInt32(Shift2_Left.Text) >> Convert.ToInt32(Shift2_Right.Text)).ToString();
        }

        private void CalcExpression_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                EvalArrayPosition = 0;
                eval.Expression = CalcExpression.Text;
                CalcResult.Text += "\r\n>> "+CalcExpression.Text;
                EvalArray.Add(CalcExpression.Text);
                CalcExpression.Text = "";
                string ResponsePrefix = "\r\n                ";
                switch (eval.Expression.ToLower())
                {
                    case "clear":
                        //EvalArrayPosition = 0b1100;

                        CalcResult.Clear();
                        break;

                    case "listvar":
                        foreach (System.Collections.DictionaryEntry a in eval.variables)
                            CalcResult.Text += (ResponsePrefix+ a.Key + "=" + a.Value);
                        CalcResult.Text += (ResponsePrefix+eval.variables.Count + " variable(s)");
                        break;

                    case "help":
                        CalcResult.Text += ResponsePrefix+EvalHelp;
                        break;

                    case "longhelp":
                        CalcResult.Text += ResponsePrefix+EvalLongHelp;
                        break;

                    case "exit":
                        Application.Exit();
                        break;

                    default:
                        try 
                        {
                            object result = eval.Evaluate();
                            CalcResult.Text += (ResponsePrefix + result);
                            try
                            {
                                double ans = Convert.ToDouble(result);
                                eval.variables.Remove("ans");
                                eval.variables.Add("ans", ans);
                            }
                            catch (Exception) {};
                        }
                        catch (Exception ex) { CalcResult.Text += (ResponsePrefix+ex.Message); }
                        break;
                }
                e.Handled = true;
            }
            return;
        }

        private void CalcExpression_Enter(object sender, EventArgs e)
        {
            CalcExpression.SelectAll();
        }

        private void CalcExpression_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
                if ((EvalArray.Count - 1 - EvalArrayPosition) < 0)
                    return;
                CalcExpression.Text = EvalArray[EvalArray.Count - 1 - EvalArrayPosition++];
                CalcExpression.SelectionStart = CalcExpression.Text.Length;
            }
            else if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                if ((EvalArray.Count + 1 - EvalArrayPosition) >= EvalArray.Count)
                    return;
                CalcExpression.Text = EvalArray[EvalArray.Count + 1 - EvalArrayPosition--];
                CalcExpression.SelectionStart = CalcExpression.Text.Length;
            }
            else if (CalcExpression.Text == "")
            {
                if (e.KeyCode == Keys.Add)
                {
                    CalcExpression.Text = "ans";
                    e.Handled = true;
                    CalcExpression.SelectionStart = CalcExpression.Text.Length;
                }
                else if (e.KeyCode == Keys.Subtract)
                {
                    CalcExpression.Text = "ans";
                    e.Handled = true;
                    CalcExpression.SelectionStart = CalcExpression.Text.Length;
                }
                else if (e.KeyCode == Keys.Divide)
                {
                    CalcExpression.Text = "ans";
                    e.Handled = true;
                    CalcExpression.SelectionStart = CalcExpression.Text.Length;
                }
                else if (e.KeyCode == Keys.Multiply)
                {
                    CalcExpression.Text = "ans";
                    e.Handled = true;
                    CalcExpression.SelectionStart = CalcExpression.Text.Length;
                }
            }


            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                
            }
        }

        private void CalcResult_TextChanged(object sender, EventArgs e)
        {
            ScrollToCalResult();
        }

        private void ScrollToCalResult()
        {
            CalcResult.SelectionStart = CalcResult.Text.Length;
            CalcResult.ScrollToCaret();
        }

        
    }
}
