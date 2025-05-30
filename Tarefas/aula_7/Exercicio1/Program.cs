using System.Diagnostics.Contracts;

Console.WriteLine("-----------------------------------");
Console.WriteLine("------ Exercício 1 - Vetor --------");
Console.WriteLine("-----------------------------------");
  
  int [] num = new int [10];

  Console.WriteLine ("Digite 10 numeros inteiros");
  
  for (int i =0; i<10 ; i++) {
    
    Console.WriteLine ($"Numero {i+1}: ");
    num [i] = int.Parse (Console.ReadLine());
    
  }

  





