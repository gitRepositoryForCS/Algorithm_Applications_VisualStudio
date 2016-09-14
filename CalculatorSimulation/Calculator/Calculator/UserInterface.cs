/* UserInterface.cs
 * Author: Ying Chen
 */
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.Calculator
{
    /// <summary>
    /// A GUI for a 4-function calculator.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }


        /// <summary>
        /// this field indicates whether it is display mode or input mode.
        /// </summary>
        private bool modelIndex = true;

        // this stack store the pending operators and operands.
        Stack s = new Stack();  

        /// <summary>
        /// This method, taking two operand and a operation as parameters, will give corespondding result of the operator (+,-,X and /).  
        /// </summary>
        /// <param name="oper"></param>
        /// <param name="firstOperand"></param>
        /// <param name="secondOperand"></param>
        /// <returns></returns>
        private double Result(string oper, double firstOperand, double secondOperand)
        {
            switch (oper)
            {
                case "+":
                    return firstOperand + secondOperand;
                case "-":
                    return firstOperand - secondOperand;
                case "X":
                    return firstOperand * secondOperand;
                case "/":
                    return firstOperand / secondOperand;
                default:
                    return 0;
            }
        }
        
        /// <summary>
        /// This method is meant to find the priority of a operator.
        /// </summary>
        /// <param name="oper"></param>
        /// <returns></returns>
        private int FindPriority(string oper)
        {
            switch (oper)
            {
                case "=":
                    return 0;
                case "(":
                    return 0;
                case ")":
                    return 1;
                case "+":
                    return 2;
                case "-":
                    return 2;
                case "X":
                    return 3;
                case "/":
                    return 3;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// This method is to compute all pending operations having a minimum priority. 
        /// </summary>
        /// <param name="minimumPriority"></param>
        /// <param name="lastOperand"></param>
        /// <returns></returns>
        private double ComputePendingOperations(int minimumPriority, double lastOperand)
        {
            double result = lastOperand;
            if (s.Count == 0)
            {
                return result;
            }
            if (FindPriority(s.Peek().ToString()) < minimumPriority)
            {
                return result;
            }
            else
            {
                while (s.Count > 0 && FindPriority(s.Peek().ToString()) >= minimumPriority)
                { 
                    if (s.Peek().ToString() == "(")
                    {       
                        s.Pop();
                    }
                    else
                    {
                        result = Result(s.Pop().ToString(), Convert.ToDouble(s.Pop()), result);
                    }
                }
                return result;
            }
        }

        /// <summary>
        /// This even handler handles the event when the one of the number buttons is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSeven_Click(object sender, EventArgs e)
        {
            Button seven = (Button)sender;
            string a = "0";
            if (uxDisplay.Text == a || modelIndex)
            {
                uxDisplay.Text = seven.Text;
                modelIndex = false;
            }
            else
            {
                uxDisplay.Text = uxDisplay.Text + seven.Text;
            }
        }

        /// <summary>
        /// This event handler handls the event when decimal point button is clicked and the dot is added to the text in the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void uxDecimalPoint_Click(object sender, EventArgs e)
        {
            string zero_dot = ".";
            if(modelIndex)
            {
                uxDisplay.Text = "0.";
                modelIndex = false;
            }
            else if(!uxDisplay.Text.Contains(zero_dot))
            {
                uxDisplay.Text = uxDisplay.Text + ".";
            }
        }

        /// <summary>
        /// This event handler handles the event when the "+/-" button is clicked. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxChangeSigns_Click(object sender, EventArgs e)
        {
            double double_text = -Convert.ToDouble(uxDisplay.Text);
            string result = double_text.ToString(); 
            uxDisplay.Text = result;
           // modelIndex = true;
        }

        /// <summary>
        /// This event handler handles the event when "C/CE" is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxClear_Click(object sender, EventArgs e)
        {
            if(!modelIndex)
            {
                uxDisplay.Text = "0";
                modelIndex = true;
            }
            else
            {
                uxDisplay.Text = "0";
                s.Clear();
            }
        }

        /// <summary>
        /// This event handler handles the event when "(" button is clicked. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpeningParenthesis_Click(object sender, EventArgs e)
        {
            s.Push("(");
        }

        /// <summary>
        /// This event handler handles the event when one of ")", "+", "-", "X", and "/" buttons is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxClosingParenthesis_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = button.Text;
            uxDisplay.Text = ComputePendingOperations(FindPriority(text), Convert.ToDouble(uxDisplay.Text)).ToString();
            modelIndex = true;
            if (text == ")" && s.Count > 0)
            {
                s.Pop();
            }
            if (text == "+" || text == "-" || text == "X" || text == "/")
            {
                s.Push(Convert.ToDouble(uxDisplay.Text));
                s.Push(text);

            }
        }

    }
}
