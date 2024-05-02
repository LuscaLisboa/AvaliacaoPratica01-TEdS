// ./Filme.cs

public class Filme{
    public string Titulo{set;get;}
    public string Genero{set;get;}
    public double Duracao{set;get;}
    public bool Disponivel{set;get;}

    // Pensando que há apenas 1 quantidade
    public void RegistrarLocacao(){ // Se há filme, filme é alugado e não há mais filme.
        if(this.Disponivel == true) this.Disponivel = false;
    }
    public void RegistrarDevolucao(){ // Mesma coisa só q ao contrário
        if(this.Disponivel == false) this.Disponivel = true;
    }
    public bool VerificarDisponibilidade(){ // Verifica bool apenas
        return this.Disponivel;
    }
}