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

        stringBuilder.AppendLine($"T�tulo: {Titulo}");
        stringBuilder.AppendLine($"Pre�o: {Preco.ToString("C2")}");
        stringBuilder.AppendLine($"ISBN: {Isbn}");
        stringBuilder.AppendLine($"Nome do autor: {Autor.Nome}");
        stringBuilder.AppendLine($"G�nero: {Genero}");
        stringBuilder.AppendLine("Tipo do livro: Virtual");

        return stringBuilder.ToString();
    }
}