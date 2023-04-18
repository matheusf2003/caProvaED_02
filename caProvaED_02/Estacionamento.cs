using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaED_02
{
    internal class Estacionamento
    {
        private Carro saida;
        private int qcarros;


        public Estacionamento()
        {
            saida = null;
            qcarros = 0;
        }
        public bool estaVazio()
        {
            return saida == null;
        }
        public void estaciona(String entrando)
        {
            if (estaVazio())
            {
                saida = new Carro(entrando);
                qcarros++;
            } else if (qcarros < 10)
            {
                Carro carro = new Carro(entrando);
                carro.Prox = saida;
                saida = carro;
                qcarros++;
            }
            else
            {
                Console.WriteLine("O Estacionamento esta cheio");
            }
            
        }
        public String tiraCarro()
        {
            if(estaVazio())
            {
                Console.WriteLine("O estacionamento esta vazio!");
                return "";
            }
            else
            {
                String temp = saida.Nome;
                saida = saida.Prox;
                qcarros--;
                return temp;
            }
        }
        public bool carroEstacionado(String ncarro)
        {
            Carro temp = saida;
            while(temp!= null)
            {
                if(temp.Nome == ncarro)
                {
                    return true;
                }
                temp = temp.Prox;
            }
            return false;
        }
        public int Qcarros { get => qcarros; set => qcarros = value; }
        internal Carro Saida { get => saida; set => saida = value; }
    }
}
