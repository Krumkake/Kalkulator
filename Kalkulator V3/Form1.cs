using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Keyboard kontroller: ElikKnapp = O på tastaturet. Resten er bundet til numPaden
namespace Kalkulator_V3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region variabler
        double tall1 = 0;
        double tall2 = 0;
        double y;
        string regneOp = "";
        #endregion
        #region tall- og skriveknapper
        private void BtnC_Click(object sender, EventArgs e) //reset knapp
        {
            display.Text = "0";
            tall1 = 0;
            inputHistory.Text = "0";
        }
        private void BtnSlettTilbake_Click(object sender, EventArgs e) //slettetilbake knapp
        {
            if (display.Text.Length == 1)
            {
                display.Text = "0";
            }
            else
            {
                display.Text = display.Text.Remove(display.Text.Length - 1, 1);
            }
            if (inputHistory.Text.Length == 1)
            {
                inputHistory.Text = "0";
            }
            else if ("+-*/²^".IndexOf(inputHistory.Text[inputHistory.Text.Length - 1]) == -1) //gjør at man ikke kan slette den siste operatoren fra inputHistory labelen
            {
                inputHistory.Text = inputHistory.Text.Remove(inputHistory.Text.Length - 1, 1);
            }
            if (display.Text == "-")
            {
                display.Text = "0";
                inputHistory.Text = display.Text;
            }
        }
        private void BtnComma_Click(object sender, EventArgs e)
        {
            if (!display.Text.Contains(","))
            {
                display.Text += btnComma.Text;
                inputHistory.Text += btnComma.Text;
            }
        }
        private void btnTall_click(object sender, EventArgs e) //gruppe med alle tallknapper
        {
            Button b = sender as Button;
            if (display.Text == "0")
            {
                display.Text = "";
            }
            display.Text += b.Text;
            if (inputHistory.Text == "0")
            {
                inputHistory.Text = "";
            }
            inputHistory.Text += b.Text;
        }
        #endregion
        #region regneknapper
        private void AddSubDivMulOperasjoner(object sender, EventArgs e) //gruppe med plus, minus, gange og dele
        {
            Button b = sender as Button;
            tall1 = Double.Parse(display.Text);
            inputHistory.Text = display.Text + b.Text;
            display.Text = "0";
            regneOp = b.Text;
        }
        private void BtnEndreFortegn_Click(object sender, EventArgs e)
        {
            double x = -1 * Convert.ToDouble(display.Text);
            display.Text = Convert.ToString(x);
            inputHistory.Text = display.Text;
        }
        private void BtnErLik_Click(object sender, EventArgs e)
        {
            tall2 = Double.Parse(display.Text);
            if (regneOp == "+")
            {
                double sum = tall1 + tall2;
                display.Text = sum.ToString();
            }
            if (regneOp == "-")
            {
                double sum = tall1 - tall2;
                display.Text = sum.ToString();
            }
            if (regneOp == "*")
            {
                double sum = tall1 * tall2;
                display.Text = sum.ToString();
            }
            if (regneOp == "/")
            {
                double sum = tall1 / tall2;
                display.Text = sum.ToString();
            }
            if (regneOp == "x^y")
            {
                tall2 = Convert.ToDouble(display.Text);
                tall2 = Math.Pow(tall1, tall2);
                display.Text = tall2.ToString();
            }
            tall1 = tall2;
            inputHistory.Text = display.Text;
        }
        private void BntSqr_Click(object sender, EventArgs e)
        {
            double tall2 = Convert.ToDouble(display.Text);
            tall2 = Math.Pow(tall2, 2);
            display.Text = tall2.ToString();
            inputHistory.Text = display.Text;
        }
        private void BtnSquareRoot_Click(object sender, EventArgs e)
        {
            double tall2 = Convert.ToDouble(display.Text);
            tall2 = Math.Sqrt(tall2);
            display.Text = tall2.ToString();
            inputHistory.Text = display.Text;
        }
        private void BtnSquareXY_Click(object sender, EventArgs e)
        {
            tall1 = Convert.ToDouble(display.Text);
            inputHistory.Text = display.Text + "^";
            display.Text = "0";
            regneOp = "x^y";
        }
        #endregion
        #region keyboard
        private void Form1_KeyDown(object sender, KeyEventArgs e) //keyboard konfigurasjon
        {
            switch (e.KeyCode)
            {
                case Keys.Back:
                    btnSlettTilbake.PerformClick();
                    break;
                case Keys.NumPad0:
                    btn0.PerformClick();
                    break;
                case Keys.NumPad1:
                    btn1.PerformClick();
                    break;
                case Keys.NumPad2:
                    btn2.PerformClick();
                    break;
                case Keys.NumPad3:
                    btn3.PerformClick();
                    break;
                case Keys.NumPad4:
                    btn4.PerformClick();
                    break;
                case Keys.NumPad5:
                    btn5.PerformClick();
                    break;
                case Keys.NumPad6:
                    btn6.PerformClick();
                    break;
                case Keys.NumPad7:
                    btn7.PerformClick();
                    break;
                case Keys.NumPad8:
                    btn8.PerformClick();
                    break;
                case Keys.NumPad9:
                    btn9.PerformClick();
                    break;
                case Keys.Decimal:
                    btnComma.PerformClick();
                    break;
                case Keys.Add:
                    btnPluss.PerformClick();
                    break;
                case Keys.Subtract:
                    btnMinus.PerformClick();
                    break;
                case Keys.Multiply:
                    btnMulti.PerformClick();
                    break;
                case Keys.Divide:
                    btnDivi.PerformClick();
                    break;
                case Keys.X:
                    bntSqr.PerformClick();
                    break;
                case Keys.O:
                    btnErLik.PerformClick();
                    break;
                case Keys.Escape:
                    btnC.PerformClick();
                    break;
            }
        }
        #endregion
    }
}