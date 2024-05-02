// ./Produto.cs

public class Produto{
    public string Nome {set;get;}
    public double Preco{set;get;}
    public int QuantidadeEmEstoque{set;get;}

    public void AdicionarUnidade(int sValor){
        this.QuantidadeEmEstoque += sValor;
    }
    public void RemoverUnidade(int sValor){
        this.QuantidadeEmEstoque -= sValor;
    }
    public double ValorTotal(){
        return this.Preco * this.QuantidadeEmEstoque;
    }
}