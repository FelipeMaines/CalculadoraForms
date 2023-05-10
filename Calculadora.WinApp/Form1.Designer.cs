namespace Calculadora.WinApp
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
            adicao = new Button();
            subtracao = new Button();
            divisao = new Button();
            multiplicacao = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonPonto = new Button();
            buttonIgual = new Button();
            buttonC = new Button();
            buttonCE = new Button();
            lista = new ListBox();
            SuspendLayout();
            // 
            // adicao
            // 
            adicao.Location = new Point(202, 81);
            adicao.Name = "adicao";
            adicao.Size = new Size(57, 55);
            adicao.TabIndex = 2;
            adicao.Text = "+";
            adicao.UseVisualStyleBackColor = true;
            adicao.Click += adicao_Click;
            // 
            // subtracao
            // 
            subtracao.Location = new Point(206, 142);
            subtracao.Name = "subtracao";
            subtracao.Size = new Size(53, 55);
            subtracao.TabIndex = 3;
            subtracao.Text = "-";
            subtracao.UseVisualStyleBackColor = true;
            subtracao.Click += subtracao_Click;
            // 
            // divisao
            // 
            divisao.Location = new Point(206, 264);
            divisao.Name = "divisao";
            divisao.Size = new Size(53, 55);
            divisao.TabIndex = 4;
            divisao.Text = "/";
            divisao.UseVisualStyleBackColor = true;
            divisao.Click += divisao_Click;
            // 
            // multiplicacao
            // 
            multiplicacao.Location = new Point(206, 203);
            multiplicacao.Name = "multiplicacao";
            multiplicacao.Size = new Size(53, 55);
            multiplicacao.TabIndex = 5;
            multiplicacao.Text = "*";
            multiplicacao.UseVisualStyleBackColor = true;
            multiplicacao.Click += multiplicacao_Click;
            // 
            // button1
            // 
            button1.Location = new Point(17, 81);
            button1.Name = "button1";
            button1.Size = new Size(55, 55);
            button1.TabIndex = 6;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonNumero_Click;
            // 
            // button2
            // 
            button2.Location = new Point(78, 81);
            button2.Name = "button2";
            button2.Size = new Size(55, 55);
            button2.TabIndex = 7;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonNumero_Click;
            // 
            // button3
            // 
            button3.Location = new Point(139, 81);
            button3.Name = "button3";
            button3.Size = new Size(57, 55);
            button3.TabIndex = 8;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonNumero_Click;
            // 
            // button4
            // 
            button4.Location = new Point(17, 142);
            button4.Name = "button4";
            button4.Size = new Size(55, 55);
            button4.TabIndex = 9;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonNumero_Click;
            // 
            // button5
            // 
            button5.Location = new Point(76, 142);
            button5.Name = "button5";
            button5.Size = new Size(57, 55);
            button5.TabIndex = 10;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonNumero_Click;
            // 
            // button6
            // 
            button6.Location = new Point(139, 142);
            button6.Name = "button6";
            button6.Size = new Size(57, 55);
            button6.TabIndex = 11;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonNumero_Click;
            // 
            // button7
            // 
            button7.Location = new Point(17, 203);
            button7.Name = "button7";
            button7.Size = new Size(57, 55);
            button7.TabIndex = 12;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonNumero_Click;
            // 
            // button8
            // 
            button8.Location = new Point(80, 203);
            button8.Name = "button8";
            button8.Size = new Size(57, 55);
            button8.TabIndex = 13;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonNumero_Click;
            // 
            // button9
            // 
            button9.Location = new Point(143, 203);
            button9.Name = "button9";
            button9.Size = new Size(57, 55);
            button9.TabIndex = 14;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonNumero_Click;
            // 
            // button0
            // 
            button0.Location = new Point(17, 264);
            button0.Name = "button0";
            button0.Size = new Size(120, 55);
            button0.TabIndex = 15;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += buttonNumero_Click;
            // 
            // buttonPonto
            // 
            buttonPonto.Location = new Point(143, 264);
            buttonPonto.Name = "buttonPonto";
            buttonPonto.Size = new Size(53, 55);
            buttonPonto.TabIndex = 16;
            buttonPonto.Text = ".";
            buttonPonto.UseVisualStyleBackColor = true;
            buttonPonto.Click += buttonPonto_Click;
            // 
            // buttonIgual
            // 
            buttonIgual.Location = new Point(265, 203);
            buttonIgual.Name = "buttonIgual";
            buttonIgual.Size = new Size(53, 116);
            buttonIgual.TabIndex = 17;
            buttonIgual.Text = "=";
            buttonIgual.UseVisualStyleBackColor = true;
            buttonIgual.Click += buttonIgual_Click;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(265, 142);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(53, 55);
            buttonC.TabIndex = 18;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // buttonCE
            // 
            buttonCE.Location = new Point(265, 81);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(53, 55);
            buttonCE.TabIndex = 19;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = true;
            buttonCE.Click += buttonCE_Click;
            // 
            // lista
            // 
            lista.FormattingEnabled = true;
            lista.ItemHeight = 15;
            lista.Location = new Point(17, 11);
            lista.Name = "lista";
            lista.Size = new Size(301, 64);
            lista.TabIndex = 20;
            lista.SelectedIndexChanged += lista_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 457);
            Controls.Add(lista);
            Controls.Add(buttonCE);
            Controls.Add(buttonC);
            Controls.Add(buttonIgual);
            Controls.Add(buttonPonto);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(multiplicacao);
            Controls.Add(divisao);
            Controls.Add(subtracao);
            Controls.Add(adicao);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private TextBox primeiroNumero;
        private TextBox segundoNumero;
        private Button adicao;
        private Button subtracao;
        private Button divisao;
        private Button multiplicacao;
        private ListBox listaResultados;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonPonto;
        private Button buttonIgual;
        private Button buttonC;
        private Button buttonCE;
        private ListBox lista;
    }
}