using Atividade1;

Banco conta = new Banco();

Console.WriteLine($"Titular: {conta.IdConta}.");
Console.WriteLine($"Saldo: R$ {conta.Saldo}.");
conta.ExibirInformacoes();