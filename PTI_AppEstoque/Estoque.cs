class Estoque
{
    Produto[] produtos = new Produto[0];

//Essa função cria um novo array uma posição maior, copiando os itens disponiveis no array anterior.
    public void AdcProduto(Produto produto)
    {
        Produto[] novo = new Produto[produtos.Length + 1];

        for (int pos = 0; pos < produtos.Length; pos++)
        {
            novo[pos] = produtos[pos];
        }
        novo[produtos.Length] = produto;
        produtos = novo;
    }
//A função de remover produto funciona da mesma maneira da função acima, com a diferença de que após identificar se um determinado produto existe no array, ele copia todos os itens que são de tipo e tamanho diferente para um novo array, com uma posição a menos
    public void RemoverProduto(string tipo, string tam)
    {
        bool encontrado = false;
        Produto[] novo = new Produto[produtos.Length -1];
        int pos = 0;

        for (int i = 0; i < produtos.Length; i++)
        {
            if(produtos[i].Tipo == tipo && produtos[i].Tam == tam && !encontrado)
            {
                encontrado = true;
                continue;
            }
            if (pos < novo.Length)
            {
                novo[pos] = produtos[i];
                pos++;
            } 
        }
        if(encontrado)
        {
            produtos = novo;
            Console.WriteLine("Produto Removido!");
        }
        else
        {
            Console.WriteLine("Produto não encotrado!");
        }
    }
//lista todos os itens do array atraves de um loop foreach
    public void Listar()
    {
        foreach (Produto item in produtos)
        {
            Console.WriteLine($"Produto:{item.Tipo} - TAM:{item.Tam} - Preço: {item.Preco}R$ - Quantidade em estoque: {item.Qtd} ");
        }
    }
//Registra a quantidade de itens disponiveis em estoque
    public void EntradaEstoque (String tipo, String tam, int qtd)
    {
        Produto produto = null;
        foreach (Produto item in produtos)
        {
            if (item.Tam == tam && item.Tipo == tipo)
            {
                produto = item;
                break;
            }
        }
        if (produto != null)
        {
            produto.Qtd += qtd;
        }
    }
//Procura o produto pedido no estoque, e se encontrado pede para que o usuario infome o numero de saidas, e assim atualiza a quantidade de produtos no estoque
    public void SaidaEstoque(String tipo, String tam, int qtdSaida)
    {
        Produto produto = null;
        foreach (Produto item in produtos)
        {
            if(item.Tam == tam && item.Tipo == tipo)
            {
                produto = item;
                break;
            }
        }
        if (produto == null)
        {
            Console.WriteLine("Produto fora de estoque");
            return;
        }
        if (qtdSaida > 0 && qtdSaida <= produto.Qtd)
        {
            produto.Qtd -= qtdSaida;
            Console.WriteLine("Quantidade de produtos atualizada com sucesso");
        }
        else
        {
            Console.WriteLine("Quantidade invalida ou insuficiente");
        }

    }
}