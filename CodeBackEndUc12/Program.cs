using CodeBackEndUc12.Classes;

PessoaFisica novaPf = new PessoaFisica();
novaPf.nome = "Lucas";
novaPf.cpf = "12345678902";
novaPf.rendimento = 6600.5f;

//Pessoa Fisica
float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);
Console.WriteLine(impostoPagar);
Console.WriteLine($"{impostoPagar: 0.00}");
Console.WriteLine(impostoPagar.ToString("C"));


//Pessoa Juridica
PessoaJuridica novaPj = new PessoaJuridica();
Console.WriteLine(novaPj.CalcularImposto (6600.5f));



// // basico
// Console.WriteLine(novaPf.nome);
// Console.WriteLine(novaPf.cpf);

// // concatenação
// Console.WriteLine("Bem Vindo - " + novaPf.nome);

// // interpolação
// Console.WriteLine($"Bem Vindo: { novaPf.nome} de Cpf: {novaPf.cpf}");


