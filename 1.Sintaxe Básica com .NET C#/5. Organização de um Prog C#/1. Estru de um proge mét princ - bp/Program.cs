// Estrutura de um programa C#



//.csproj: contem informações referente a um projeto(build,debug,versão)
//.sln: Contém informações que carregam um agrupamento de projetos

string opcao;
while(true) // Passe uma variavel com (variavel=true) e na hora de encerrar o while faça variavel=false para refatorar o codigo e codigo continua embaixo
{
    Console.WriteLine("Digite uma opção");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastrar cliente\n");
            break;
        case "2":
            Console.WriteLine("Buscar cliente\n");
            break;
        case "3":
            Console.WriteLine("Apagar cliente\n");
            break;
        case "4":
            Console.WriteLine("Encerrar\n");
            Environment.Exit(0);  //Codição de encerrar o codigo completo, se tiver mais codigo embaixo ele não vai rodar
            break;
        default:
            Console.WriteLine("Opção Invalida\n");
            break;

    }
}