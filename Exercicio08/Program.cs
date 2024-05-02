// ./Program.cs

// Usei Chat-GPT por preguiça - Promp no final do ./Program.cs
Curso curso = new Curso();
CursoIdiomas cursoIdiomas = new CursoIdiomas();
CursoAvancado cursoAvancado = new CursoAvancado();

// Atribuindo valores
curso.Nome = "Inglês Básico";
curso.Duracao = 6;

cursoIdiomas.Nome = "Francês Intermediário";
cursoIdiomas.Duracao = 9;
cursoIdiomas.Idioma = "Francês";

cursoAvancado.Nome = "Espanhol Avançado";
cursoAvancado.Duracao = 12;
cursoAvancado.Idioma = "Espanhol";
cursoAvancado.Nota01 = 8.5;
cursoAvancado.Nota02 = 7.8;
cursoAvancado.Nota03 = 9.2;

// Exibindo valores na tela
Console.WriteLine("Dados do Curso:");
Console.WriteLine($"Nome: {curso.Nome}");
Console.WriteLine($"Duração: {curso.Duracao} meses");
Console.WriteLine();

Console.WriteLine("Dados do Curso de Idiomas:");
Console.WriteLine($"Nome: {cursoIdiomas.Nome}");
Console.WriteLine($"Duração: {cursoIdiomas.Duracao} meses");
Console.WriteLine($"Idioma: {cursoIdiomas.Idioma}");
Console.WriteLine();

Console.WriteLine("Dados do Curso Avançado:");
Console.WriteLine($"Nome: {cursoAvancado.Nome}");
Console.WriteLine($"Duração: {cursoAvancado.Duracao} meses");
Console.WriteLine($"Idioma: {cursoAvancado.Idioma}");
double media = cursoAvancado.CalcularMedia();
Console.WriteLine($"Média de Notas: {media}");
bool apto = cursoAvancado.VerificarAptidao(media);
Console.WriteLine($"Aptidão: {apto}");
Console.WriteLine($"Certificado: {cursoAvancado.GerarCertificado(apto)}");

// public class Curso{
//     public string Nome{set;get;}
//     public int Duracao{set;get;}
// }
// public class CursoIdiomas : Curso{
//     public string Idioma{set;get;}
// }
// public class CursoAvancado : CursoIdiomas{
//     public double Nota01{set;get;}
//     public double Nota02{set;get;}
//     public double Nota03{set;get;}

//     public double CalcularMedia(){
//         return (this.Nota01 + this.Nota02 + this.Nota03) / 3;
//     }
//     public bool VerificarAptidao(double sMedia){
//         if(sMedia >= 7) return true;
//         else{
//             return false;
//         }
//     }

//     // Não entendi mt bem a parte de gerar certificado
//     public string GerarCertificado(bool sAptidao){
//         string Certificado;
//         if(sAptidao) {
//             Certificado = "Gerando certificado para o curso de " + this.Idioma;
//             return Certificado;
//         }
//         else{
//             Certificado = "Não foi possível gerar certificado.";
//             return Certificado;
//         }
//     }
// }

// Crie 1 objeto para cada classe em C#.
// Atribua valores e mostre-os na tela com Console.WriteLine();