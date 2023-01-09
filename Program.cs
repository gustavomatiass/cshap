// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("digite o seu nome: ");
string name = Console.ReadLine();
Console.WriteLine($"olá, {name}");
Console.Write("digite a data do seu nacimento: ");
int ano = int.Parse(Console.ReadLine());
int age = 2023 - ano;
Console.WriteLine($"vc tem {age} de idade");
