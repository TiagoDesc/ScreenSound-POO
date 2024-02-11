using System.Threading.Channels;

Titular t = new Titular();
Conta c = new Conta();

t.Nome = "Tiago";
t.Cpf = "386.927.462-53"; //Random CPF. Chill.
t.Endereco = "Rua do Lionel Messi.";

c.Titular = t;
c.Agencia = 1;
c.Saldo = 1000000.0;
c.Limite = 100000.0;

Console.WriteLine("Informações do titular: ");
Console.WriteLine($"Nome: { c.Titular.Nome}.");
Console.WriteLine($"CPF: {c.Titular.Cpf}.");
Console.WriteLine($"Endereço: {c.Titular.Endereco}.");