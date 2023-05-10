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
            resultados = new ListBox();
            SuspendLayout();
            // 
            // adicao
            // 
            adicao.BackColor = SystemColors.ControlLight;
            adicao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            adicao.Location = new Point(402, 125);
            adicao.Name = "adicao";
            adicao.Size = new Size(57, 55);
            adicao.TabIndex = 2;
            adicao.Text = "+";
            adicao.UseVisualStyleBackColor = false;
            adicao.Click += adicao_Click;
            // 
            // subtracao
            // 
            subtracao.BackColor = SystemColors.ControlLight;
            subtracao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            subtracao.Location = new Point(406, 186);
            subtracao.Name = "subtracao";
            subtracao.Size = new Size(53, 55);
            subtracao.TabIndex = 3;
            subtracao.Text = "-";
            subtracao.UseVisualStyleBackColor = false;
            subtracao.Click += subtracao_Click;
            // 
            // divisao
            // 
            divisao.BackColor = SystemColors.ControlLight;
            divisao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            divisao.Location = new Point(406, 308);
            divisao.Name = "divisao";
            divisao.Size = new Size(53, 55);
            divisao.TabIndex = 4;
            divisao.Text = "/";
            divisao.UseVisualStyleBackColor = false;
            divisao.Click += divisao_Click;
            // 
            // multiplicacao
            // 
            multiplicacao.BackColor = SystemColors.ControlLight;
            multiplicacao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            multiplicacao.Location = new Point(406, 247);
            multiplicacao.Name = "multiplicacao";
            multiplicacao.Size = new Size(53, 55);
            multiplicacao.TabIndex = 5;
            multiplicacao.Text = "*";
            multiplicacao.UseVisualStyleBackColor = false;
            multiplicacao.Click += multiplicacao_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(217, 125);
            button1.Name = "button1";
            button1.Size = new Size(55, 55);
            button1.TabIndex = 6;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonNumero_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(278, 125);
            button2.Name = "button2";
            button2.Size = new Size(55, 55);
            button2.TabIndex = 7;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonNumero_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(339, 125);
            button3.Name = "button3";
            button3.Size = new Size(57, 55);
            button3.TabIndex = 8;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonNumero_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLight;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(217, 186);
            button4.Name = "button4";
            button4.Size = new Size(55, 55);
            button4.TabIndex = 9;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += buttonNumero_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLight;
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(276, 186);
            button5.Name = "button5";
            button5.Size = new Size(57, 55);
            button5.TabIndex = 10;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += buttonNumero_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLight;
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(339, 186);
            button6.Name = "button6";
            button6.Size = new Size(57, 55);
            button6.TabIndex = 11;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += buttonNumero_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlLight;
            button7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(217, 247);
            button7.Name = "button7";
            button7.Size = new Size(57, 55);
            button7.TabIndex = 12;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += buttonNumero_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ControlLight;
            button8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(280, 247);
            button8.Name = "button8";
            button8.Size = new Size(57, 55);
            button8.TabIndex = 13;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += buttonNumero_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlLight;
            button9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(343, 247);
            button9.Name = "button9";
            button9.Size = new Size(57, 55);
            button9.TabIndex = 14;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += buttonNumero_Click;
            // 
            // button0
            // 
            button0.BackColor = SystemColors.ControlLight;
            button0.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button0.Location = new Point(217, 308);
            button0.Name = "button0";
            button0.Size = new Size(120, 55);
            button0.TabIndex = 15;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += buttonNumero_Click;
            // 
            // buttonPonto
            // 
            buttonPonto.BackColor = SystemColors.ControlLight;
            buttonPonto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPonto.Location = new Point(343, 308);
            buttonPonto.Name = "buttonPonto";
            buttonPonto.Size = new Size(53, 55);
            buttonPonto.TabIndex = 16;
            buttonPonto.Text = ",";
            buttonPonto.UseVisualStyleBackColor = false;
            buttonPonto.Click += buttonNumero_Click;
            // 
            // buttonIgual
            // 
            buttonIgual.BackColor = SystemColors.ControlLight;
            buttonIgual.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIgual.Location = new Point(465, 247);
            buttonIgual.Name = "buttonIgual";
            buttonIgual.Size = new Size(53, 116);
            buttonIgual.TabIndex = 17;
            buttonIgual.Text = "=";
            buttonIgual.UseVisualStyleBackColor = false;
            buttonIgual.Click += buttonIgual_Click;
            // 
            // buttonC
            // 
            buttonC.BackColor = SystemColors.ControlLight;
            buttonC.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonC.Location = new Point(465, 186);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(53, 55);
            buttonC.TabIndex = 18;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = false;
            buttonC.Click += buttonC_Click;
            // 
            // buttonCE
            // 
            buttonCE.BackColor = SystemColors.ControlLight;
            buttonCE.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCE.Location = new Point(465, 125);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(53, 55);
            buttonCE.TabIndex = 19;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = false;
            buttonCE.Click += buttonCE_Click;
            // 
            // lista
            // 
            lista.Anchor = AnchorStyles.None;
            lista.BackColor = SystemColors.ControlLight;
            lista.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lista.FormattingEnabled = true;
            lista.ItemHeight = 30;
            lista.Location = new Point(217, 55);
            lista.Name = "lista";
            lista.Size = new Size(301, 64);
            lista.TabIndex = 20;
            // 
            // resultados
            // 
            resultados.BackColor = SystemColors.ControlLight;
            resultados.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            resultados.FormattingEnabled = true;
            resultados.ItemHeight = 20;
            resultados.Location = new Point(524, 125);
            resultados.Name = "resultados";
            resultados.Size = new Size(125, 224);
            resultados.TabIndex = 21;
            resultados.SelectedIndexChanged += resultados_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(834, 457);
            Controls.Add(resultados);
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
        private ListBox resultados;
    }
}