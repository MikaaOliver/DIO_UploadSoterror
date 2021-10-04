using System;

namespace dio_soterror
{
    class Program
    {   
        static FilmeRepositorio repositorio = new FilmeRepositorio();
        static void Main(string[] args)

        {
           string opcaoUsuario =ObterOpcaoUsuario();

           wrile (opcaoUsuario.ToUpper() != "X")
           {
               switch (opcaoUsuario)
               {
                   case "1";
                       ListarFilmes();
                       break;
                   case "2"
                       InserirFilme();
                       break
                    case "3"
                        AtualizarFilme();
                        break
                    case "4"
                        ExcluirFilme();
                        break
                    case "5"
                        VisualizarSerie();
                        break
                    Case "C"
                        console.clear();
                        break

                    default:
                        throw new ArgumentOutOfrangeException();                     
               }
               opcaoUsuario = ObterOpcaoUsuario();
           }

           Console.WrileLine ("Agradecemos por escolher a Só Terror");
           console.ReadLine(); 
        
        }

        private static void ListarFilmes()
        {
            console.WrileLine("Listar Filmes");

            var lista = repositorio.Lista();

            if (lista.count == 0)
            {
                console.WrileLine("Nenhum Filme Cadastrado.")
                return;
            }

            foreach (var serie in lista)
            {
                console.WrileLine("#ID {0}:  .  {1}". serioe.retornaId(), serie.retornaTitulo());
            }
        }   

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir novo Filme");
            foreach (int i in enum.GetValues(typeof(genero)))
            
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do Filme: ");
            string entradaTitulo = console.ReadLine();

            Console.Write("Digite o ano do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme: ");
            string entradaDescricao = console.ReadLine();

            Filme novoFilme = new Filme(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            repositorio.Insere(novoFilme);


        }


        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine ("Só Terror pra te arrepiar nas noitadas!");
            Console.WriteLine ("E aí, vai jogar a pipoca de susto com qual hoje?");

            Console.WriteLine ("1 Listar Filmes");
            Console.WriteLine ("2 Inserir novo Filme");
            Console.WriteLine ("3 Atualizar Filme");
            Console.WriteLine ("4 Excluir Filme");
            Console.WriteLine ("5 Visualizar Filme");
            Console.WriteLine ("C limpar Tela");
            Console.WriteLine ("x Sair");

            string opcaoUsuario = Console.readLine().ToUpper();
            console.WriteLine();
            return opcaoUsuario;


        }
    }
}
