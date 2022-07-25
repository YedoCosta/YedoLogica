class Numeros
{
    public void ImprimeArray(int[] numeros0)
    {
        //this.numeros0 = numeros0;
        System.Console.WriteLine("Numeros quantidade: " + numeros0.Length);
        for (int i = 0; i < numeros0.Length; i++)
        {
            numeros0[i] = numeros0[i] + (i*2);
            System.Console.WriteLine("Numeros: " + numeros0[i]);
        }
    }
}