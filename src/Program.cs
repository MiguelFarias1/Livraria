using Services;

class Program
{
    static void Main(string[] args)
    {
        Cadastro.CadastrarLivroFisico();

        Imprimir.ImprimirTudo(Cadastro.estoque);
    }
}