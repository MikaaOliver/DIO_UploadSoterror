using System;
using System.collections.generic;
using dio_soterror.interfaces;

namespace dio_soterror
{
    public class FilmeRepositorio : IRepositorio<Filme>
    {
        private List<Filme> listaFilme = new List<Filme>();

        public void Atualiza (int id, Filme objeto)
        {
            listaFilme[id] = objeto;

        }

        public void Exclui (int id)
        {
            listaFilme[id].Excluir();
            
        }

        public void Insere (Filme entidade)
        {
            listaFilme.Add(objeto);
            
        }

        public List<Filme> Lista()
        {
            return listaFilme
            
        }

        public int ProximoId ()
        {
            return listaFilme.count;
            
        }

        public Filme RetornaPorId(int id)
        {
           return listaFilme[id];
            
        }
        
    }
}