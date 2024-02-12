Banda jamesArthur = new Banda();
jamesArthur.Nome = "James Arthur";

Album albumDoJamesArthur = new Album();
albumDoJamesArthur.Nome = "You";

Musica musica1 = new Musica(jamesArthur);
musica1.Nome = "Fall";
musica1.Duracao = 222;

Musica musica2 = new Musica(jamesArthur);
musica2.Nome = "Car's Outside";
musica2.Duracao = 248;

albumDoJamesArthur.AdicionarMusica(musica1);
albumDoJamesArthur.AdicionarMusica(musica2);


jamesArthur.AdicionarAlbum(albumDoJamesArthur);
jamesArthur.ExibirDiscografia();
albumDoJamesArthur.ExibirMusicasDoAlbum();