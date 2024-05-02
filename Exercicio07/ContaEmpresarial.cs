// ./ContaEmpresarial.cs

public class ContaEmpresarial : Conta{
    public double SaldoMin{set;get;}

    public double VerificarSaldoMin(){
        return this.SaldoMin;
    }
    public bool BoolSaldoMin(){
        if(Saldo >= SaldoMin) return true;
        else{
            return false;
        }
    }
}