using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingGame
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetKeysColor();
        }
        void ResetKeysColor()
        {
            //Numbers Line In Your Keyboard
            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            btn5.BackColor = Color.White;
            btn6.BackColor = Color.White;
            btn7.BackColor = Color.White;
            btn8.BackColor = Color.White;
            btn9.BackColor = Color.White;
            btn0.BackColor = Color.White;
            btnDash.BackColor = Color.White;
            btnEqual.BackColor = Color.White;
            btnBackspace.BackColor = Color.White;
            //First Line In Your KeyBoard
            btnQ.BackColor = Color.White;
            btnW.BackColor = Color.White;
            btnE.BackColor = Color.White;
            btnR.BackColor = Color.White;
            btnT.BackColor = Color.White;
            btnY.BackColor = Color.White;
            btnU.BackColor = Color.White;
            btnI.BackColor = Color.White;
            btnO.BackColor = Color.White;
            btnP.BackColor = Color.White;
            btnBrac.BackColor = Color.White;
            btnBracClose.BackColor = Color.White;
            btnSlash.BackColor = Color.White;
            //Middel Line In Your Keyboard
            btnA.BackColor = Color.White;
            btnS.BackColor = Color.White;
            btnD.BackColor = Color.White;
            btnF.BackColor = Color.White;
            btnG.BackColor = Color.White;
            btnH.BackColor = Color.White;
            btnJ.BackColor = Color.White;
            btnK.BackColor = Color.White;
            btnL.BackColor = Color.White;
            btnCol.BackColor = Color.White;
            btnQuet.BackColor = Color.White;
            btnEnter.BackColor = Color.White;
            //Last Line In your Keyboard
            btnZ.BackColor = Color.White;
            btnX.BackColor = Color.White;
            btnC.BackColor = Color.White;
            btnV.BackColor = Color.White;
            btnB.BackColor = Color.White;
            btnN.BackColor = Color.White;
            btnM.BackColor = Color.White;
            btnGreater.BackColor = Color.White;
            btnSmaller.BackColor = Color.White;
            btnBackSlash.BackColor = Color.White;
        }
        void PerformKeyPressed(KeyPressEventArgs e)
        {
            string Key = e.KeyChar.ToString().ToUpper();



            //Numbers Line In Your Keyboard
            if (Convert.ToInt16(e.KeyChar) == 8)
            {
                btnBackspace.BackColor = Color.DimGray;
                return;
            }
            if (Key == "1" || Key == "!")
            {
                btn1.BackColor = Color.DimGray;
                return;
            }
            if (Key == "2" || Key == "@")
            {
                btn2.BackColor = Color.DimGray;
                return;
            }
            if (Key == "3" || Key == "#")
            {
                btn3.BackColor = Color.DimGray;
                return;
            }
            if (Key == "4" || Key == "$")
            {
                btn4.BackColor = Color.DimGray;
                return;
            }
            if (Key == "5" || Key == "%")
            {
                btn5.BackColor = Color.DimGray;
                return;
            }
            if (Key == "6" || Key == "^")
            {
                btn6.BackColor = Color.DimGray;
                return;
            }
            if (Key == "7" || Key == "&")
            {
                btn7.BackColor = Color.DimGray;
                return;
            }
            if (Key == "8" || Key == "*")
            {
                btn8.BackColor = Color.DimGray;
                return;
            }
            if (Key== "9" || Key == "(")
            {
                btn9.BackColor = Color.DimGray;
                return;
            }
            if (Key == "0" || Key == ")")
            {
                btn0.BackColor = Color.DimGray;
                return;
            }
            if (Key == "_" || Key == "-")
            {
                btnDash.BackColor = Color.DimGray;
                return;
            }
            if (Key == "=" || Key == "+")
            {
                btnEqual.BackColor = Color.DimGray;
                return;
            }



            //First Line In Your KeyBoard
            
            if (Key == "Q")
            {
                btnQ.BackColor = Color.DimGray;
                return;
            }
            if (Key == "W")
            {
                btnW.BackColor = Color.DimGray;
                return;
            }
            if (Key == "E")
            {
                btnE.BackColor = Color.DimGray;
                return;
            }
            if (Key == "R")
            {
                btnR.BackColor = Color.DimGray;
                return;
            }
            if (Key == "T")
            {
                btnT.BackColor = Color.DimGray;
                return;
            }
            if (Key == "Y")
            {
                btnY.BackColor = Color.DimGray;
                return;
            }
            if (Key == "U")
            {
                btnU.BackColor = Color.DimGray;
                return;
            }
            if (Key == "I")
            {
                btnI.BackColor = Color.DimGray;
                return;
            }
            if (Key == "O")
            {
                btnO.BackColor = Color.DimGray;
                return;
            }
            if (Key == "P")
            {
                btnP.BackColor = Color.DimGray;
                return;
            }
            if (Key == "[" || Key == "{")
            {
                btnBrac.BackColor = Color.DimGray;
                return;
            }
            if (Key == "]" || Key == "}")
            {
                btnBracClose.BackColor = Color.DimGray;
                return;
            }
            if (Key == "\\" || Key == "|" )
            {
                btnSlash.BackColor = Color.DimGray;
                return;
            }


            //Middel Line In Your Keyboard
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                btnEnter.BackColor = Color.DimGray;
            }
            if (Key == "A")
            {
                btnA.BackColor = Color.DimGray;
                return;
            }
            if (Key == "S")
            {
                btnS.BackColor = Color.DimGray;
                return;
            }
            

            if (Key == "D")
            {
                btnD.BackColor = Color.DimGray;
                return;
            }
            if (Key == "F")
            {
                btnF.BackColor = Color.DimGray;
                return;
            }
            if (Key == "G")
            {
                btnG.BackColor = Color.DimGray;
                return;
            }
            if (Key == "H")
            {
                btnH.BackColor = Color.DimGray;
                return;
            }
            if (Key == "J")
            {
                btnJ.BackColor = Color.DimGray;
                return;
            }
            if (Key == "K")
            {
                btnK.BackColor = Color.DimGray;
                return;
            }
            if (Key == "L")
            {
                btnL.BackColor = Color.DimGray;
                return;
            }
            if (Key == ";" || Key == ":")
            {
                btnCol.BackColor = Color.DimGray;
                return;
            }
            if (Key == "'" || Key == "\"")
            {
                btnQuet.BackColor = Color.DimGray;
                return;
            }

            //Last Line In Your Keyboard
            if (Key == "Z")
            {
                btnZ.BackColor = Color.DimGray;
                return;
            }
            if (Key == "X")
            {
                btnX.BackColor = Color.DimGray;
                return;
            }
            if (Key == "C")
            {
                btnC.BackColor = Color.DimGray;
                return;
            }
            if (Key == "V")
            {
                btnV.BackColor = Color.DimGray;
                return;
            }
            if (Key == "B")
            {
                btnB.BackColor = Color.DimGray;
                return;
            }
            if (Key == "N")
            {
                btnN.BackColor = Color.DimGray;
                return;
            }
            if (Key == "M")
            {
                btnM.BackColor = Color.DimGray;
                return;
            }
            if (Key == "," || Key == "<")
            {
                btnGreater.BackColor = Color.DimGray;
                return;
            }
            if (Key == "." || Key == ">")
            {
                btnSmaller.BackColor = Color.DimGray;
                return;
            }
            if (Key == "/" || Key == "?")
            {
                btnBackSlash.BackColor = Color.DimGray;
                return;
            }


        }
        private void txtBoard_KeyPress(object sender, KeyPressEventArgs e)
        {
            PerformKeyPressed(e);
        }
        private void txtBoard_KeyUp(object sender, KeyEventArgs e)
        {
            ResetKeysColor();
        }
    }
}
