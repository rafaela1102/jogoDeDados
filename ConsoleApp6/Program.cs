using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string primeiroJogador = " ", segundoJogador = " ", resposta = " ", lancador = " ";
            double jogador1 = 0, jogador2 = 0;
            int dado1 = 0, dado2 = 0; 
            Random r = new Random();
            int contador = 0;

            Console.WriteLine("Bem vindo ao jogo, deseja jogar ?  ");
            resposta = Console.ReadLine();
            if (resposta == "sim")
            {
                Console.WriteLine("Regra 1: Na primeira rodada e feita o jogador faz uma aposta que decidira quem vai continuar na proxima rodada, caso o jogador tire 7 ou 11 é obrigado a passar o que o impede de jogar naquela rodada, caso tire 2, 3 ou 12 está fora");
                Console.WriteLine("\nRegra 2 : ganha a segunda rodada aquele que tirar a somatoria 7 ou mais");
                Console.WriteLine("\nRegra 3 O jogo acaba assim que alguém ganhar a aposta");
                Console.WriteLine("Vamos aos jogos");
                Console.WriteLine("Informe o nome do Primeiro Jogador");
                primeiroJogador = Console.ReadLine();
                Console.WriteLine("Informe o nome do segundo jogador");
                segundoJogador = Console.ReadLine();
                Console.WriteLine("Agora vamos as apostas");
                Console.WriteLine(primeiroJogador + "  qual o valor da sua aposta?");
                jogador1 = int.Parse(Console.ReadLine());
                Console.WriteLine(segundoJogador + "  qual o valor da sua aposta?");
                jogador2 = int.Parse(Console.ReadLine());
                Console.WriteLine(" vamos sortear a ordem das jogadas");

               // Sorteando um número aleatorio para identificar o lançador

                int x = r.Next(1);


                if (x == 0)
                {
                    Console.WriteLine(primeiroJogador + " Você é o lançador");
                    lancador = primeiroJogador;
                }
                else
                {
                    Console.WriteLine(segundoJogador + " Você é o lançador");
                    lancador = segundoJogador;
                };
                Console.WriteLine(" Vamos sortear");
                while (contador < 2)
                {
                    dado1 = r.Next(6);
                    dado2 = r.Next(6);

                    while (dado1 == 0)
                    {
                        dado1 = r.Next(6);

                    }

                    while (dado2 == 0)
                    {
                        dado2 = r.Next(6);

                    }
                    contador++;
                    if (contador == 1) ;
                    {
                        Console.WriteLine(lancador );
                        Console.WriteLine(" você tirou " + dado1 + dado2 );
                    }
                    


                }


                if (dado1 = 7 ||13){
                    Console.WriteLine(lancador + " você passou a vez");

                }if (dado1 = 2 || dado1 = 3 || dado1 = 12) 
                {
                    Console.WriteLine(lancador + " você está fora");
                }
                if (dado2 = 7 || 13) 
                {
                    Console.WriteLine(segundoJogador + " sua vez de sortear");
                    Console.WriteLine(" você tirou " + dado1 + dado2);
                    Console.WriteLine(segundoJogador + " você passou a vez");

                }
                if (dado2 = 2 || dado2 = 3 || dado2 = 12)
                {
                    Console.WriteLine(segundoJogador + " sua vez de sortear");
                    Console.WriteLine(" você tirou " + dado1 + dado2);
                    Console.WriteLine(segundoJogador + " você está fora");
                }
                else
                {
              

                    if (dado1 == dado2)
                    {

                        Console.WriteLine(" Houve empate "); 
                    }
                    if (dado1 > dado2)
                    {
                        Console.WriteLine(lancador + " ganhou");
                    }
                    else
                    {
                        Console.WriteLine(segundoJogador + " você ganhou!");
                    }
                }

                Console.WriteLine("");


                Console.ReadLine();


                
























            }
            else
            {
                Console.WriteLine("Que pena!");
            };
            Console.ReadKey();






        }

    }
}
