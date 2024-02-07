using Atividade1;

Banco conta = new Banco();

Console.WriteLine($"Titular: {conta.titular}.");
Console.WriteLine($"Saldo: R$ {conta.saldo}.");
conta.ExibirInformacoes();