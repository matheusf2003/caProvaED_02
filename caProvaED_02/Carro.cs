using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaED_02
{
    internal class Carro
    {
        private String nome;
        private Carro prox;

        public Carro()
        {
            nome = "";
            prox = null;
        }
        public Carro(String nome)
        {
            this.nome = nome;
            prox = null;
        }
        public Carro(String nome, Carro prox)
        {
            this.nome = nome;
            this.prox = prox;
        }

        public string Nome { get => nome; set => nome = value; }
        internal Carro Prox { get => prox; set => prox = value; }
    }
}
