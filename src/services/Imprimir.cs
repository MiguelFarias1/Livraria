class Imprimir
{
    public static void ImprimirTudo(List<Livros> list)
    {
        foreach(var livro in list)
        {
            Console.WriteLine(livro);
        }
    }
}