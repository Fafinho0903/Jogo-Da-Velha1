using System;

namespace JOGO_DA_VELHA_1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.Empte = new System.Windows.Forms.GroupBox();
            this.lblEmpate = new System.Windows.Forms.Label();
            this.empate = new System.Windows.Forms.Label();
            this.Placar = new System.Windows.Forms.GroupBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pontos2 = new System.Windows.Forms.Label();
            this.pontos1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.op2 = new System.Windows.Forms.RadioButton();
            this.op1 = new System.Windows.Forms.RadioButton();
            this.BntIniciar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.Empte.SuspendLayout();
            this.Placar.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPlayer2);
            this.groupBox1.Controls.Add(this.txtPlayer1);
            this.groupBox1.Font = new System.Drawing.Font("Bauer", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jogadores";
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.BackColor = System.Drawing.Color.White;
            this.txtPlayer2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPlayer2.Location = new System.Drawing.Point(6, 65);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.PlaceholderText = "Player 2";
            this.txtPlayer2.Size = new System.Drawing.Size(188, 27);
            this.txtPlayer2.TabIndex = 1;
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.BackColor = System.Drawing.Color.White;
            this.txtPlayer1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPlayer1.Location = new System.Drawing.Point(6, 32);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.PlaceholderText = "Player 1";
            this.txtPlayer1.Size = new System.Drawing.Size(188, 27);
            this.txtPlayer1.TabIndex = 0;
            // 
            // Empte
            // 
            this.Empte.Controls.Add(this.lblEmpate);
            this.Empte.Controls.Add(this.empate);
            this.Empte.Font = new System.Drawing.Font("Bauer", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Empte.ForeColor = System.Drawing.Color.White;
            this.Empte.Location = new System.Drawing.Point(463, 5);
            this.Empte.Name = "Empte";
            this.Empte.Size = new System.Drawing.Size(173, 105);
            this.Empte.TabIndex = 1;
            this.Empte.TabStop = false;
            this.Empte.Text = "Empate";
            this.Empte.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblEmpate
            // 
            this.lblEmpate.AutoSize = true;
            this.lblEmpate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpate.Location = new System.Drawing.Point(23, 31);
            this.lblEmpate.Name = "lblEmpate";
            this.lblEmpate.Size = new System.Drawing.Size(0, 18);
            this.lblEmpate.TabIndex = 9;
            // 
            // empate
            // 
            this.empate.AutoSize = true;
            this.empate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.empate.Location = new System.Drawing.Point(72, 45);
            this.empate.Name = "empate";
            this.empate.Size = new System.Drawing.Size(0, 18);
            this.empate.TabIndex = 0;
            this.empate.Click += new System.EventHandler(this.empate_Click);
            // 
            // Placar
            // 
            this.Placar.Controls.Add(this.lblPlayer2);
            this.Placar.Controls.Add(this.lblPlayer1);
            this.Placar.Controls.Add(this.label3);
            this.Placar.Controls.Add(this.label2);
            this.Placar.Controls.Add(this.label1);
            this.Placar.Controls.Add(this.pontos2);
            this.Placar.Controls.Add(this.pontos1);
            this.Placar.Font = new System.Drawing.Font("Bauer", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Placar.ForeColor = System.Drawing.Color.White;
            this.Placar.Location = new System.Drawing.Point(253, 5);
            this.Placar.Name = "Placar";
            this.Placar.Size = new System.Drawing.Size(204, 105);
            this.Placar.TabIndex = 1;
            this.Placar.TabStop = false;
            this.Placar.Text = "Placar";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer2.Location = new System.Drawing.Point(11, 63);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(0, 18);
            this.lblPlayer2.TabIndex = 8;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer1.Location = new System.Drawing.Point(12, 31);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(0, 18);
            this.lblPlayer1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 4;
            // 
            // pontos2
            // 
            this.pontos2.AutoSize = true;
            this.pontos2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pontos2.Location = new System.Drawing.Point(11, 74);
            this.pontos2.Name = "pontos2";
            this.pontos2.Size = new System.Drawing.Size(0, 18);
            this.pontos2.TabIndex = 3;
            // 
            // pontos1
            // 
            this.pontos1.AutoSize = true;
            this.pontos1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pontos1.Location = new System.Drawing.Point(11, 40);
            this.pontos1.Name = "pontos1";
            this.pontos1.Size = new System.Drawing.Size(0, 18);
            this.pontos1.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.op2);
            this.groupBox4.Controls.Add(this.op1);
            this.groupBox4.Font = new System.Drawing.Font("Bauer", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(12, 116);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(161, 81);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opções";
            // 
            // op2
            // 
            this.op2.AutoSize = true;
            this.op2.Font = new System.Drawing.Font("BadaBoom BB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.op2.Location = new System.Drawing.Point(101, 31);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(54, 44);
            this.op2.TabIndex = 35;
            this.op2.TabStop = true;
            this.op2.Text = "O";
            this.op2.UseVisualStyleBackColor = true;
            // 
            // op1
            // 
            this.op1.AutoSize = true;
            this.op1.Font = new System.Drawing.Font("BadaBoom BB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.op1.Location = new System.Drawing.Point(15, 31);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(51, 44);
            this.op1.TabIndex = 34;
            this.op1.TabStop = true;
            this.op1.Text = "X";
            this.op1.UseVisualStyleBackColor = true;
            // 
            // BntIniciar
            // 
            this.BntIniciar.BackColor = System.Drawing.Color.Silver;
            this.BntIniciar.FlatAppearance.BorderSize = 0;
            this.BntIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntIniciar.Font = new System.Drawing.Font("Bauer", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BntIniciar.ForeColor = System.Drawing.Color.Teal;
            this.BntIniciar.Location = new System.Drawing.Point(197, 170);
            this.BntIniciar.Name = "BntIniciar";
            this.BntIniciar.Size = new System.Drawing.Size(131, 30);
            this.BntIniciar.TabIndex = 2;
            this.BntIniciar.Text = "Iniciar";
            this.BntIniciar.UseVisualStyleBackColor = false;
            this.BntIniciar.Click += new System.EventHandler(this.BntIniciar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.Silver;
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Bauer", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReiniciar.ForeColor = System.Drawing.Color.Teal;
            this.btnReiniciar.Location = new System.Drawing.Point(349, 170);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(152, 30);
            this.btnReiniciar.TabIndex = 3;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Window;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Bauer", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.ForeColor = System.Drawing.Color.Teal;
            this.btnSair.Location = new System.Drawing.Point(518, 170);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(118, 30);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DarkCyan;
            this.btn1.Enabled = false;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(172, 210);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 50);
            this.btn1.TabIndex = 22;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnClick_Cell);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.DarkCyan;
            this.btn7.Enabled = false;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(172, 322);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 50);
            this.btn7.TabIndex = 25;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnClick_Cell);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DarkCyan;
            this.btn4.Enabled = false;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(172, 266);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 50);
            this.btn4.TabIndex = 26;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnClick_Cell);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.DarkCyan;
            this.btn9.Enabled = false;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(334, 322);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 50);
            this.btn9.TabIndex = 27;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnClick_Cell);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.DarkCyan;
            this.btn6.Enabled = false;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(334, 266);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 50);
            this.btn6.TabIndex = 28;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnClick_Cell);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DarkCyan;
            this.btn3.Enabled = false;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(334, 210);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 50);
            this.btn3.TabIndex = 29;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnClick_Cell);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DarkCyan;
            this.btn2.Enabled = false;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(253, 210);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 50);
            this.btn2.TabIndex = 30;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnClick_Cell);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.DarkCyan;
            this.btn5.Enabled = false;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(253, 266);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 50);
            this.btn5.TabIndex = 31;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnClick_Cell);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.DarkCyan;
            this.btn8.Enabled = false;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(253, 322);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 50);
            this.btn8.TabIndex = 32;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnClick_Cell);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(2, 203);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(649, 192);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(648, 394);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.BntIniciar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Empte);
            this.Controls.Add(this.Placar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Jogo da velha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Empte.ResumeLayout(false);
            this.Empte.PerformLayout();
            this.Placar.ResumeLayout(false);
            this.Placar.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox Empte;
        private GroupBox Placar;
        private GroupBox groupBox4;
        private Button BntIniciar;
        private Button btnReiniciar;
        private Button btnSair;
        private Button btn1;
        private Button btn7;
        private Button btn4;
        private Button btn9;
        private Button btn6;
        private Button btn3;
        private Button btn2;
        private Button btn5;
        private Button btn8;
        private TextBox txtPlayer2;
        private TextBox txtPlayer1;
        private Label empate;
        private RichTextBox richTextBox1;
        private Label pontos2;
        private Label pontos1;
        private Label label1;
        private RadioButton op2;
        private RadioButton op1;
        private Label label3;
        private Label label2;
        private Label lblEmpate;
        private Label lblPlayer2;
        private Label lblPlayer1;
    }
}
