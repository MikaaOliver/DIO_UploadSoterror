namespace dio_soterror
{
    public class Filme: entidadeBase

    { 
        //Atributos

        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string  Descricao { get; set; }

        private int Ano { get; set;}

        private bool Excluido {get; set;}

        // Metodos

        public filme (int id, Genero, string Titulo, string Descricao, int Ano)

        {  this. id = id;
           this.Genero = Genero;
           this.Titulo = Titulo
           this.Descricao = Descricao;
           this.Ano = Ano;
           this.Excluido = false;
        }

        public override string ToString ()
       {
         // fazer retorno

         string retorno = "";
         retorno += "Gênero: " + this.Genero + Environment.NewLine;
         retorno += "Titulo: " + this.Titulo + Environment.NewLine;
         retorno += "Descrição: " + this.Descricao + Environment.NewLine;
         retorno += "Ano de Lançamento: " + this.Ano;
         return retorno;

       }  

       public string retornaTitulo()

       {
           return this.Titulo;

       }

       public int retornaId ()
       {
           return this.id;
       }
       public void Exclui(int id)
       {
           this.Excluido = true;
       }

        
    }
}