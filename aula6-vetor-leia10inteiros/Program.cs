/*faça um programa que leia 10 numeros inteiros, faça os seguintes itens.
a. imprime o vetor lido
b. imprima o vetor de tras pra frente
c. imprima até a metade do vetor
d. guarde os valores impares em um novo vetor sem os valores 0 e imprima*/


using System;

int[] numeros = new int[10];
int[] impares = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite o {0}° número: ", i + 1);
    numeros[i] = int.Parse(Console.ReadLine());
}
Console.ReadKey();

Console.WriteLine("\nVetor lido: ");
for (int i = 0; i < 10; i++)
{
    Console.Write(numeros[i] + " ");
}

Console.WriteLine("\nVetor lido invertido: ");
for (int i = 9; i >= 0; i--)
{
    Console.Write(numeros[i] + " ");
}

Console.WriteLine("\nVetor lido até a metade: ");
for (int i = 0; i < 5; i++)
{
    Console.Write(numeros[i] + " ");
}

int indiceImpares = 0;

Console.WriteLine("\nNúmeros ímpares: ");
for (int i = 0; i < 10; i++)
{
    if (numeros[i] % 2 != 0)
    {
        impares[indiceImpares] = numeros[i];
        indiceImpares++;
    }
}
for (int i = 0; i < 10; i++)
{
    if (impares[i] != 0)
        Console.Write(impares[i] + " ");
}