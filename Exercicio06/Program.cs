// ./Program.cs

// Usei Chat-GPT por preguiça - Promp no final do ./Program.cs
Carro carro = new Carro{
    Modelo = "Civic",
    Marca = "Honda",
    Ano = 2022,
    Placa = "ABC1234",
    Motor = "2.0",
    QntRodas = 4,
    QntPortas = 4
};

Motos moto = new Motos{
    Modelo = "CBR 1000RR",
    Marca = "Honda",
    Ano = 2021,
    Placa = "DEF5678",
    Motor = "1000cc",
    QntRodas = 2,
    Cilindradas = 1000
};

Bicicleta bicicleta = new Bicicleta{
    Modelo = "Speed",
    Marca = "Caloi",
    Ano = 2020,
    QntRodas = 2,
    QntMarchas = 18
};

Console.WriteLine("Carro:");
Console.WriteLine($"Modelo: {carro.Modelo}");
Console.WriteLine($"Marca: {carro.Marca}");
Console.WriteLine($"Ano: {carro.Ano}");
Console.WriteLine($"Placa: {carro.Placa}");
Console.WriteLine($"Motor: {carro.Motor}");
Console.WriteLine($"Quantidade de Rodas: {carro.QntRodas}");
Console.WriteLine($"Quantidade de Portas: {carro.QntPortas}");

Console.WriteLine("\nMoto:");
Console.WriteLine($"Modelo: {moto.Modelo}");
Console.WriteLine($"Marca: {moto.Marca}");
Console.WriteLine($"Ano: {moto.Ano}");
Console.WriteLine($"Placa: {moto.Placa}");
Console.WriteLine($"Motor: {moto.Motor}");
Console.WriteLine($"Quantidade de Rodas: {moto.QntRodas}");
Console.WriteLine($"Cilindradas: {moto.Cilindradas}");

Console.WriteLine("\nBicicleta:");
Console.WriteLine($"Modelo: {bicicleta.Modelo}");
Console.WriteLine($"Marca: {bicicleta.Marca}");
Console.WriteLine($"Ano: {bicicleta.Ano}");
Console.WriteLine($"Quantidade de Rodas: {bicicleta.QntRodas}");
Console.WriteLine($"Quantidade de Marchas: {bicicleta.QntMarchas}");

// Prompt:
// public class Veiculo{
//     public string Modelo{set;get;}
//     public string Marca{set;get;}
//     public int Ano{set;get;}
//     public string Placa{set;get;}
// }
// public class Carro : Veiculo{
//     public string Motor{set;get;}
//     public int QntRodas{set;get;} // Helicóptero é veículo e n possui rodas
//     public int QntPortas{set;get;}
// }
// public class Motos : Veiculo{
//     public string Motor{set;get;}
//     public int QntRodas{set;get;}
//     public int Cilindradas{set;get;}
// }
// public class Bicicleta : Veiculo{
//     public int QntRodas{set;get;}
//     public int QntMarchas{set;get;}
// }
// Crie 1 objeto para cada classe em C#.
// Atribua valores e mostre-os na tela com Console.WriteLine();