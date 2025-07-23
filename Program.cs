using System;
using System.Collections.Generic;
class MainClass
{
    private static List<Produto> produtos = new List<Produto>();
    public static void Main(string[] args)
    {
        string comandoEscolhido = "";

        do
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Cadastrar produto");
            Console.WriteLine("2- Listar produtos");
            Console.WriteLine("S - Sair");


            Console.Write("Opção desejada: ");
            comandoEscolhido = Console.ReadKey().KeyChar.ToString().ToUpper();
            // espera o usuário press. a tecla; pega o caractere da tecla; converte para string; ....

            switch (comandoEscolhido)
            {
                case "1":
                    Console.Write("\nNome do produto: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preço do produto: ");
                    string preco = Console.ReadLine();
                    Produto novoProduto = new Produto(nome, Convert.ToDouble(preco)); // cria um novo obj. Cada produto cadastrado é um novo obj.
                    produtos.Add(novoProduto);
                    Console.WriteLine("Produto adicionado com sucesso!");
                    break;
                case "2":
                    if (produtos.Count > 0)
                    {
                        Console.WriteLine("\nListagem de Produtos");
                        foreach (Produto p in produtos)
                        {
                            Console.WriteLine(p.ObterTexto());
                        }
                        Console.Write("Pressione qualquer tecla para prosseguir...");
                        Console.ReadKey();
                    }
                    else
                        Console.WriteLine("\nNão há produtos cadastrados.");
                    break;
                case "S":
                    Console.WriteLine("\nObrigado por usar o programa.");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida! Tente novamente.");
                    break;
            }
        } while (comandoEscolhido != "S");
    }
}