using System;
class Desafio {
    static void Main() {
        Random random = new Random();
        int nA = random.Next(0, 101);
        int t = 1;
        Console.WriteLine("Vamos tentar adivinhar um número aleatório entre 0 e 100");
        Console.WriteLine("Digite seu palpite: ");
        int p = int.Parse(Console.ReadLine());
        while (p != nA) {
            if (p > nA) {
                Console.WriteLine("Seu palpite está maior que o número, tente novamente:");
            } else {
                Console.WriteLine("Seu palpite está menor que o número, tente novamente:");
            }
            p = int.Parse(Console.ReadLine());
            t++;
        }
        Console.WriteLine($"Seu palpite está correto! Você acertou em {t} tentativa(s).");
    }
}
