namespace Calculadora_de_capital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtminicial = new TextBox();
            txtTIanual = new TextBox();
            txtPI = new TextBox();
            btnreintentar = new Button();
            lblResultado = new LinkLabel();
            btncuotas = new Button();
            lblResultadoCuotas = new LinkLabel();
            label5 = new Label();
            txtCuota = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(488, 76);
            label1.Name = "label1";
            label1.Size = new Size(661, 40);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de capital a plazo fijo";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(57, 689);
            button1.Name = "button1";
            button1.Size = new Size(175, 34);
            button1.TabIndex = 1;
            button1.Text = "Calcular capital";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(187, 104);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 221);
            label2.Name = "label2";
            label2.Size = new Size(263, 40);
            label2.TabIndex = 3;
            label2.Text = "Monto inicial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 192);
            label3.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(613, 221);
            label3.Name = "label3";
            label3.Size = new Size(402, 40);
            label3.TabIndex = 4;
            label3.Text = "Tasa de interes Anual";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 255, 192);
            label4.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1143, 221);
            label4.Name = "label4";
            label4.Size = new Size(567, 40);
            label4.TabIndex = 5;
            label4.Text = "Periodo de inversion (en años)";
            // 
            // txtminicial
            // 
            txtminicial.Location = new Point(29, 301);
            txtminicial.Name = "txtminicial";
            txtminicial.Size = new Size(263, 31);
            txtminicial.TabIndex = 6;
            // 
            // txtTIanual
            // 
            txtTIanual.Location = new Point(613, 291);
            txtTIanual.Name = "txtTIanual";
            txtTIanual.Size = new Size(402, 31);
            txtTIanual.TabIndex = 7;
            txtTIanual.TextChanged += txtTIanual_TextChanged;
            // 
            // txtPI
            // 
            txtPI.Location = new Point(1143, 291);
            txtPI.Name = "txtPI";
            txtPI.Size = new Size(567, 31);
            txtPI.TabIndex = 8;
            // 
            // btnreintentar
            // 
            btnreintentar.BackColor = Color.Transparent;
            btnreintentar.Location = new Point(1544, 906);
            btnreintentar.Name = "btnreintentar";
            btnreintentar.Size = new Size(175, 34);
            btnreintentar.TabIndex = 9;
            btnreintentar.Text = "Reintentar";
            btnreintentar.UseVisualStyleBackColor = false;
            btnreintentar.Click += btnreintentar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(1026, 721);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 25);
            lblResultado.TabIndex = 10;
            // 
            // btncuotas
            // 
            btncuotas.Location = new Point(708, 712);
            btncuotas.Name = "btncuotas";
            btncuotas.Size = new Size(167, 34);
            btncuotas.TabIndex = 11;
            btncuotas.Text = "Calcular Cuotas";
            btncuotas.UseVisualStyleBackColor = true;
            btncuotas.Click += btncuotas_Click;
            // 
            // lblResultadoCuotas
            // 
            lblResultadoCuotas.AutoSize = true;
            lblResultadoCuotas.Location = new Point(39, 895);
            lblResultadoCuotas.Name = "lblResultadoCuotas";
            lblResultadoCuotas.Size = new Size(26, 25);
            lblResultadoCuotas.TabIndex = 12;
            lblResultadoCuotas.TabStop = true;
            lblResultadoCuotas.Text = "\"\"";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 255, 192);
            label5.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 380);
            label5.Name = "label5";
            label5.Size = new Size(144, 40);
            label5.TabIndex = 13;
            label5.Text = "Cuotas";
            // 
            // txtCuota
            // 
            txtCuota.Location = new Point(12, 479);
            txtCuota.Name = "txtCuota";
            txtCuota.Size = new Size(280, 31);
            txtCuota.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1749, 952);
            Controls.Add(txtCuota);
            Controls.Add(label5);
            Controls.Add(lblResultadoCuotas);
            Controls.Add(btncuotas);
            Controls.Add(lblResultado);
            Controls.Add(btnreintentar);
            Controls.Add(txtPI);
            Controls.Add(txtTIanual);
            Controls.Add(txtminicial);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtminicial;
        private TextBox txtTIanual;
        private TextBox txtPI;
        private Button btnreintentar;
        private LinkLabel lblResultado;
        private Button btncuotas;
        private LinkLabel lblResultadoCuotas;
        private Label label5;
        private TextBox txtCuota;
    }
}
