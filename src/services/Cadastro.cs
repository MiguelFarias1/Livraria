using Enum.TipoCapa;
using Enum.Genero;

namespace Services;

public class Cadastro
{
    public static List<Livros> estoque = new List<Livros>();

    public static void CadastrarLivroFisico()
    {
        try
        {
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Digite o título do livro !");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite o ISBN do livro !");
            string isbn = Console.ReadLine();

            Console.WriteLine("Digite o preço do livro !");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do Autor !");
            string nomeAutor = Console.ReadLine();

            Console.WriteLine("Digite 1 para tipo de capa dura 2 para flexível !");
            ETipoCapa tipoCapa = (ETipoCapa) int.Parse(Console.ReadLine());

            Console.WriteLine(@" 
            1 - AutoAjuda, 
            2 - Biografia, 
            3 - Comedia, 
            4 - HQ, 
            5 - Terror, 
            6 - Literatura");

            EGenero genero = (EGenero) int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de livros a ser cadastrada no estoque !");
            int quantidade = int.Parse(Console.ReadLine());

            estoque.Add(new LivroFisico(titulo,preco,isbn,genero,nomeAutor,tipoCapa,quantidade));
        }

        catch(IOException e)
        {
            Console.WriteLine($"Dados informados inválidos ! {e.Message}");
        }

        catch(Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }

    public static void CadastrarLivroVirtual()
    {
        try
        {
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Digite o título do livro !");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite o ISBN do livro !");
            string isbn = Console.ReadLine();

            Console.WriteLine("Digite o preço do livro !");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do Autor !");
            string nomeAutor = Console.ReadLine();

            Console.WriteLine(@"Digite 1 - AutoAjuda, 2 - Biografia, 
            3 - Comedia, 
            4 - HQ, 
            5 - Terror, 
            6 - Literatura");

            EGenero genero = (EGenero) int.Parse(Console.ReadLine());

            estoque.Add(new LivroVirtual(titulo,preco,isbn,genero,nomeAutor));
        }

        catch(IOException e)
        {
            Console.WriteLine($"Dados informados inválidos ! {e.Message}");
        }

        catch(Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }

}
