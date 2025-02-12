using System;

class Program
{
    static void Main()
    {
        // Criando um array para armazenar as informações das 40 mercadorias
        Mercadoria[] estoque = new Mercadoria[40];
        int opcao;
        int contador = 0;

        // Menu de opções
        do
        {
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine("1. Cadastrar mercadorias");
            Console.WriteLine("2. Exibir valor total em mercadorias da empresa");
            Console.WriteLine("3. Sair");
            Console.Write("OPÇÃO: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    // Cadastrar mercadorias
                    if (contador < 40)
                    {
                        Console.WriteLine("\nCadastro de mercadoria:");
                        Console.Write("Digite o nome da mercadoria: ");
                        string nome = Console.ReadLine();

                        Console.Write("Digite a quantidade em estoque: ");
                        int quantidade = int.Parse(Console.ReadLine());

                        Console.Write("Digite o preço unitário: ");
                        double preco = double.Parse(Console.ReadLine());

                        estoque[contador] = new Mercadoria(nome, quantidade, preco);
                        contador++;

                        Console.WriteLine("\nMercadoria cadastrada com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("\nEstoque cheio! Não é possível cadastrar mais mercadorias.");
                    }
                    break;

                case 2:
                    // Exibir valor total em mercadorias
                    double valorTotal = 0;
                    for (int i = 0; i < contador; i++)
                    {
                        valorTotal += estoque[i].Quantidade * estoque[i].PrecoUnitario;
                    }
                    Console.WriteLine($"\nValor total em mercadorias da empresa: R${valorTotal:F2}");
                    break;

                case 3:
                    Console.WriteLine("\nSaindo do sistema...");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida! Tente novamente.");
                    break;
            }

            // Pausa para o usuário ver o resultado
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        while (opcao != 3);
    }
}

// Classe para representar cada mercadoria
class Mercadoria
{
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public double PrecoUnitario { get; set; }

    public Mercadoria(string nome, int quantidade, double precoUnitario)
    {
        Nome = nome;
        Quantidade = quantidade;
        PrecoUnitario = precoUnitario;
    }
}
