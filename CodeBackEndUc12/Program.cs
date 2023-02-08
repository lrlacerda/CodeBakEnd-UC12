using CodeBackEndUc12.Classes;

PessoaFisica novaPf = new PessoaFisica();
Endereco novoEndPf = new Endereco();

novaPf.nome = "Lucas Lacerda";
novaPf.cpf = "12345678902";
novaPf.rendimento = 6600.5f;
novaPf.dataNasc = new DateTime(2001, 01, 01);

novoEndPf.logradouro = "Av. Doze de Outubro";
novoEndPf.numero = 229;
novoEndPf.complememto = "apto 21";
novoEndPf.endComercial = true;

novaPf.endereco = novoEndPf;

// interpolação
Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereço: {novoEndPf.logradouro}, Num: {novoEndPf.numero}
Maior de idade: {novaPf.ValidarDataNasc(novaPf.dataNasc)}
");


//Pessoa Fisica
float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);
Console.WriteLine(impostoPagar);
Console.WriteLine($"{impostoPagar: 0.00}");
Console.WriteLine(impostoPagar.ToString("C"));


//Pessoa Juridica
PessoaJuridica novaPj = new PessoaJuridica();
Console.WriteLine(novaPj.CalcularImposto (6600.5f));


DateTime temp = new DateTime(2006, 01, 01);
Console.WriteLine(novaPf.ValidarDataNasc("17/01/1985"));






// // basico
// Console.WriteLine(novaPf.nome);
// Console.WriteLine(novaPf.cpf);

// // concatenação
// Console.WriteLine("Bem Vindo - " + novaPf.nome);

// // interpolação
// Console.WriteLine($"Bem Vindo: { novaPf.nome} de Cpf: {novaPf.cpf}");


