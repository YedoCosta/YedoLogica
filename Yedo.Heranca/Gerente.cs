class Gerente : Funcionario
{
    public string Usuario { get; set; }
    public string Senha { get; set; }

    public double CalculaBonificacao()
    {
        return this.Salario * 0.3;
    }
    public double SalarioTotal()
    {
        return this.Salario + (this.Salario * 0.3);
    }

}