// Meu primeiro jogo

Console.WriteLine(@$"

                    ??? HORA DO QUIZ ???        
                    
                    
                    ");

Console.WriteLine($"Está pronto? Responda com sim ou não.");
string respostaQUIZ = Console.ReadLine()!.ToLower();
if (respostaQUIZ == "sim") {
    Console.WriteLine($"Então vamos começar!");
} else {
    Console.WriteLine($"Bom, vamos começar mesmo assim :)");
}

Console.WriteLine(@$"

Selecione a sua resposta usando os números 1, 2, 3, 4 e 5

");

Console.WriteLine(@$"
Quantos blocos ajuntados (de um só tipo) formam um 'pack' no MINECRAFT?

1- 50 blocos
2- 100 blocos
3- 93 blocos
4- 64 blocos
5- 12 blocos
");
int resposta1 = int.Parse(Console.ReadLine()!);
switch (resposta1){
    case 1:
    Console.WriteLine($"Você errou :(   GAME OVER");
    break;

    case 2:
    Console.WriteLine($"Você errou :(   GAME OVER");
    break;

    case 3:
    Console.WriteLine($"Você errou :(   GAME OVER");
    break;

    case 4:
    Console.WriteLine($"Resposta certa!");
    Console.WriteLine(@$"
    Qual o nome da série em que Tio Patinhas (personagem da Disney), aparece como protagonista em aventuras?
    
    1- As aventuras do Tio Patinhas
    2- Grande dólares
    3- DuckTales
    4- DuckVentures
    5- Contos de pato
    ");
    int resposta2 = int.Parse(Console.ReadLine()!);
    switch (resposta2) {
        case 1:
        Console.WriteLine($"Você errou :(   GAME OVER");
        break;

        case 2:
        Console.WriteLine($"Você errou :(   GAME OVER");
        break;

        case 3:
        Console.WriteLine($"Resposta certa!");
        Console.WriteLine(@$"
        Quantas esmeraldas existem na franquia Sonic? (Não conta a esmeralda mestre)
        
        1- Sete
        2- Três
        3- Duas
        4- Oito
        5- Não existe outras esmeraldas além da esmeralda mestre
        ");
        int resposta3 = int.Parse(Console.ReadLine()!);
        switch (resposta3) {
            case 1:
            Console.WriteLine($"Resposta certa!");
            Console.WriteLine(@$"
            Qual é o nome da cidade onde se passa a série Gravity Falls?
            1- Rackcity
            2- Townsville
            3- Hungers city
            4- Pinnes Falls
            5- Gravity Falls
            ");
            int resposta4 = int.Parse(Console.ReadLine()!);
            switch (resposta4) {
                case 1:
                Console.WriteLine($"Você errou :(   GAME OVER");
                break;

                case 2:
                Console.WriteLine($"Você errou :(   GAME OVER");
                break;

                case 3:
                Console.WriteLine($"Você errou :(   GAME OVER");
                break;

                case 4:
                Console.WriteLine($"Você errou :(   GAME OVER");
                break;

                case 5:
                Console.WriteLine($"Resposta certa!");
                Console.WriteLine(@$"
                Essa tava bem óbvia até. A última:
                ");
                Console.WriteLine(@$"
                Como o Mario cresce em Super Mario?
                
                1- Que mario?
                2- Ele pula bastante
                3- Ele come um cogumelo
                4- Ele bebe uma poção
                5- Ele pede ajuda para o irmão dele, o Luigi
                ");
                int resposta5 = int.Parse(Console.ReadLine()!);
                switch (resposta5) {
                    case 1:
                    Console.WriteLine($" Bom... Perdeu!");
                    break;

                    case 2:
                    Console.WriteLine($"Errou muito");
                    break;

                    case 3:
                    Console.WriteLine($"PARABÉNS! VOCÊ VENCEU!");
                    break;

                    case 4:
                    Console.WriteLine($"Tão perto...");
                    break;

                    case 5:
                    Console.WriteLine($"Perdeu!");
                    break;

                    default:
                    Console.WriteLine($"Tá de brincadeira? você tava no final!");
                    break;
                }
                
                break;

                default:
                Console.WriteLine($"Resposta inválida. GAME OVER");
                break;
            }
            
            break;

            case 2:
            Console.WriteLine($"Você errou :(   GAME OVER");
            break;

            case 3:
            Console.WriteLine($"Você errou :(   GAME OVER");
            break;

            case 4:
            Console.WriteLine($"Você errou :(   GAME OVER");
            break;

            case 5:
            Console.WriteLine($"Você errou :(   GAME OVER");
            break;

            default:
            Console.WriteLine($"Resposta inválida. GAME OVER");
            break;
        }
        
        break;

        case 4:
        Console.WriteLine($"Você errou :(   GAME OVER");
        break;

        case 5:
        Console.WriteLine($"Você errou :(   GAME OVER");
        break;

        default:
        Console.WriteLine($"Resposta inválida. GAME OVER");
        break;
    }
    break;
    
    case 5:
    Console.WriteLine($"Você errou :(   GAME OVER");
    break;

    default:
    Console.WriteLine($"Resposta inválida. GAME OVER");
    break;
}