namespace Calculadora

 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string operac = string.Empty;
        float n1, n2;
        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(val1Box.Text, out n1) || !float.TryParse(val2Box.Text, out n2))
            {
                MessageBox.Show("Operação Inválida");
            }

            operac = "SOMA";           
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(val1Box.Text, out n1) || !float.TryParse(val2Box.Text, out n2))
            {
                MessageBox.Show("Operação Inválida");
            }

            operac = "SUB";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(val1Box.Text, out n1) || !float.TryParse(val2Box.Text, out n2))
            {
                MessageBox.Show("Operação Inválida");
            }

            operac = "MULT";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(val1Box.Text, out n1) || !float.TryParse(val2Box.Text, out n2))
            {
                MessageBox.Show("Operação Inválida");
            }

            operac = "DIV";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (operac.Equals("SOMA"))           
                resultBox.Text = (n1 + n2).ToString();           
            else if (operac.Equals("SUB"))           
                resultBox.Text = (n1 - n2).ToString();          
            else if (operac.Equals("MULT"))          
                resultBox.Text= (n1 * n2).ToString();           
            else 
                resultBox.Text = (n1 / n2).ToString();
        }
    }
}