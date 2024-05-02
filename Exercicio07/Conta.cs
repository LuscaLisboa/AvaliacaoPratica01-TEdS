// ./Conta.cs

public class Conta{
    public string Titular{set;get;}
    public double Saldo{get;set;}

    public void Depositar(double sValor){
        this.Saldo += sValor;
    }
    public void Sacar(double sValor){
        this.Saldo -= sValor;
    }
    public double VerificarSaldo(){
        return this.Saldo;
    }
}