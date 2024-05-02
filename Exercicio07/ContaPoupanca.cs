// ./ContaPoupanca.cs

public class ContaPoupanca : Conta{
    public double TaxaPoupanca{set;get;}

    public void DeduzirTaxa(){
        this.Saldo -= Saldo * TaxaPoupanca;
    }
    public double VerificarTaxa(){
        return this.TaxaPoupanca;
    }
}