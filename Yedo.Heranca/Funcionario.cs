class Funcionario
{
    public string Nome { get; set; }
    public double Salario { get; set; }

    public double CalculaBonificacao()
    {
        return this.Salario * 0.1; 
    }
    public double SalarioTotal()
    {
        return  this.Salario + (this.Salario * 0.1);
    }

}