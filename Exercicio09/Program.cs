// ./Program.cs

// Usei Chat-GPT por preguiça - Promp no final do ./Program.cs

// Criando objetos para cada classe
Conta conta = new Conta();
Cartao cartao = new Cartao();
Boleto boleto = new Boleto();
Transferencia transferencia = new Transferencia();

// Atribuindo valores
conta.Saldo = 3000;

cartao.Status = false;
cartao.Numero = "1234 5678 9012 3456";
cartao.DataValidade = "12/25";

boleto.Status = false;
boleto.CodigoBoleto = "123456789012345678901234567890123456789012";

transferencia.Status = false;
transferencia.Agencia = "1234";
transferencia.ContaDestino = "5678";

// Exibindo valores na tela
Console.WriteLine("Dados da Conta:");
Console.WriteLine($"Saldo: R${conta.Saldo}");
Console.WriteLine($"Status do Pagamento: {conta.StatusPagamento()}");
Console.WriteLine();

Console.WriteLine("Dados do Cartão:");
Console.WriteLine($"Saldo: R${cartao.Saldo}");
cartao.RealizarPagamento(500);
Console.WriteLine($"Status do Pagamento: {cartao.StatusPagamento()}");
Console.WriteLine($"Número do Cartão: {cartao.Numero}");
Console.WriteLine($"Data de Validade: {cartao.DataValidade}");
Console.WriteLine();

Console.WriteLine("Dados do Boleto:");
Console.WriteLine($"Saldo: R${boleto.Saldo}");
boleto.RealizarPagamento(500);
Console.WriteLine($"Status do Pagamento: {boleto.StatusPagamento()}");
Console.WriteLine($"Código do Boleto: {boleto.CodigoBoleto}");
Console.WriteLine();

Console.WriteLine("Dados da Transferência:");
Console.WriteLine($"Saldo: R${transferencia.Saldo}");
transferencia.RealizarPagamento(500);
Console.WriteLine($"Status do Pagamento: {transferencia.StatusPagamento()}");
Console.WriteLine($"Agência: {transferencia.Agencia}");
Console.WriteLine($"Conta de Destino: {transferencia.ContaDestino}");

// public class Conta : IMetodoPagamento{
//     public double Saldo{set;get;}
//     public bool Status{set;get;}

//     public void RealizarPagamento(double sValor){
//         this.Saldo -= sValor;
//         this.Status = true;
//     }
//     public bool StatusPagamento(){
//         return this.Status;
//     }
// }
// public class Cartao : Conta{
//     public string Numero{set;get;}
//     public string DataValidade{set;get;}
// }
// public class Boleto : Conta{
//     public string CodigoBoleto{set;get;}
// }
// public class Transferencia : Conta{
//     public string Agencia{set;get;}
//     public string ContaDestino{set;get;} 
// }

// Crie 1 objeto para cada classe em C#.
// Atribua valores e mostre-os na tela com Console.WriteLine();