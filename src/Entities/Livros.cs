using Enum.Genero;

public abstract class Livros
{
    public string Titulo { get; set; } = string.Empty;
    public double Preco { get;}
    public string Isbn { get; set; } = string.Empty;
    public EGenero Genero { get; set; }
    public Autor Autor { get; set; } = new Autor();


    public Livros()
    {}

    public Livros(string titulo, double preco, 
                    string isbn, EGenero genero, string nomeAutor)
     {
        Titulo = titulo;
        Preco = preco;
        Isbn = isbn;
        Genero = genero;
        Autor.Nome = nomeAutor;
     }
}