// ./ContaCorrente.cs

public class ContaCorrente : Conta{
    public double TaxaCorrente{set;get;}

    public void DeduzirTaxa(){
        this.Saldo -= Saldo * TaxaCorrente;
    }
    public double VerificarTaxa(){
        return this.TaxaCorrente;
    }
}