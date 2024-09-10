// Screen Sound


string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
List<string> listaDeBandas = new List<string>{"U2", "Pearl Jam", "Coldplay"};

void ExibirLogo(){
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀");
    Console.WriteLine(mensagemDeBoasVindas);
    }

void ExibirOpcoesDoMenu(){
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as banda");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção\n");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
    // options to user chose on menu
    switch (opcaoEscolhidaNumerica){
        case 1: RegistrarBanda(); break;
        case 2: MostrarBandasRegistradas(); break;
        case 3: Console.WriteLine("Você escolheu opção 3: Avaliar uma banda"); break;
        case 4: Console.WriteLine("Você escolheu opção 4: Exibir a média de uma banda"); break;
        case 0: Console.WriteLine("Você escolheu opção 0: Sair\nObrigado por usar o Screen Sound, até breve! ;D"); break;
        default: Console.WriteLine("Opção inválida"); break;
    }

}

// band registration
void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("******************");
    Console.WriteLine("Registro de Bandas");
    Console.WriteLine("******************\n");
    Console.WriteLine("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDeBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

// view bands registred
void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("******************");
    Console.WriteLine("Bandas Registradas");
    Console.WriteLine("******************\n");
    // for(int i = 0; i < listaDeBandas.Count; i++){
    //     Console.WriteLine($"Banda: {listaDeBandas[i]}");
    // }

    foreach(string banda in listaDeBandas){
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();