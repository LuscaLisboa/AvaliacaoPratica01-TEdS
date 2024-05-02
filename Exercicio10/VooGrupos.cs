// ./VooGrupos.cs

public class VooGrupos{
    public bool Status{set;get;}
    public int QntPassageiros{set;get;}
    public string[] Assento{set;get;}

    // Chat-GPT explicou como inicializar o array - Prompt no final do ./VooGrupos.cs
    public VooGrupos(int sQntPassageiros){
        QntPassageiros = sQntPassageiros;
        this.Assento = new string[QntPassageiros];
    }
    public void ReservarVoo(string[] sAssento){
        for(int i = 0; i < QntPassageiros; i++) Assento[i] = sAssento[i];
        this.Status = true;
    }
    public void CancelarVoo()
    {
        for(int i = 0; i < QntPassageiros; i++){
            Assento[i] = "";
            this.Status = false;
        }
    }

    public bool StatusReserva()
    {
        return this.Status;
    }
}

// public int QntPassageiros{set;get;}
// public string Assento{set;get;}
// eu quero que o Assento seja um array do tamanho da QntPassageiros, tem como?