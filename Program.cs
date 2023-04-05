//nome
Console.WriteLine($"Digite seu nome:");
string nome = Console.ReadLine();

while (nome.Length == 0)
{
    Console.WriteLine($"Por favor, informe o nome:");
    nome = Console.ReadLine();
}

//idade 
Console.WriteLine($"Digite sua idade:");
int idade = int.Parse(Console.ReadLine());

while(idade < 0 || idade > 100)
{
    Console.WriteLine($"Por favor, digite idade valida:");
    idade = int.Parse(Console.ReadLine());
}

//salario
Console.WriteLine($"Digite faixa salarial");
float salario = float.Parse(Console.ReadLine());

while (salario == 0)
{
    Console.WriteLine($"Por favor, digite sua faixa salarial:");
    salario = float.Parse(Console.ReadLine());
}

//estado civil
Console.WriteLine(@$"
-------------------------------
| Informe seu estado civil    |
| digite S para solteiro(a)   |
| digite C para casado(a)     |
| digite V para viuvo(a)      |
| digite D para divorciado(a) |
-------------------------------
");
char estadoCivil = char.Parse(Console.ReadLine().ToLower());

while (estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd')
{
    Console.WriteLine($"Por favor, digite seu estado civil de acordo com a orientacao:");
    estadoCivil = char.Parse(Console.ReadLine().ToLower());
}

Console.WriteLine($"Ola {nome} seja bem vindo(a), voce tem {idade} anos, sua faixa salarial informada e de {salario} e seu estado civil e {estadoCivil}.");
