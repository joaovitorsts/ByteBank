// See https://aka.ms/new-console-template for more information
using ByteBank;
using ByteBank.Funcionarios;

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

Funcionario carlos = new Funcionario(2000, "Carlos", "546.879.157 - 20");

carlos.AumentarSalario();
Console.WriteLine("Novo salário do Carlos: " + carlos.Salario);

gerenciador.Registrar(carlos);

Diretor roberta = new Diretor(5000, "Roberta", "454.658.148 - 3");

roberta.AumentarSalario();
Console.WriteLine("Novo salário da Roberta: " + roberta.Salario);

gerenciador.Registrar(roberta);

Console.WriteLine(carlos.Nome);
Console.WriteLine(carlos.GetBonificacao());

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

Console.ReadLine();