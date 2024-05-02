// ./Program.cs

Filme f001 = new Filme();
f001.Titulo = "Aliens";
f001.Genero = "Terror";
f001.Duracao = 2.5;
f001.Disponivel = true;

Console.WriteLine(f001.VerificarDisponibilidade());

f001.RegistrarLocacao();

Console.WriteLine(f001.VerificarDisponibilidade());

f001.RegistrarDevolucao();

Console.WriteLine(f001.VerificarDisponibilidade());