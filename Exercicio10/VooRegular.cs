// ./VooRegular.cs

public class VooRegular : IReserva{
    public bool Status{set;get;}
    public string Assento{set;get;}

    public void ReservarVoo(string sAssento){
        this.Assento = sAssento;
        this.Status = true;
    }
    public void CancelarVoo()
    {
        this.Assento = "";
        this.Status = false;
    }

    public bool StatusReserva()
    {
        return this.Status;
    }
}