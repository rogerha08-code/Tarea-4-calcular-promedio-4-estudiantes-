namespace Tareas_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                
                double nota1 = ValidarNota(txtNota1.Text, "Nota 1");
                double nota2 = ValidarNota(txtNota2.Text, "Nota 2");
                double nota3 = ValidarNota(txtNota3.Text, "Nota 3");
                double nota4 = ValidarNota(txtNota4.Text, "Nota 4");

            
                double promedio = (nota1 + nota2 + nota3 + nota4) / 4;
                lblPromedio.Text = promedio.ToString("F2");

               
                if (promedio > 69)
                {
                    txtResultado.Text = "Aprobado";
                    txtCompletivo.Enabled = false;
                    txtCompletivo.Text = "";
                    return;
                }

              
                txtCompletivo.Enabled = true;

                if (string.IsNullOrWhiteSpace(txtCompletivo.Text))
                {
                    txtResultado.Text = "Ingrese nota del completivo";
                    return;
                }

                double completivo = ValidarNota(txtCompletivo.Text, "Completivo");

                
                double notaCompleta = promedio * 0.5 + completivo * 0.5;

                if (notaCompleta >= 70)
                {
                    txtResultado.Text = "Extraordinario";
                }
                else
                {
                   
                    double notaExtraordinario = promedio * 0.3 + completivo * 0.7;

                    if (notaExtraordinario >= 70)
                        txtResultado.Text = "Extraordinario";
                    else
                        txtResultado.Text = "Reprobado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double ValidarNota(string texto, string nombreNota)
        {
            if (!double.TryParse(texto, out double nota))
                throw new Exception($"{nombreNota} inválida");

            if (nota < 0 || nota > 100)
                throw new Exception($"{nombreNota} debe estar entre 0 y 100");

            return nota;
        }
    }
}