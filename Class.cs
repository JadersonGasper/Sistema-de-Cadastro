using System.Text;

class Produto
{
    private string Nome { get; set; } // encapsulamento com métodos acessores

    public double Preco { get; set; }

    public int Estoque { get; private set; }

    public Produto()
    {
        this.Estoque = 0;
    }
    public Produto(string nome, double preco)
    {
        this.Nome = nome; //necessário o this por conta do nome do parâmetro
        this.Preco = preco; //necessário o this por conta do nome do parâmetro
        this.Estoque = 0;
    }

    public int Vender(int qtde)
    {
        if (this.Estoque - qtde >= 0)
        {
            this.Estoque -= qtde;
        }
        return this.Estoque;
    }
    public int Comprar(int qtde)
    {
        this.Estoque += qtde;
        return this.Estoque;
    }

    public string ObterTexto()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"\nNome: {this.Nome}\n");
        sb.Append($"Preço: {this.Preco}\n");
        sb.Append($"Estoque: {this.Estoque}\n");
        return sb.ToString();
    }
}