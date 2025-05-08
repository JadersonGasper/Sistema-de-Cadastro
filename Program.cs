using System;
using System.Collections.Generic;

class ControleDeEstoque
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a opção desejada entre: cadastrar, listar, atualizar, remover ou sair");
        string opcaoEscolhida = Console.ReadLine();

        string produto = Console.ReadLine();

        while (opcaoEscolhida != "sair") {
            switch (opcaoEscolhida)
            {
                case "cadastrar":
                
                    List<string> produtos = new List<string>();
                    produtos.Insert(1, produto);

                    break;

                case "listar":

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

// ---------------------------------------------------------------------------

/*using System;

class SerHumano
{
    public string Nome;
    public int Idade;

    public SerHumano(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void TocarViolao()
    {
        Console.WriteLine($"{Nome} está tocando violão.");
    }
}

class Program
{
    static void Main()
    {
        // Criando um objeto da classe SerHumano
        SerHumano marcos = new SerHumano("Marcos", 30);

        // Acessando um atributo
        Console.WriteLine(marcos.Idade);  // Saída: 30

        // Chamando um método
        marcos.TocarViolao();  // Saída: Marcos está tocando violão.
    }
}*/

// ---------------------------------------------------------------------------

/*using System;

class Testes
{
    static void Main(string[] args)
    {
        string diaDaSemana = "terça";

        if (diaDaSemana == "terça")
        {
            Console.WriteLine("Hoje é terça-feira");
        }else if (diaDaSemana == "quarta")
        {
            Console.WriteLine("Hoje é quarta-feira");
        }
        else
        {
            Console.WriteLine("Hoje é domingo");
        }
    }
}*/