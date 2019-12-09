private void btnRaiz_Click(object sender, EventArgs e)
{
    double n1;
    double raiz; 
    string rRaiz; 
    
    try 
    {
        n1 = Convert.ToDouble(txtN1.Text); // Converte para double o valor do campo "txtN1" e joga na variável n1
        raiz = Math.Sqrt(n1); // Aqui, é pego o valor da variável "n1", passando pelo método Math.Sqrt (usado para obter raiz quadrada) e joga na variável raiz 
        rRaiz = Convert.ToString(raiz); // Converte para String o valor da váriavel raiz e joga na variável rRaiz
        txtResultado.Text = rRaiz; // Pega o valor de rRaiz e joga no campo txtResultado.
    } 
    catch(FormatException)
    { 
        MessageBox.Show("Formatação Errada.");
    }
}