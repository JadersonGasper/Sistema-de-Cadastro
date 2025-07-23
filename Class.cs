using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

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
public class Produto
{
    public int id;
    public string nome;
    public string preco;
    public double quantidade;
}

class Produto
{
    private string nome;

    public string Nome
    {
        get
        {
            return nome;
        }
    }
}

using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Classes, Objetos e Escopos de Visibilidade");

        Produto p1 = new Produto();
        p1.Nome = "Banana";

        Console.WriteLine(p1.Nome);
    }
}