// ./Program.cs

// Usei Chat-GPT por preguiça - Promp no final do ./Program.cs

// Criando objetos para cada classe
VooRegular vooRegular = new VooRegular();
VooUpgrade vooUpgrade = new VooUpgrade();
VooGrupos vooGrupos = new VooGrupos(3); // Por exemplo, vamos criar um voo para 3 passageiros

// Atribuindo valores aos objetos
vooRegular.ReservarVoo("A1");
vooUpgrade.ReservarVoo("B2");

string[] assentosGrupo = {"C3", "C4", "C5"};
vooGrupos.ReservarVoo(assentosGrupo);

// Exibindo os valores na tela
Console.WriteLine("Status da Reserva - Voo Regular: " + vooRegular.StatusReserva());
Console.WriteLine("Assento - Voo Regular: " + vooRegular.Assento);

Console.WriteLine("Status da Reserva - Voo Upgrade: " + vooUpgrade.StatusReserva());
Console.WriteLine("Assento - Voo Upgrade: " + vooUpgrade.Assento);

Console.WriteLine("Status da Reserva - Voo para Grupos: " + vooGrupos.StatusReserva());
Console.Write("Assentos - Voo para Grupos: ");
foreach (var assento in vooGrupos.Assento)
{
    Console.Write(assento + " ");
}
Console.WriteLine();

// public interface IReserva{
//     void ReservarVoo(string sAssento);
//     void CancelarVoo();
//     bool StatusReserva();
// }
// public class VooRegular : IReserva{
//     public bool Status{set;get;}
//     public string Assento{set;get;}

//     public void ReservarVoo(string sAssento){
//         this.Assento = sAssento;
//         this.Status = true;
//     }
//     public void CancelarVoo()
//     {
//         this.Assento = "";
//         this.Status = false;
//     }

//     public bool StatusReserva()
//     {
//         return this.Status;
//     }
// }
// public class VooUpgrade{
//     public bool Status{set;get;}
//     public string Assento{set;get;}

//     public void ReservarVoo(string sAssento){
//         this.Assento = sAssento;
//         this.Status = true;
//     }
//     public void CancelarVoo()
//     {
//         this.Assento = "";
//         this.Status = false;
//     }

//     public bool StatusReserva()
//     {
//         return this.Status;
//     }
// }
// public class VooGrupos{
//     public bool Status{set;get;}
//     public int QntPassageiros{set;get;}
//     public string[] Assento{set;get;}

//     // Chat-GPT explicou como inicializar o array - Prompt no final do ./VooGrupos.cs
//     public VooGrupos(int sQntPassageiros){
//         QntPassageiros = sQntPassageiros;
//         this.Assento = new string[QntPassageiros];
//     }
//     public void ReservarVoo(string[] sAssento){
//         for(int i = 0; i < QntPassageiros; i++) Assento[i] = sAssento[i];
//         this.Status = true;
//     }
//     public void CancelarVoo()
//     {
//         for(int i = 0; i < QntPassageiros; i++){
//             Assento[i] = "";
//             this.Status = false;
//         }
//     }

//     public bool StatusReserva()
//     {
//         return this.Status;
//     }
// }
// Crie 1 objeto para cada classe em C#.
// Atribua valores e mostre-os na tela com Console.WriteLine();