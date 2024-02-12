Banda jamesArthur = new Banda("James Arthur");

Album albumDoJamesArthur = new Album("You");

Musica musica1 = new Musica(jamesArthur, "Fall")
{
    Duracao = 222,
    Disponivel = true,
};

Musica musica2 = new Musica(jamesArthur, "Car's Outside")
{
    Duracao = 248,
    Disponivel = false,
};

albumDoJamesArthur.AdicionarMusica(musica1);
albumDoJamesArthur.AdicionarMusica(musica2);
jamesArthur.AdicionarAlbum(albumDoJamesArthur);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
jamesArthur.ExibirDiscografia();
albumDoJamesArthur.ExibirMusicasDoAlbum();