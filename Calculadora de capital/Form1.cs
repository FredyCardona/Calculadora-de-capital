namespace Calculadora_de_capital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double MI = double.Parse(txtminicial.Text);
            double TIA = double.Parse(txtTIanual.Text);
            int periodo = int.Parse(txtPI.Text);

            double CF = MI * Math.Pow((1 + TIA / 100), periodo);

            string resultado = $"El capital final es: {CF.ToString("0.00")}";
            lblResultado.Text = $"El capital final es: {CF.ToString("0.00")}";
            lblResultado.Font = new Font(lblResultado.Font.FontFamily, 24, FontStyle.Bold);
        }

        private void txtTIanual_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnreintentar_Click(object sender, EventArgs e)
        {
            txtminicial.Text = "";
            txtTIanual.Text = "";
            txtPI.Text = "";
        }

        private void btncuotas_Click(object sender, EventArgs e)
        {
           
            double montoPrestamo = double.Parse(lblResultado.Text.Replace("El capital final es: ", ""));

           
            double tasaInteresMensual = 0.01; 
            double cuotaMensual = double.Parse(txtCuota.Text);

            double saldoRestante = montoPrestamo;
            int numeroCuotas = 0;
            while (saldoRestante > 0)
            {
                double interes = saldoRestante * tasaInteresMensual;
                double capital = cuotaMensual - interes;
                saldoRestante -= capital;
                numeroCuotas++;
            }

            double saldoFinal = Math.Max(0, -saldoRestante);

            lblResultadoCuotas.Text = $"Número de cuotas necesarias: {numeroCuotas}\n";
            lblResultadoCuotas.Text += $"Saldo final después de las cuotas: {saldoFinal.ToString("0.00")}";
            lblResultadoCuotas.Visible = true;
        }
    }
}
