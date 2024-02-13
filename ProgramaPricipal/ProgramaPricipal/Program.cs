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

// new debug 

Episodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");

Episodio ep2 = new(2, "Tecnicas de aprendizado", 67);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Flavia");

Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();
