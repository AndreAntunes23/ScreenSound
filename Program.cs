// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";

void ExibirMensagemDeBoasVindas(){
    Console.WriteLine(@"𝕊𝕔𝕣𝕖𝕖𝕟 𝕊𝕠𝕦𝕟𝕕");
    Console.WriteLine(mensagemDeBoasVindas);
    }

void ExibirOpcoesDoMenu(){
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
        case 1: Console.WriteLine("Você escolheu opção 1: Registrar uma banda"); break;
        case 2: Console.WriteLine("Você escolheu opção 2: Mostrar todas as banda"); break;
        case 3: Console.WriteLine("Você escolheu opção 3: Avaliar uma banda"); break;
        case 4: Console.WriteLine("Você escolheu opção 4: Exibir a média de uma banda"); break;
        case 0: Console.WriteLine("Você escolheu opção 0: Sair\nObrigado por usar o Screen Sound, até breve! ;D"); break;
        default: Console.WriteLine("Opção inválida"); break;
    }

}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();