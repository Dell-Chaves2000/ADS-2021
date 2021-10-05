
namespace Wendell_Chaves_P1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Num01 = new System.Windows.Forms.TextBox();
            this.TB_Num02 = new System.Windows.Forms.TextBox();
            this.TB_Resultado = new System.Windows.Forms.TextBox();
            this.RB_Adição = new System.Windows.Forms.RadioButton();
            this.RB_Divisão = new System.Windows.Forms.RadioButton();
            this.RB_Multiplicação = new System.Windows.Forms.RadioButton();
            this.RB_Subtração = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 01:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 02:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Escolha  a operação desejada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resultado:";
            // 
            // TB_Num01
            // 
            this.TB_Num01.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Num01.Location = new System.Drawing.Point(141, 27);
            this.TB_Num01.Name = "TB_Num01";
            this.TB_Num01.Size = new System.Drawing.Size(179, 31);
            this.TB_Num01.TabIndex = 4;
            // 
            // TB_Num02
            // 
            this.TB_Num02.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Num02.Location = new System.Drawing.Point(141, 84);
            this.TB_Num02.Name = "TB_Num02";
            this.TB_Num02.Size = new System.Drawing.Size(179, 31);
            this.TB_Num02.TabIndex = 5;
            // 
            // TB_Resultado
            // 
            this.TB_Resultado.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Resultado.Location = new System.Drawing.Point(141, 313);
            this.TB_Resultado.Name = "TB_Resultado";
            this.TB_Resultado.Size = new System.Drawing.Size(179, 31);
            this.TB_Resultado.TabIndex = 6;
            // 
            // RB_Adição
            // 
            this.RB_Adição.AutoSize = true;
            this.RB_Adição.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Adição.Location = new System.Drawing.Point(32, 162);
            this.RB_Adição.Name = "RB_Adição";
            this.RB_Adição.Size = new System.Drawing.Size(80, 27);
            this.RB_Adição.TabIndex = 7;
            this.RB_Adição.TabStop = true;
            this.RB_Adição.Text = "Adição";
            this.RB_Adição.UseVisualStyleBackColor = true;
            this.RB_Adição.CheckedChanged += new System.EventHandler(this.RB_Adição_CheckedChanged);
            // 
            // RB_Divisão
            // 
            this.RB_Divisão.AutoSize = true;
            this.RB_Divisão.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Divisão.Location = new System.Drawing.Point(189, 205);
            this.RB_Divisão.Name = "RB_Divisão";
            this.RB_Divisão.Size = new System.Drawing.Size(84, 27);
            this.RB_Divisão.TabIndex = 8;
            this.RB_Divisão.TabStop = true;
            this.RB_Divisão.Text = "Divisão";
            this.RB_Divisão.UseVisualStyleBackColor = true;
            this.RB_Divisão.CheckedChanged += new System.EventHandler(this.RB_Divisão_CheckedChanged);
            // 
            // RB_Multiplicação
            // 
            this.RB_Multiplicação.AutoSize = true;
            this.RB_Multiplicação.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Multiplicação.Location = new System.Drawing.Point(189, 155);
            this.RB_Multiplicação.Name = "RB_Multiplicação";
            this.RB_Multiplicação.Size = new System.Drawing.Size(131, 27);
            this.RB_Multiplicação.TabIndex = 9;
            this.RB_Multiplicação.TabStop = true;
            this.RB_Multiplicação.Text = "Multiplicação";
            this.RB_Multiplicação.UseVisualStyleBackColor = true;
            this.RB_Multiplicação.CheckedChanged += new System.EventHandler(this.RB_Multiplicação_CheckedChanged);
            // 
            // RB_Subtração
            // 
            this.RB_Subtração.AutoSize = true;
            this.RB_Subtração.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Subtração.Location = new System.Drawing.Point(32, 205);
            this.RB_Subtração.Name = "RB_Subtração";
            this.RB_Subtração.Size = new System.Drawing.Size(106, 27);
            this.RB_Subtração.TabIndex = 10;
            this.RB_Subtração.TabStop = true;
            this.RB_Subtração.Text = "Subtração";
            this.RB_Subtração.UseVisualStyleBackColor = true;
            this.RB_Subtração.CheckedChanged += new System.EventHandler(this.RB_Subtração_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(83, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RB_Subtração);
            this.Controls.Add(this.RB_Multiplicação);
            this.Controls.Add(this.RB_Divisão);
            this.Controls.Add(this.RB_Adição);
            this.Controls.Add(this.TB_Resultado);
            this.Controls.Add(this.TB_Num02);
            this.Controls.Add(this.TB_Num01);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Prova 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Num01;
        private System.Windows.Forms.TextBox TB_Num02;
        private System.Windows.Forms.TextBox TB_Resultado;
        private System.Windows.Forms.RadioButton RB_Adição;
        private System.Windows.Forms.RadioButton RB_Divisão;
        private System.Windows.Forms.RadioButton RB_Multiplicação;
        private System.Windows.Forms.RadioButton RB_Subtração;
        private System.Windows.Forms.Button button1;
    }
}

