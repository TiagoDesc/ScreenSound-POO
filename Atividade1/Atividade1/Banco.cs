using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal class Banco { 
    
        public int NumeroIndicador { get; set; }
        public string IdConta {  get; set; }
        public double Saldo {  get; set; } 
        public double Senha {  get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine("\nInformações Gerais: ");
            Console.WriteLine($"Nome do titular: {IdConta}");
            Console.WriteLine($"Saldo da conta: {Saldo}");
            Console.WriteLine($"Senha da conta: {Senha}");
        }

    }
}
