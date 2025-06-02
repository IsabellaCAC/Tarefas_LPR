
Console.WriteLine("------------------------------------------");
Console.WriteLine("-------- Bem vindo ao exercicio 2---------");
Console.WriteLine("------------------------------------------");

int[] numeros = new int[10];
int buscado, ocorrencia;

Console.WriteLine("Digite 10 numeros inteiros: ");

for (int i = 0; i < 10; i++) {
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nDigite um numero para pesquisar no vetor: ");

buscado = int.Parse(Console.ReadLine());

ocorrencia = 0;

Console.WriteLine("\n Procurando o numero: {buscado}");
for (int i = 0; i < 10; i++)
{
    if (numeros[i] == buscado) {
        Console.WriteLine("O numero buscado está na posição {i}.");
        ocorrencia++;
    }
}
if (ocorrencia > 0) {
    Console.WriteLine("");
    }
