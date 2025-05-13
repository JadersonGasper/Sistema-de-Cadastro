using System;
using System.Collections.Generic;

class ControleDeEstoque
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a opção desejada entre: cadastrar, listar, atualizar, remover ou sair");
        string opcaoEscolhida = Console.ReadLine();

        

        while (opcaoEscolhida != "sair") {
            switch (opcaoEscolhida)
            {
                case "cadastrar":
                    string produto = Console.ReadLine();
                    List<string> produto = new List<string>();
                    produto.Add(produto);

                    break;

                case "listar":

                    foreach(int item in opcaoEscolhida)
                    {
                        Console.WriteLine(item.ToString());
                    }

                    break;

                case "atualizar":

                    break;

                case "remover":

                    break;
            }
        }
    }
}
class Produto
{
    public int id;
    public string nome;
    public string preco;
    public double quantidade;
}