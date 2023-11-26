namespace TypingGame
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoard = new System.Windows.Forms.TextBox();
            this.gbKeyboard = new System.Windows.Forms.GroupBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnSlash = new System.Windows.Forms.Button();
            this.btnBracClose = new System.Windows.Forms.Button();
            this.btnBrac = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnQuet = new System.Windows.Forms.Button();
            this.btnCol = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnBackSlash = new System.Windows.Forms.Button();
            this.btnSmaller = new System.Windows.Forms.Button();
            this.btnGreater = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbKeyboard.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoard
            // 
            this.txtBoard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoard.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoard.Location = new System.Drawing.Point(20, 69);
            this.txtBoard.MaxLength = 1000;
            this.txtBoard.Multiline = true;
            this.txtBoard.Name = "txtBoard";
            this.txtBoard.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoard.Size = new System.Drawing.Size(905, 117);
            this.txtBoard.TabIndex = 0;
            this.txtBoard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoard_KeyPress);
            this.txtBoard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoard_KeyUp);
            // 
            // gbKeyboard
            // 
            this.gbKeyboard.Controls.Add(this.btnEnter);
            this.gbKeyboard.Controls.Add(this.btnBackspace);
            this.gbKeyboard.Controls.Add(this.btnEqual);
            this.gbKeyboard.Controls.Add(this.btnDash);
            this.gbKeyboard.Controls.Add(this.btn0);
            this.gbKeyboard.Controls.Add(this.btn9);
            this.gbKeyboard.Controls.Add(this.btn8);
            this.gbKeyboard.Controls.Add(this.btn7);
            this.gbKeyboard.Controls.Add(this.btn6);
            this.gbKeyboard.Controls.Add(this.btn5);
            this.gbKeyboard.Controls.Add(this.btn4);
            this.gbKeyboard.Controls.Add(this.btn3);
            this.gbKeyboard.Controls.Add(this.btn2);
            this.gbKeyboard.Controls.Add(this.btn1);
            this.gbKeyboard.Controls.Add(this.btnSlash);
            this.gbKeyboard.Controls.Add(this.btnBracClose);
            this.gbKeyboard.Controls.Add(this.btnBrac);
            this.gbKeyboard.Controls.Add(this.btnP);
            this.gbKeyboard.Controls.Add(this.btnO);
            this.gbKeyboard.Controls.Add(this.btnI);
            this.gbKeyboard.Controls.Add(this.btnU);
            this.gbKeyboard.Controls.Add(this.btnY);
            this.gbKeyboard.Controls.Add(this.btnT);
            this.gbKeyboard.Controls.Add(this.btnR);
            this.gbKeyboard.Controls.Add(this.btnQuet);
            this.gbKeyboard.Controls.Add(this.btnCol);
            this.gbKeyboard.Controls.Add(this.btnL);
            this.gbKeyboard.Controls.Add(this.btnK);
            this.gbKeyboard.Controls.Add(this.btnJ);
            this.gbKeyboard.Controls.Add(this.btnH);
            this.gbKeyboard.Controls.Add(this.btnG);
            this.gbKeyboard.Controls.Add(this.btnF);
            this.gbKeyboard.Controls.Add(this.btnD);
            this.gbKeyboard.Controls.Add(this.btnBackSlash);
            this.gbKeyboard.Controls.Add(this.btnSmaller);
            this.gbKeyboard.Controls.Add(this.btnGreater);
            this.gbKeyboard.Controls.Add(this.btnM);
            this.gbKeyboard.Controls.Add(this.btnN);
            this.gbKeyboard.Controls.Add(this.btnB);
            this.gbKeyboard.Controls.Add(this.btnV);
            this.gbKeyboard.Controls.Add(this.btnC);
            this.gbKeyboard.Controls.Add(this.btnE);
            this.gbKeyboard.Controls.Add(this.btnX);
            this.gbKeyboard.Controls.Add(this.btnS);
            this.gbKeyboard.Controls.Add(this.btnW);
            this.gbKeyboard.Controls.Add(this.btnZ);
            this.gbKeyboard.Controls.Add(this.btnA);
            this.gbKeyboard.Controls.Add(this.btnQ);
            this.gbKeyboard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbKeyboard.Enabled = false;
            this.gbKeyboard.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKeyboard.ForeColor = System.Drawing.Color.Gray;
            this.gbKeyboard.Location = new System.Drawing.Point(10, 258);
            this.gbKeyboard.Name = "gbKeyboard";
            this.gbKeyboard.Size = new System.Drawing.Size(945, 256);
            this.gbKeyboard.TabIndex = 1;
            this.gbKeyboard.TabStop = false;
            this.gbKeyboard.Text = "Keyboard";
            // 
            // btnEnter
            // 
            this.btnEnter.AutoSize = true;
            this.btnEnter.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(741, 138);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(125, 35);
            this.btnEnter.TabIndex = 48;
            this.btnEnter.Text = "Enter";
            this.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // btnBackspace
            // 
            this.btnBackspace.AutoSize = true;
            this.btnBackspace.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.Location = new System.Drawing.Point(741, 54);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(125, 36);
            this.btnBackspace.TabIndex = 47;
            this.btnBackspace.Text = "Backspace\r\n<--";
            this.btnBackspace.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            this.btnEqual.AutoSize = true;
            this.btnEqual.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(684, 54);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(42, 36);
            this.btnEqual.TabIndex = 46;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            // 
            // btnDash
            // 
            this.btnDash.AutoSize = true;
            this.btnDash.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.Location = new System.Drawing.Point(630, 54);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(42, 36);
            this.btnDash.TabIndex = 45;
            this.btnDash.Text = "-";
            this.btnDash.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.AutoSize = true;
            this.btn0.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(576, 54);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(42, 36);
            this.btn0.TabIndex = 44;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.AutoSize = true;
            this.btn9.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(522, 54);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(42, 36);
            this.btn9.TabIndex = 43;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.AutoSize = true;
            this.btn8.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(468, 54);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(42, 36);
            this.btn8.TabIndex = 42;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.AutoSize = true;
            this.btn7.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(414, 54);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(42, 36);
            this.btn7.TabIndex = 41;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.AutoSize = true;
            this.btn6.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(360, 54);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(42, 36);
            this.btn6.TabIndex = 40;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.AutoSize = true;
            this.btn5.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(306, 54);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(42, 36);
            this.btn5.TabIndex = 39;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.AutoSize = true;
            this.btn4.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(252, 54);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(42, 36);
            this.btn4.TabIndex = 38;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(198, 54);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(42, 36);
            this.btn3.TabIndex = 37;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(144, 54);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(42, 36);
            this.btn2.TabIndex = 36;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(90, 54);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(42, 36);
            this.btn1.TabIndex = 35;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btnSlash
            // 
            this.btnSlash.AutoSize = true;
            this.btnSlash.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlash.Location = new System.Drawing.Point(697, 96);
            this.btnSlash.Name = "btnSlash";
            this.btnSlash.Size = new System.Drawing.Size(42, 36);
            this.btnSlash.TabIndex = 34;
            this.btnSlash.Text = "\\";
            this.btnSlash.UseVisualStyleBackColor = true;
            // 
            // btnBracClose
            // 
            this.btnBracClose.AutoSize = true;
            this.btnBracClose.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBracClose.Location = new System.Drawing.Point(645, 96);
            this.btnBracClose.Name = "btnBracClose";
            this.btnBracClose.Size = new System.Drawing.Size(42, 36);
            this.btnBracClose.TabIndex = 33;
            this.btnBracClose.Text = "]";
            this.btnBracClose.UseVisualStyleBackColor = true;
            // 
            // btnBrac
            // 
            this.btnBrac.AutoSize = true;
            this.btnBrac.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrac.Location = new System.Drawing.Point(593, 96);
            this.btnBrac.Name = "btnBrac";
            this.btnBrac.Size = new System.Drawing.Size(42, 36);
            this.btnBrac.TabIndex = 32;
            this.btnBrac.Text = "[";
            this.btnBrac.UseVisualStyleBackColor = true;
            // 
            // btnP
            // 
            this.btnP.AutoSize = true;
            this.btnP.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.Location = new System.Drawing.Point(541, 96);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(42, 36);
            this.btnP.TabIndex = 31;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            // 
            // btnO
            // 
            this.btnO.AutoSize = true;
            this.btnO.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnO.Location = new System.Drawing.Point(489, 96);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(42, 36);
            this.btnO.TabIndex = 30;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            // 
            // btnI
            // 
            this.btnI.AutoSize = true;
            this.btnI.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.Location = new System.Drawing.Point(437, 96);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(42, 36);
            this.btnI.TabIndex = 29;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = true;
            // 
            // btnU
            // 
            this.btnU.AutoSize = true;
            this.btnU.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.Location = new System.Drawing.Point(385, 96);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(42, 36);
            this.btnU.TabIndex = 27;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = true;
            // 
            // btnY
            // 
            this.btnY.AutoSize = true;
            this.btnY.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY.Location = new System.Drawing.Point(333, 96);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(42, 36);
            this.btnY.TabIndex = 26;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            // 
            // btnT
            // 
            this.btnT.AutoSize = true;
            this.btnT.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.Location = new System.Drawing.Point(281, 96);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(42, 36);
            this.btnT.TabIndex = 25;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = true;
            // 
            // btnR
            // 
            this.btnR.AutoSize = true;
            this.btnR.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.Location = new System.Drawing.Point(229, 96);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(42, 36);
            this.btnR.TabIndex = 24;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            // 
            // btnQuet
            // 
            this.btnQuet.AutoSize = true;
            this.btnQuet.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuet.Location = new System.Drawing.Point(624, 138);
            this.btnQuet.Name = "btnQuet";
            this.btnQuet.Size = new System.Drawing.Size(42, 36);
            this.btnQuet.TabIndex = 23;
            this.btnQuet.Text = "\'";
            this.btnQuet.UseVisualStyleBackColor = true;
            // 
            // btnCol
            // 
            this.btnCol.AutoSize = true;
            this.btnCol.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCol.Location = new System.Drawing.Point(576, 138);
            this.btnCol.Name = "btnCol";
            this.btnCol.Size = new System.Drawing.Size(42, 36);
            this.btnCol.TabIndex = 22;
            this.btnCol.Text = ";";
            this.btnCol.UseVisualStyleBackColor = true;
            // 
            // btnL
            // 
            this.btnL.AutoSize = true;
            this.btnL.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(528, 138);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(42, 36);
            this.btnL.TabIndex = 21;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = true;
            // 
            // btnK
            // 
            this.btnK.AutoSize = true;
            this.btnK.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK.Location = new System.Drawing.Point(480, 138);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(42, 36);
            this.btnK.TabIndex = 20;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = true;
            // 
            // btnJ
            // 
            this.btnJ.AutoSize = true;
            this.btnJ.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ.Location = new System.Drawing.Point(432, 138);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(42, 36);
            this.btnJ.TabIndex = 19;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = true;
            // 
            // btnH
            // 
            this.btnH.AutoSize = true;
            this.btnH.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.Location = new System.Drawing.Point(384, 138);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(42, 36);
            this.btnH.TabIndex = 18;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = true;
            // 
            // btnG
            // 
            this.btnG.AutoSize = true;
            this.btnG.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.Location = new System.Drawing.Point(336, 138);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(42, 36);
            this.btnG.TabIndex = 17;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = true;
            // 
            // btnF
            // 
            this.btnF.AutoSize = true;
            this.btnF.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.Location = new System.Drawing.Point(288, 138);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(42, 36);
            this.btnF.TabIndex = 16;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            this.btnD.AutoSize = true;
            this.btnD.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(230, 138);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(42, 36);
            this.btnD.TabIndex = 15;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            // 
            // btnBackSlash
            // 
            this.btnBackSlash.AutoSize = true;
            this.btnBackSlash.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSlash.Location = new System.Drawing.Point(588, 189);
            this.btnBackSlash.Name = "btnBackSlash";
            this.btnBackSlash.Size = new System.Drawing.Size(42, 36);
            this.btnBackSlash.TabIndex = 14;
            this.btnBackSlash.Text = "/";
            this.btnBackSlash.UseVisualStyleBackColor = true;
            // 
            // btnSmaller
            // 
            this.btnSmaller.AutoSize = true;
            this.btnSmaller.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmaller.Location = new System.Drawing.Point(540, 189);
            this.btnSmaller.Name = "btnSmaller";
            this.btnSmaller.Size = new System.Drawing.Size(42, 36);
            this.btnSmaller.TabIndex = 13;
            this.btnSmaller.Text = ".";
            this.btnSmaller.UseVisualStyleBackColor = true;
            // 
            // btnGreater
            // 
            this.btnGreater.AutoSize = true;
            this.btnGreater.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreater.Location = new System.Drawing.Point(492, 189);
            this.btnGreater.Name = "btnGreater";
            this.btnGreater.Size = new System.Drawing.Size(42, 36);
            this.btnGreater.TabIndex = 12;
            this.btnGreater.Text = ",";
            this.btnGreater.UseVisualStyleBackColor = true;
            // 
            // btnM
            // 
            this.btnM.AutoSize = true;
            this.btnM.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(444, 189);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(42, 36);
            this.btnM.TabIndex = 11;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            // 
            // btnN
            // 
            this.btnN.AutoSize = true;
            this.btnN.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.Location = new System.Drawing.Point(396, 189);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(42, 36);
            this.btnN.TabIndex = 10;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            this.btnB.AutoSize = true;
            this.btnB.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(348, 189);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(42, 36);
            this.btnB.TabIndex = 9;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // btnV
            // 
            this.btnV.AutoSize = true;
            this.btnV.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV.Location = new System.Drawing.Point(300, 189);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(42, 36);
            this.btnV.TabIndex = 8;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.AutoSize = true;
            this.btnC.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(252, 189);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(42, 36);
            this.btnC.TabIndex = 7;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnE
            // 
            this.btnE.AutoSize = true;
            this.btnE.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(177, 96);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(42, 36);
            this.btnE.TabIndex = 6;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            // 
            // btnX
            // 
            this.btnX.AutoSize = true;
            this.btnX.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(204, 189);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(42, 36);
            this.btnX.TabIndex = 5;
            this.btnX.Text = "x";
            this.btnX.UseVisualStyleBackColor = true;
            // 
            // btnS
            // 
            this.btnS.AutoSize = true;
            this.btnS.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(182, 138);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(42, 36);
            this.btnS.TabIndex = 4;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            // 
            // btnW
            // 
            this.btnW.AutoSize = true;
            this.btnW.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnW.Location = new System.Drawing.Point(125, 96);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(42, 36);
            this.btnW.TabIndex = 3;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            // 
            // btnZ
            // 
            this.btnZ.AutoSize = true;
            this.btnZ.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZ.Location = new System.Drawing.Point(156, 189);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(42, 36);
            this.btnZ.TabIndex = 2;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
            // 
            // btnA
            // 
            this.btnA.AutoSize = true;
            this.btnA.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(134, 138);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(42, 36);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            // 
            // btnQ
            // 
            this.btnQ.AutoSize = true;
            this.btnQ.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ.Location = new System.Drawing.Point(73, 96);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(42, 36);
            this.btnQ.TabIndex = 0;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoard);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.groupBox1.Size = new System.Drawing.Size(945, 201);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Board";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(965, 524);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbKeyboard);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Typing Follower";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbKeyboard.ResumeLayout(false);
            this.gbKeyboard.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoard;
        private System.Windows.Forms.GroupBox gbKeyboard;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnBackSlash;
        private System.Windows.Forms.Button btnSmaller;
        private System.Windows.Forms.Button btnGreater;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnQuet;
        private System.Windows.Forms.Button btnCol;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnSlash;
        private System.Windows.Forms.Button btnBracClose;
        private System.Windows.Forms.Button btnBrac;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnEnter;
    }
}

