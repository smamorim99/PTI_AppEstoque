class Tela
{
    public int Menu()
    {
        Console.WriteLine(@"
[1] Novo produto
[2] Produtos em estoque
[3] Remover produto
[4] Inserir produto no estoque
[5] Saida Estoque
[6] Sair");

        int menu = Convert.ToInt32(Console.ReadLine());

        return menu;
    }
//pede para que o usuario passe as informações do produto
    public Produto PedirProduto()
    {
        Produto produto = new Produto();
        Console.WriteLine("Informe o tipo de produto");
        produto.Tipo = Console.ReadLine();

        Console.WriteLine("Informe o tamanho (P, M, G ou GG)");
        produto.Tam = Console.ReadLine();

        Console.WriteLine("Informe o preço");
        produto.Preco = Convert.ToDouble(Console.ReadLine());

        produto.Qtd = 0;
        
        return produto;
    }
    public string PedirTipo()
    {
        Console.WriteLine("Informe o tipo de produto:");
        return Console.ReadLine();
    }

    public string PedirTam()
    {
        Console.WriteLine("Informe o tamanho");
        return Console.ReadLine();
    }
    public int PedirQtd()
    {
        Console.WriteLine("Informe a quantidade de produtos:");
        return Convert.ToInt32(Console.ReadLine());
    }
    public int Saidas()
    {
        Console.WriteLine("Informe a quantidade de saidas:");
        return Convert.ToInt32(Console.ReadLine());
    }

    

}