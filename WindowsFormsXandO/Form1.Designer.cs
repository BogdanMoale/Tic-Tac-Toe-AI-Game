namespace WindowsFormsXandO
{
    partial class TicTacToe
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.verticalLabel1 = new randz.CustomControls.VerticalLabel();
            this.verticalLabel2 = new randz.CustomControls.VerticalLabel();
            this.Side = new System.Windows.Forms.Label();
            this.Algorithm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(105, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(131, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(6, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 81);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(125, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 81);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(243, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 81);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button4.Location = new System.Drawing.Point(6, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 81);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button5.Location = new System.Drawing.Point(125, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 80);
            this.button5.TabIndex = 9;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button6.Location = new System.Drawing.Point(243, 300);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 80);
            this.button6.TabIndex = 10;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button7.Location = new System.Drawing.Point(6, 400);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 76);
            this.button7.TabIndex = 11;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button8.Location = new System.Drawing.Point(125, 400);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(102, 75);
            this.button8.TabIndex = 12;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button9.Location = new System.Drawing.Point(243, 400);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(102, 75);
            this.button9.TabIndex = 13;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(105, 56);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(131, 32);
            this.button10.TabIndex = 14;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // verticalLabel1
            // 
            this.verticalLabel1.Location = new System.Drawing.Point(109, 127);
            this.verticalLabel1.Name = "verticalLabel1";
            this.verticalLabel1.RenderingMode = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.verticalLabel1.Size = new System.Drawing.Size(10, 364);
            this.verticalLabel1.TabIndex = 16;
            this.verticalLabel1.Text = "-------------------------------------------------------------------------------";
            this.verticalLabel1.TextDrawMode = randz.CustomControls.DrawMode.BottomUp;
            this.verticalLabel1.TransparentBackground = false;
            // 
            // verticalLabel2
            // 
            this.verticalLabel2.Location = new System.Drawing.Point(226, 127);
            this.verticalLabel2.Name = "verticalLabel2";
            this.verticalLabel2.RenderingMode = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.verticalLabel2.Size = new System.Drawing.Size(10, 364);
            this.verticalLabel2.TabIndex = 17;
            this.verticalLabel2.Text = "-------------------------------------------------------------------------------";
            this.verticalLabel2.TextDrawMode = randz.CustomControls.DrawMode.BottomUp;
            this.verticalLabel2.TransparentBackground = false;
            // 
            // Side
            // 
            this.Side.AutoSize = true;
            this.Side.Location = new System.Drawing.Point(13, 13);
            this.Side.Name = "Side";
            this.Side.Size = new System.Drawing.Size(28, 13);
            this.Side.TabIndex = 18;
            this.Side.Text = "Side";
            // 
            // Algorithm
            // 
            this.Algorithm.AutoSize = true;
            this.Algorithm.Location = new System.Drawing.Point(12, 37);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Size = new System.Drawing.Size(50, 13);
            this.Algorithm.TabIndex = 19;
            this.Algorithm.Text = "Algorithm";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 531);
            this.Controls.Add(this.Algorithm);
            this.Controls.Add(this.Side);
            this.Controls.Add(this.verticalLabel2);
            this.Controls.Add(this.verticalLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.MaximizeBox = false;
            this.Name = "TicTacToe";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label3;
        private randz.CustomControls.VerticalLabel verticalLabel1;
        private randz.CustomControls.VerticalLabel verticalLabel2;
        private System.Windows.Forms.Label Side;
        private System.Windows.Forms.Label Algorithm;
    }
}

