namespace Kalkulator_V3
{
    partial class Form1
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
            this.btnEndreFortegn = new System.Windows.Forms.Button();
            this.btnSlettTilbake = new System.Windows.Forms.Button();
            this.btnSquareXY = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.bntSqr = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.btnDivi = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPluss = new System.Windows.Forms.Button();
            this.btnErLik = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.inputHistory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEndreFortegn
            // 
            this.btnEndreFortegn.Location = new System.Drawing.Point(238, 354);
            this.btnEndreFortegn.Name = "btnEndreFortegn";
            this.btnEndreFortegn.Size = new System.Drawing.Size(60, 60);
            this.btnEndreFortegn.TabIndex = 47;
            this.btnEndreFortegn.Text = "±";
            this.btnEndreFortegn.UseVisualStyleBackColor = true;
            this.btnEndreFortegn.Click += new System.EventHandler(this.BtnEndreFortegn_Click);
            // 
            // btnSlettTilbake
            // 
            this.btnSlettTilbake.Location = new System.Drawing.Point(436, 90);
            this.btnSlettTilbake.Name = "btnSlettTilbake";
            this.btnSlettTilbake.Size = new System.Drawing.Size(126, 60);
            this.btnSlettTilbake.TabIndex = 45;
            this.btnSlettTilbake.Text = "Slett";
            this.btnSlettTilbake.UseVisualStyleBackColor = true;
            this.btnSlettTilbake.Click += new System.EventHandler(this.BtnSlettTilbake_Click);
            // 
            // btnSquareXY
            // 
            this.btnSquareXY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquareXY.Location = new System.Drawing.Point(502, 288);
            this.btnSquareXY.Name = "btnSquareXY";
            this.btnSquareXY.Size = new System.Drawing.Size(60, 60);
            this.btnSquareXY.TabIndex = 44;
            this.btnSquareXY.Text = "x^y";
            this.btnSquareXY.UseVisualStyleBackColor = true;
            this.btnSquareXY.Click += new System.EventHandler(this.BtnSquareXY_Click);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.btnSquareRoot.Location = new System.Drawing.Point(370, 90);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(60, 60);
            this.btnSquareRoot.TabIndex = 43;
            this.btnSquareRoot.Text = "√";
            this.btnSquareRoot.UseVisualStyleBackColor = true;
            this.btnSquareRoot.Click += new System.EventHandler(this.BtnSquareRoot_Click);
            // 
            // bntSqr
            // 
            this.bntSqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.bntSqr.Location = new System.Drawing.Point(502, 354);
            this.bntSqr.Name = "bntSqr";
            this.bntSqr.Size = new System.Drawing.Size(60, 60);
            this.bntSqr.TabIndex = 42;
            this.bntSqr.Text = "x^2";
            this.bntSqr.UseVisualStyleBackColor = true;
            this.bntSqr.Click += new System.EventHandler(this.BntSqr_Click);
            // 
            // btnComma
            // 
            this.btnComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComma.Location = new System.Drawing.Point(370, 354);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(60, 60);
            this.btnComma.TabIndex = 41;
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = true;
            this.btnComma.Click += new System.EventHandler(this.BtnComma_Click);
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(238, 39);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(324, 45);
            this.display.TabIndex = 39;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(238, 90);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(126, 60);
            this.btnC.TabIndex = 40;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // btnDivi
            // 
            this.btnDivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivi.Location = new System.Drawing.Point(502, 156);
            this.btnDivi.Name = "btnDivi";
            this.btnDivi.Size = new System.Drawing.Size(60, 60);
            this.btnDivi.TabIndex = 38;
            this.btnDivi.Text = "/";
            this.btnDivi.UseVisualStyleBackColor = true;
            this.btnDivi.Click += new System.EventHandler(this.AddSubDivMulOperasjoner);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(502, 222);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(60, 60);
            this.btnMulti.TabIndex = 37;
            this.btnMulti.Text = "x";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.AddSubDivMulOperasjoner);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(436, 156);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(60, 60);
            this.btnMinus.TabIndex = 36;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.AddSubDivMulOperasjoner);
            // 
            // btnPluss
            // 
            this.btnPluss.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPluss.Location = new System.Drawing.Point(436, 222);
            this.btnPluss.Name = "btnPluss";
            this.btnPluss.Size = new System.Drawing.Size(60, 60);
            this.btnPluss.TabIndex = 35;
            this.btnPluss.Text = "+";
            this.btnPluss.UseVisualStyleBackColor = true;
            this.btnPluss.Click += new System.EventHandler(this.AddSubDivMulOperasjoner);
            // 
            // btnErLik
            // 
            this.btnErLik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErLik.Location = new System.Drawing.Point(436, 288);
            this.btnErLik.Name = "btnErLik";
            this.btnErLik.Size = new System.Drawing.Size(60, 126);
            this.btnErLik.TabIndex = 34;
            this.btnErLik.Text = "=";
            this.btnErLik.UseVisualStyleBackColor = true;
            this.btnErLik.Click += new System.EventHandler(this.BtnErLik_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(370, 156);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 60);
            this.btn9.TabIndex = 33;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnTall_click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(304, 156);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 60);
            this.btn8.TabIndex = 32;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnTall_click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(238, 156);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 60);
            this.btn7.TabIndex = 31;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnTall_click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(370, 222);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 60);
            this.btn6.TabIndex = 30;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnTall_click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(304, 222);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 60);
            this.btn5.TabIndex = 29;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnTall_click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(238, 222);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 60);
            this.btn4.TabIndex = 28;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnTall_click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(370, 288);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 60);
            this.btn3.TabIndex = 27;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnTall_click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(238, 288);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 60);
            this.btn1.TabIndex = 26;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnTall_click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(304, 288);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 60);
            this.btn2.TabIndex = 25;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnTall_click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(304, 354);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 60);
            this.btn0.TabIndex = 24;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnTall_click);
            // 
            // inputHistory
            // 
            this.inputHistory.AutoSize = true;
            this.inputHistory.Location = new System.Drawing.Point(235, 19);
            this.inputHistory.Name = "inputHistory";
            this.inputHistory.Size = new System.Drawing.Size(16, 17);
            this.inputHistory.TabIndex = 48;
            this.inputHistory.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputHistory);
            this.Controls.Add(this.btnEndreFortegn);
            this.Controls.Add(this.btnSlettTilbake);
            this.Controls.Add(this.btnSquareXY);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.bntSqr);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.display);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnDivi);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPluss);
            this.Controls.Add(this.btnErLik);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn0);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEndreFortegn;
        private System.Windows.Forms.Button btnSlettTilbake;
        private System.Windows.Forms.Button btnSquareXY;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button bntSqr;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnDivi;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPluss;
        private System.Windows.Forms.Button btnErLik;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Label inputHistory;
    }
}

