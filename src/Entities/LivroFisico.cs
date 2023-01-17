using Enum.TipoCapa;
using Enum.Genero;
using System.Text;
using System.Globalization;
public class LivroFisico : Livros
{
    public ETipoCapa TipoCapa { get; set; }
    public int Quantidade { get; set; }
    public LivroFisico()
    {}

    public LivroFisico(string titulo, double preco, string isbn, 
    EGenero genero, string nomeAutor, ETipoCapa tipoCapa, int quantidade)
                            :base(titulo, preco, isbn, genero, nomeAutor)
    {
        TipoCapa = tipoCapa;
        Quantidade = quantidade;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.AppendLine($"Título: {Titulo}");
        stringBuilder.AppendLine($"Preço: {Preco.ToString("C2")}");
        stringBuilder.AppendLine($"ISBN: {Isbn}");
        stringBuilder.AppendLine("Tipo do livro: Físico");
        stringBuilder.AppendLine($"Nome do autor: {Autor.Nome}");
        stringBuilder.AppendLine($"Gênero: {Genero}");
        stringBuilder.AppendLine($"Tipo de capa: {TipoCapa}");
        stringBuilder.AppendLine($"Quantidade em estoque: {Quantidade}");
        stringBuilder.AppendLine($"Valor total em estoque: {(Quantidade * Preco).ToString("C2")}");

        return stringBuilder.ToString();
    }
}