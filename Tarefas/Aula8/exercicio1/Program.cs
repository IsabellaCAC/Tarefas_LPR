using System;

Console.WriteLine("---------------------------------------------");
Console.WriteLine("------Bem vindo ao exercicio 1 da aula 8-----");
Console.WriteLine("---------------------------------------------");

public struct Produto()
{
    public string Nome;
    public int Codigo;
    public double Preco;
    public int Quantidade;
}
class aula8
{
    static void Main()
    {
        Console.WriteLine("Por favor insira os dados do produto");

        Produto[] vetorProduto = new Produto[3];
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Nome: ");
            vetorProduto[i].Nome = Console.ReadLine();
            Console.WriteLine("Codigo: ");
            vetorProduto[i].Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Preco: ");
            vetorProduto[i].Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade: ");
            vetorProduto[i].Quantidade  = int.Parse(Console.ReadLine());

        }






     }
}



