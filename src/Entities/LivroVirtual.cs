using Enum.Genero;
using System.Text;
public class LivroVirtual : Livros
{
    public LivroVirtual()
    {

    }

    public LivroVirtual(string titulo, double preco,
        string isbn, EGenero genero, string nomeAutor)
    
    : base (titulo, preco, isbn, genero, nomeAutor)
    {

    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.AppendLine($"Título: {Titulo}");
        stringBuilder.AppendLine($"Preço: {Preco.ToString("C2")}");
        stringBuilder.AppendLine($"ISBN: {Isbn}");
        stringBuilder.AppendLine($"Nome do autor: {Autor.Nome}");
        stringBuilder.AppendLine($"Gênero: {Genero}");
        stringBuilder.AppendLine("Tipo do livro: Virtual");

        return stringBuilder.ToString();
    }
}