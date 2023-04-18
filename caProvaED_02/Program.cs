using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaED_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estacionamento estacionamento = new Estacionamento();
            bool continua = true;
            while(continua)
            {
                Console.Clear();
                for (int i = 0; i < estacionamento.Qcarros; i++)
                {
                    Console.Write("= ");
                }
                for (int i = 0; i < (10 - estacionamento.Qcarros); i++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("\nDigite o número da ação que deseja:\n{1}Colocar carro.\n{2}Tirar carro\n{3}Parar Programa");
                int tecla = Convert.ToInt32(Console.ReadLine());
                switch (tecla)
                {
                    case 1:
                        if(estacionamento.Qcarros < 10)
                        {
                            Console.WriteLine("Digite o nome do carro:");
                            estacionamento.estaciona(Console.ReadLine());
                            Console.WriteLine("Carro " + estacionamento.Saida.Nome + "estacionado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("O estacionamento esta cheio, não é possivel estacionar mais carros no momento");
                            Console.WriteLine("Precione enter para continuar!");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Digite o nome do carro a ser retirado:");
                        String nomec = Console.ReadLine();
                        if (estacionamento.carroEstacionado(nomec))
                        {
                            if(estacionamento.Saida.Nome == nomec)
                            {
                                Console.WriteLine("Retirando seu carro " + estacionamento.tiraCarro());
                            }else
                            {
                                Estacionamento tempEstac = new Estacionamento();
                                while(estacionamento.Saida.Nome != nomec)
                                {
                                    tempEstac.estaciona(estacionamento.tiraCarro());
                                    Console.WriteLine("Retirando carro " + tempEstac.Saida.Nome);
                                }
                                Console.WriteLine("Retirando seu carro " + estacionamento.tiraCarro());
                                while (!tempEstac.estaVazio())
                                {
                                    estacionamento.estaciona(tempEstac.tiraCarro());
                                    Console.WriteLine("Recolocando caarro " + estacionamento.Saida.Nome);
                                }
                            }
                            Console.WriteLine("Precione enter para continuar!");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("O carro informadõ não se encontra estacionado!");
                        }
                        break;
                    case 3:
                        continua = false;
                        break;
                }
                
            }
        }
    }
}
