namespace Calculator_Windows
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
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDisplay2 = new System.Windows.Forms.TextBox();
            this.txtDisplay1 = new System.Windows.Forms.TextBox();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.bnt8 = new System.Windows.Forms.Button();
            this.bnt9 = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.bnt7 = new System.Windows.Forms.Button();
            this.bnt5 = new System.Windows.Forms.Button();
            this.bnt6 = new System.Windows.Forms.Button();
            this.BtnPl = new System.Windows.Forms.Button();
            this.bnt4 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.bnt2 = new System.Windows.Forms.Button();
            this.bnt3 = new System.Windows.Forms.Button();
            this.bnt1 = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.Btnequal = new System.Windows.Forms.Button();
            this.BtnMn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitle
            // 
            this.PanelTitle.Controls.Add(this.label1);
            this.PanelTitle.Controls.Add(this.panel1);
            this.PanelTitle.Controls.Add(this.button1);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(386, 40);
            this.PanelTitle.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(347, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 40);
            this.panel1.TabIndex = 1;
            // 
            // txtDisplay2
            // 
            this.txtDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay2.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDisplay2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay2.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDisplay2.Location = new System.Drawing.Point(0, 40);
            this.txtDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.txtDisplay2.Multiline = true;
            this.txtDisplay2.Name = "txtDisplay2";
            this.txtDisplay2.Size = new System.Drawing.Size(386, 20);
            this.txtDisplay2.TabIndex = 2;
            this.txtDisplay2.Text = "0";
            this.txtDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDisplay1
            // 
            this.txtDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay1.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDisplay1.Font = new System.Drawing.Font("Gadugi", 30.25F, System.Drawing.FontStyle.Bold);
            this.txtDisplay1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDisplay1.Location = new System.Drawing.Point(0, 60);
            this.txtDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.txtDisplay1.Multiline = true;
            this.txtDisplay1.Name = "txtDisplay1";
            this.txtDisplay1.Size = new System.Drawing.Size(386, 50);
            this.txtDisplay1.TabIndex = 3;
            this.txtDisplay1.Text = "0";
            this.txtDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay1.TextChanged += new System.EventHandler(this.txtDisplay1_TextChanged);
            // 
            // BtnCE
            // 
            this.BtnCE.Font = new System.Drawing.Font("Gadugi", 20F);
            this.BtnCE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnCE.Location = new System.Drawing.Point(12, 143);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(85, 70);
            this.BtnCE.TabIndex = 4;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = true;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.Font = new System.Drawing.Font("Gadugi", 20F);
            this.BtnDiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnDiv.Location = new System.Drawing.Point(194, 143);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(85, 70);
            this.BtnDiv.TabIndex = 5;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.op_click);
            // 
            // BtnC
            // 
            this.BtnC.Font = new System.Drawing.Font("Gadugi", 20F);
            this.BtnC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnC.Location = new System.Drawing.Point(103, 143);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(85, 70);
            this.BtnC.TabIndex = 7;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // bnt8
            // 
            this.bnt8.Font = new System.Drawing.Font("Gadugi", 20F);
            this.bnt8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bnt8.Location = new System.Drawing.Point(103, 219);
            this.bnt8.Name = "bnt8";
            this.bnt8.Size = new System.Drawing.Size(85, 70);
            this.bnt8.TabIndex = 11;
            this.bnt8.Text = "8";
            this.bnt8.UseVisualStyleBackColor = true;
            this.bnt8.Click += new System.EventHandler(this.n_click);
            // 
            // bnt9
            // 
            this.bnt9.Font = new System.Drawing.Font("Gadugi", 20F);
            this.bnt9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bnt9.Location = new System.Drawing.Point(194, 219);
            this.bnt9.Name = "bnt9";
            this.bnt9.Size = new System.Drawing.Size(85, 70);
            this.bnt9.TabIndex = 10;
            this.bnt9.Text = "9";
            this.bnt9.UseVisualStyleBackColor = true;
            this.bnt9.Click += new System.EventHandler(this.n_click);
            // 
            // BtnMul
            // 
            this.BtnMul.Font = new System.Drawing.Font("Gadugi", 20F);
            this.BtnMul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnMul.Location = new System.Drawing.Point(285, 143);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(85, 70);
            this.BtnMul.TabIndex = 9;
            this.BtnMul.Text = "x";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.op_click);
            // 
            // bnt7
            // 
            this.bnt7.Font = new System.Drawing.Font("Gadugi", 20F);
            this.bnt7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bnt7.Location = new System.Drawing.Point(12, 219);
            this.bnt7.Name = "bnt7";
            this.bnt7.Size = new System.Drawing.Size(85, 70);
            this.bnt7.TabIndex = 8;
            this.bnt7.Text = "7";
            this.bnt7.UseVisualStyleBackColor = true;
            this.bnt7.Click += new System.EventHandler(this.n_click);
            // 
            // bnt5
            // 
            this.bnt5.Font = new System.Drawing.Font("Gadugi", 20F);
            this.bnt5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bnt5.Location = new System.Drawing.Point(103, 295);
            this.bnt5.Name = "bnt5";
            this.bnt5.Size = new System.Drawing.Size(85, 70);
            this.bnt5.TabIndex = 15;
            this.bnt5.Text = "5";
            this.bnt5.UseVisualStyleBackColor = true;
            this.bnt5.Click += new System.EventHandler(this.n_click);
            // 
            // bnt6
            // 
            this.bnt6.Font = new System.Drawing.Font("Gadugi", 20F);
            this.bnt6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bnt6.Location = new System.Drawing.Point(194, 295);
            this.bnt6.Name = "bnt6";
            this.bnt6.Size = new System.Drawing.Size(85, 70);
            this.bnt6.TabIndex = 14;
            this.bnt6.Text = "6";
            this.bnt6.UseVisualStyleBackColor = true;
            this.bnt6.Click += new System.EventHandler(this.n_click);
            // 
            // BtnPl
            // 
            this.BtnPl.Font = new System.Drawing.Font("Gadugi", 20F);
            this.BtnPl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnPl.Location = new System.Drawing.Point(285, 219);
            this.BtnPl.Name = "BtnPl";
            this.BtnPl.Size = new System.Drawing.Size(85, 70);
            this.BtnPl.TabIndex = 13;
            this.BtnPl.Text = "+";
            this.BtnPl.UseVisualStyleBackColor = true;
            this.BtnPl.Click += new System.EventHandler(this.op_click);
            // 
            // bnt4
            // 
            this.bnt4.Font = new System.Drawing.Font("Gadugi", 20F);
            this.bnt4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bnt4.Location = new System.Drawing.Point(12, 295);
            this.bnt4.Name = "bnt4";
            this.bnt4.Size = new System.Drawing.Size(85, 70);
            this.bnt4.TabIndex = 12;
            this.bnt4.Text = "4";
            this.bnt4.UseVisualStyleBackColor = true;
            this.bnt4.Click += new System.EventHandler(this.n_click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Gadugi", 20F);
            this.btn0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn0.Location = new System.Drawing.Point(12, 447);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(176, 70);
            this.btn0.TabIndex = 19;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.n_click);
            // 
            // bnt2
            // 
            this.bnt2.Font = new System.Drawing.Font("Gadugi", 20F);
            this.bnt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bnt2.Location = new System.Drawing.Point(103, 371);
            this.bnt2.Name = "bnt2";
            this.bnt2.Size = new System.Drawing.Size(85, 70);
            this.bnt2.TabIndex = 18;
            this.bnt2.Text = "2";
            this.bnt2.UseVisualStyleBackColor = true;
            this.bnt2.Click += new System.EventHandler(this.n_click);
            // 
            // bnt3
            // 
            this.bnt3.Font = new System.Drawing.Font("Gadugi", 20F);
            this.bnt3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bnt3.Location = new System.Drawing.Point(194, 371);
            this.bnt3.Name = "bnt3";
            this.bnt3.Size = new System.Drawing.Size(85, 70);
            this.bnt3.TabIndex = 17;
            this.bnt3.Text = "3";
            this.bnt3.UseVisualStyleBackColor = true;
            this.bnt3.Click += new System.EventHandler(this.n_click);
            // 
            // bnt1
            // 
            this.bnt1.Font = new System.Drawing.Font("Gadugi", 20F);
            this.bnt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bnt1.Location = new System.Drawing.Point(12, 371);
            this.bnt1.Name = "bnt1";
            this.bnt1.Size = new System.Drawing.Size(85, 70);
            this.bnt1.TabIndex = 16;
            this.bnt1.Text = "1";
            this.bnt1.UseVisualStyleBackColor = true;
            this.bnt1.Click += new System.EventHandler(this.n_click);
            // 
            // BtnDot
            // 
            this.BtnDot.Font = new System.Drawing.Font("Gadugi", 20F);
            this.BtnDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnDot.Location = new System.Drawing.Point(194, 447);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(85, 70);
            this.BtnDot.TabIndex = 23;
            this.BtnDot.Text = ".";
            this.BtnDot.UseVisualStyleBackColor = true;
            this.BtnDot.Click += new System.EventHandler(this.n_click);
            // 
            // Btnequal
            // 
            this.Btnequal.Font = new System.Drawing.Font("Gadugi", 20.75F, System.Drawing.FontStyle.Bold);
            this.Btnequal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btnequal.Location = new System.Drawing.Point(285, 371);
            this.Btnequal.Name = "Btnequal";
            this.Btnequal.Size = new System.Drawing.Size(85, 146);
            this.Btnequal.TabIndex = 22;
            this.Btnequal.Text = "=";
            this.Btnequal.UseVisualStyleBackColor = true;
            this.Btnequal.Click += new System.EventHandler(this.Btnequal_Click);
            // 
            // BtnMn
            // 
            this.BtnMn.Font = new System.Drawing.Font("Gadugi", 20F);
            this.BtnMn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnMn.Location = new System.Drawing.Point(285, 295);
            this.BtnMn.Name = "BtnMn";
            this.BtnMn.Size = new System.Drawing.Size(85, 70);
            this.BtnMn.TabIndex = 24;
            this.BtnMn.Text = "-";
            this.BtnMn.UseVisualStyleBackColor = true;
            this.BtnMn.Click += new System.EventHandler(this.op_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calculatrise";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(386, 532);
            this.Controls.Add(this.BtnMn);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.Btnequal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.bnt2);
            this.Controls.Add(this.bnt3);
            this.Controls.Add(this.bnt1);
            this.Controls.Add(this.bnt5);
            this.Controls.Add(this.bnt6);
            this.Controls.Add(this.BtnPl);
            this.Controls.Add(this.bnt4);
            this.Controls.Add(this.bnt8);
            this.Controls.Add(this.bnt9);
            this.Controls.Add(this.BtnMul);
            this.Controls.Add(this.bnt7);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.txtDisplay1);
            this.Controls.Add(this.txtDisplay2);
            this.Controls.Add(this.PanelTitle);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDisplay2;
        private System.Windows.Forms.TextBox txtDisplay1;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button bnt8;
        private System.Windows.Forms.Button bnt9;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button bnt7;
        private System.Windows.Forms.Button bnt5;
        private System.Windows.Forms.Button bnt6;
        private System.Windows.Forms.Button BtnPl;
        private System.Windows.Forms.Button bnt4;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button bnt2;
        private System.Windows.Forms.Button bnt3;
        private System.Windows.Forms.Button bnt1;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Button Btnequal;
        private System.Windows.Forms.Button BtnMn;
        private System.Windows.Forms.Label label1;
    }
}

