class Conta
{
    public static int contador;
    public int numero;

    public Conta()
    {
        Conta.contador++;
        this.numero = Conta.contador;
    }
    public static void ZeraContador()
    {
        System.Console.WriteLine("=========================");
        System.Console.WriteLine(" Contador : " + Conta.contador);
        System.Console.WriteLine(" Zerando o contador de contas ... ");
        Conta.contador = 0;
        System.Console.WriteLine(" Contador : " + Conta.contador);

    }
}