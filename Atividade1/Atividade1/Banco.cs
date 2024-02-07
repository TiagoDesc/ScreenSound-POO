using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal class Banco
    {
        public int numeroIndicador = 1010;
        public string titular = "Tiago";
        public double saldo = 700;
        public double senha = 1234;

        public void ExibirInformacoes()
        {
            Console.WriteLine("\nInformações Gerais: ");
            Console.WriteLine($"Nome do titular: {titular}");
            Console.WriteLine($"Saldo da conta: {saldo}");
            Console.WriteLine($"Senha da conta: {senha}");
        }

    }
}
