using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal class Carro
    {
        private int ano;
        public string Fabricante {  get; set; }
        public string Modelo { get; set; }
        public int Ano
        {
            get => ano;
            set
            {
                if(value < 1960 || value > 2024)
                {
                    Console.WriteLine("Valor inválido, insira um ano entre 1960 e 2024");
                }
                else
                {
                    ano = value;
                }
            }

        }
        public int QuantidadePortas { get; set; }

        public int Velocidade {  get; set; }

        public string DescricaoDetalhada =>
            $"Fabricante {this.Fabricante}, modelo {this.Modelo}, ano do Carro {this.Ano}";



        public void ExibirInformacoes()
        {
            Console.WriteLine($"Informações do carro: {this.Fabricante} {this.Modelo} {this.QuantidadePortas}");
        }

        public void Acelerar()
        {
            Console.WriteLine("Acelerando...");
            if (Velocidade < 100)
            {
                Velocidade += 5;
            }
        }

        public void Frear()
        {
            Console.WriteLine("Freando...");
            if (Velocidade > 0)
            {
                Velocidade -= 5;
            }
        }

        public void Buzinar()
        {
            Console.WriteLine("Bi Bi");
            Console.WriteLine("teste");
        }

    }
}
