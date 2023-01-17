class Busca
{
    public bool TemNaLista(List<Livros> lista, string titulo)
    {
        foreach(var livro in lista)
        {
            if(string.Equals(livro.Titulo, titulo,StringComparison.OrdinalIgnoreCase))
                return true;
        }

        return false;
    }
}