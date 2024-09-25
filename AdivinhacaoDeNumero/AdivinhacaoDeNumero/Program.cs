using System;
using System.Buffers;

Random random = new Random();
int minimo = 1;
int maximo = 100;
int numAleatorio;
int resposta;
int numRespostas;
String novamente = "";
bool jogarNovamente = true;

while (jogarNovamente)
{
    numAleatorio = random.Next(minimo, maximo + 1);
    numRespostas = 0;
    resposta = 0;

    while (resposta != numAleatorio)
    {
        Console.Write("Digite um número entre " + minimo + " - " + maximo + ": ");
        resposta = Convert.ToInt32(Console.ReadLine());

        if (resposta < numAleatorio)
        {
            Console.WriteLine(resposta + " é um valor muito baixo");
        }
        else if (resposta > numAleatorio)
        {
            Console.WriteLine(resposta + " é um valor muito alto");
        }
        numRespostas++;
    }
    Console.WriteLine("Número gerado:" + numAleatorio);
    Console.WriteLine("Resposta: " + resposta);
    Console.WriteLine("Tentativas: " + numRespostas);
    Console.WriteLine("Parabéns, você acertou!");
    Console.Write("Deseja jogar novamente? (S/N): ");
    novamente = Console.ReadLine();

    novamente = novamente.ToUpperInvariant();

    if (novamente == "S")
    {
        jogarNovamente = true;
    }
    else if (novamente == "N")
    {
        jogarNovamente = false;
    }
}

