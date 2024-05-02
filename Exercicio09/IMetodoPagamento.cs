// ./IMetodoPagamento.cs

public interface IMetodoPagamento{
    public void RealizarPagamento(double sValor);
    public bool StatusPagamento();
}