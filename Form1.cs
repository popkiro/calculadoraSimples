namespace calculadora
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtRESULTADO.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtRESULTADO.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtRESULTADO.Text += "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtRESULTADO.Text += "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtRESULTADO.Text += "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtRESULTADO.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtRESULTADO.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtRESULTADO.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtRESULTADO.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtRESULTADO.Text += "0";
        }

        private void btnSOMAR_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtRESULTADO.Text);
            txtRESULTADO.Text = "";
            label1.Text = "+";

        }

        private void btnSUBTRAIR_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtRESULTADO.Text);
            txtRESULTADO.Text = "";
            label1.Text = "-";
        }

        private void btnMULTI_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtRESULTADO.Text);
            txtRESULTADO.Text = "";
            label1.Text = "x";
        }

        private void btnDIVISAO_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtRESULTADO.Text);
            txtRESULTADO.Text = "";
            label1.Text = "/";
        }

        private void btnIGUAL_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtRESULTADO.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtRESULTADO.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtRESULTADO.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtRESULTADO.Text);
                    break;

            }
            txtRESULTADO.Text = Convert.ToString(Resultado);
            label1.Text = "=";
        }

        private void btnVIRGULA_Click(object sender, EventArgs e)
        {
            if (!txtRESULTADO.Text.Contains(","))
                txtRESULTADO.Text += ",";
        }

        private void btnLIMPAR_Click(object sender, EventArgs e)
        {
            txtRESULTADO.Text = "";
            label1.Text = "";
        }
    }
}
