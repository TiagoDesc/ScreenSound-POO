Musica musica1 = new Musica();
musica1.Nome = "Train Wreck";
musica1.Artista = "James Arthur";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);

Musica musica2 = new Musica();
musica2.Nome = "Japanese Denim";
musica2.Artista = "Daniel Caesar";
musica2.Duracao = 300;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica1.ExibirNomeArtista();
