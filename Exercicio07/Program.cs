// ./Program.cs

// Usei Chat-GPT por preguiça - Promp no final do ./Program.cs

// Criando objetos para cada classe
Conta conta = new Conta();
ContaCorrente contaCorrente = new ContaCorrente();
ContaPoupanca contaPoupanca = new ContaPoupanca();
ContaEmpresarial contaEmpresarial = new ContaEmpresarial();

// Atribuindo valores
conta.Titular = "João";
conta.Saldo = 1000;

contaCorrente.Titular = "Maria";
contaCorrente.Saldo = 2000;
contaCorrente.TaxaCorrente = 0.1;

contaPoupanca.Titular = "Pedro";
contaPoupanca.Saldo = 3000;
contaPoupanca.TaxaPoupanca = 0.05;

contaEmpresarial.Titular = "Ana";
contaEmpresarial.Saldo = 5000;
contaEmpresarial.SaldoMin = 1000;

// Exibindo valores na tela
Console.WriteLine("Dados da Conta:");
Console.WriteLine($"Titular: {conta.Titular}");
Console.WriteLine($"Saldo: {conta.VerificarSaldo()}");

Console.WriteLine("\nDados da Conta Corrente:");
Console.WriteLine($"Titular: {contaCorrente.Titular}");
Console.WriteLine($"Saldo: {contaCorrente.VerificarSaldo()}");
Console.WriteLine($"Taxa Corrente: {contaCorrente.VerificarTaxa()}");

Console.WriteLine("\nDados da Conta Poupança:");
Console.WriteLine($"Titular: {contaPoupanca.Titular}");
Console.WriteLine($"Saldo: {contaPoupanca.VerificarSaldo()}");
Console.WriteLine($"Taxa Poupança: {contaPoupanca.VerificarTaxa()}");

Console.WriteLine("\nDados da Conta Empresarial:");
Console.WriteLine($"Titular: {contaEmpresarial.Titular}");
Console.WriteLine($"Saldo: {contaEmpresarial.VerificarSaldo()}");
Console.WriteLine($"Saldo Mínimo: {contaEmpresarial.VerificarSaldoMin()}");
Console.WriteLine($"Saldo Mínimo Atingido: {contaEmpresarial.BoolSaldoMin()}");
    