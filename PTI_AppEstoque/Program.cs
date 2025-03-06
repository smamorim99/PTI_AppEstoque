class Program
{
    static void Main (string[] args)
    {
        Tela tela = new Tela();
        Estoque estoque = new Estoque();
        
        int qtdSaida;
        int qtd;
        string tipo;
        string tam;

        Console.WriteLine("CONTROLE DE ESTOQUE LOJA DE ROUPAS");
//utiliza a estrutura de controle switch-case para acessar os itens do menu
        int menu = tela.Menu();
        while (menu != 0)
        {
            switch(menu)
            {
            case 1:
            Console.WriteLine("Registrar um novo produto");
            Produto novoProduto = tela.PedirProduto();
            estoque.AdcProduto(novoProduto);
            break;
            
            case 2:
            Console.WriteLine("Peças em estoque:");
            estoque.Listar();
            break;

            case 3:
            Console.WriteLine("Remover produto do estoque");
            Console.WriteLine("informe o produto que deseja remover");
            tipo = tela.PedirTipo();
            tam = tela.PedirTam();
            estoque.RemoverProduto(tipo, tam);
            break;
            
            case 4:
            Console.WriteLine("Entrada Estoque");
            Console.WriteLine("Adicionar produto ao estoque:");
           
            tipo = tela.PedirTipo();
            tam = tela.PedirTam();
            qtd = tela.PedirQtd();
            estoque.EntradaEstoque(tipo, tam, qtd);
            break;

            case 5:
            Console.WriteLine("Saida estoque");
            tipo = tela.PedirTipo();
            tam = tela.PedirTam();
            qtdSaida = tela.Saidas();
            estoque.SaidaEstoque(tipo, tam, qtdSaida);
            break;

            default:
            Console.WriteLine("Sair");
            Console.WriteLine("Para sair pressione X");
            Console.ReadKey();
            break;   
            }
            menu = tela.Menu();
        }    
    }
}