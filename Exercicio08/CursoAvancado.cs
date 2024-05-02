// ./CursoAvancado.cs

public class CursoAvancado : CursoIdiomas{
    public double Nota01{set;get;}
    public double Nota02{set;get;}
    public double Nota03{set;get;}

    public double CalcularMedia(){
        return (this.Nota01 + this.Nota02 + this.Nota03) / 3;
    }
    public bool VerificarAptidao(double sMedia){
        if(sMedia >= 7) return true;
        else{
            return false;
        }
    }

    // Não entendi mt bem a parte de gerar certificado
    public string GerarCertificado(bool sAptidao){
        string Certificado;
        if(sAptidao) {
            Certificado = "Gerando certificado para o curso de " + this.Idioma;
            return Certificado;
        }
        else{
            Certificado = "Não foi possível gerar certificado.";
            return Certificado;
        }
    }
}