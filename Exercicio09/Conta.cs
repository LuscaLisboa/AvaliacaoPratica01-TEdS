// ./Conta.cs

public class Conta : IMetodoPagamento{
    public double Saldo{set;get;}
    public bool Status{set;get;}

    public void RealizarPagamento(double sValor){
        this.Saldo -= sValor;
        this.Status = true;
    }
    public bool StatusPagamento(){
        return this.Status;
    }
}