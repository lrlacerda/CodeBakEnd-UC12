using CodeBackEndUc12.Classes;

string? opcao;

Utils.BarraCarregamento("Inicializando");
Console.Clear();

Console.WriteLine(@$"

        =========================================================
        |           Bem Vindo ao Sistema de Cadastro de         |
        |                Pessoa Física e Juridíca               |
        =========================================================
");
Thread.Sleep(2000);

do
{
    Console.Clear();
    Console.WriteLine(@$"

        =========================================================
        |                Digite uma das opção abaixo            |
        |                e tecle Enter para continuar           |
        =========================================================
        |                                                       |
        |                1- Pessoa Jurídica                     |
        |                2-  Pessoa Física                      |
        |                0-      Sair                           |
        =========================================================
");

    opcao = Console.ReadLine();
    // Console.WriteLine($"Você digitou {opcao}");


    switch (opcao)
    {
        case "1":

            PessoaJuridica novoPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            // Console.WriteLine(novoPj.ValidarCnpj("76773415000160"));
            // Console.WriteLine(novoPj.ValidarCnpj("76.773.415/0001-60"));

            novoPj.nome = " Empresa Lucas Lacerda ME";
            novoPj.cnpj = "76773415000160";
            novoPj.rendimento = 22600.5f;

            novoEndPj.logradouro = "Av. Doze de Outubro";
            novoEndPj.numero = 229;
            novoEndPj.complememto = "Lucas Informatica";
            novoEndPj.endComercial = false;

            novoPj.endereco = novoEndPj;

            // interpolação
            Console.WriteLine(@$"
            Nome: {novoPj.nome}
            Endereço: {novoEndPj.logradouro}, Num: {novoEndPj.numero}
            CNPJ: {novoPj.cnpj} - Valido: {novoPj.ValidarCnpj(novoPj.cnpj)}
            ");

            // Console.WriteLine(novoPj.CalcularImposto(6600.5f));

            Thread.Sleep(10000);
            break;

        case "2":

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

            // float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);
            // Console.WriteLine($"{impostoPagar: 0.00}");
            // Console.WriteLine(impostoPagar.ToString("C"));
            // DateTime temp = new DateTime(2006, 01, 01);
            // Console.WriteLine(novaPf.ValidarDataNasc("17/01/1985"));

            Console.WriteLine();
            Console.WriteLine($"Pressione qualquer tecla para continuar");
            break;

        case "0":
            Utils.BarraCarregamento("Finalizando");
            Console.Clear();
            break;

        default:
            Console.WriteLine($"digite o valor correto");
            Thread.Sleep(2000);
            break;
    }
} while (opcao != "0");
