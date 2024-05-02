// ./Program.cs

Produto p1 = new Produto();
p1.Nome = "P1";
p1.Preco = 9.99;
p1.QuantidadeEmEstoque = 100;

Console.WriteLine(p1.QuantidadeEmEstoque);
Console.WriteLine(p1.ValorTotal());

p1.AdicionarUnidade(10);
Console.WriteLine(p1.QuantidadeEmEstoque);
Console.WriteLine(p1.ValorTotal());

p1.RemoverUnidade(20);
Console.WriteLine(p1.QuantidadeEmEstoque);
Console.WriteLine(p1.ValorTotal());