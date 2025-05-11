using System;

class Program
{
    static void Main(string[] args)        
    {

        /*for (int j=0; j < 11 ;  j++) {
            Console.WriteLine($"Iteração {j}");
        }*/

        int i = 10;
        do
        {
            i--;
            if (i == 5)
            {
                continue;
            }
            Console.WriteLine($"Iteração {i}.");
            
       } while (i > 0);
    }
}

/*using System;
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

// ---------------------------------------------------------------------------

/*using System;

class Program
{
    static void Main(string[] args)
    {

        for (int j = 0; j < 10; j++)
        {
            if (j == 5)
            {
                continue;
            }
            Console.WriteLine($"Iteração {j}.");
        }
    }
}
*/
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