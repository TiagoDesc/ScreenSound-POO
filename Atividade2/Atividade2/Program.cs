using System.Threading.Channels;
Titular titular = new Titular("Lionel Messi", "000.000.000-00", "Rua do Bexiga");
Conta c = new Conta(titular, 1, 2222, 100000, 1000000);

Console.WriteLine(c.Informacoes);
Console.WriteLine(c.Agencia);
string info = c.ToString();
Console.WriteLine(info);