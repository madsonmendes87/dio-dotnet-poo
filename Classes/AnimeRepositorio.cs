using System;
using System.Collections.Generic;
using DIO.Animes.Interfaces;

namespace DIO.Animes
{
	public class AnimeRepositorio : IRepositorio<Anime>
	{
        private List<Anime> listaAnime = new List<Anime>();
		public void Atualiza(int id, Anime objeto)
		{
			listaAnime[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaAnime[id].Excluir();
		}

		public void Insere(Anime objeto)
		{
			listaAnime.Add(objeto);
		}

		public List<Anime> Lista()
		{
			return listaAnime;
		}

		public int ProximoId()
		{
			return listaAnime.Count;
		}

		public Anime RetornaPorId(int id)
		{
			return listaAnime[id];
		}
	}
}