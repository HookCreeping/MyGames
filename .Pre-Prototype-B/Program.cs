//Two Ways

// $ = concluido

Console.WriteLine($"TWO WAYS");
Br();
Br();

// V a r i á v e i s



//começo
bool esquerda = false;
bool direita = false;


//meio
bool checarCabana = false;
bool entrarCabana = false;
bool rodearCabana = false;
bool seguirCaminho = false;

//fim
bool finalCanonico = false;

bool fimChuvoso = false;
bool fimUrso = false;
bool fimTranquilo = false;

bool fimEscuro = false;
bool fimExplosivo = false;
bool fimCacador = false;


bool reset = false;










// I N Í C I O     D O     J O G O



Console.WriteLine(@$"

    É uma noite chuvosa, você anda em uma floresta, num lugar um pouco
    sinistro para o seu gosto. Estás sem rumo. Entretanto, avistas ao
    que se parece uma trilha. Você entra nesta suposta trilha, até chegar
    a um ponto interessante: Uma bifurcação. Aparenta haver dois caminhos
    a serem seguidos:

    Esquerda
    Direita

    Por qual você quer seguir com a sua jornada?

    ESQUERDA     DIREITA     

    -dica: reescreva apenas o que está em maiúsculo (não é necessário ser 
    em maiúsculo também)-
    -se a resposta não for válida, verifique se está acentuada ou não-
");

do // $
{
    string resposta = Resposta();

    switch (resposta)
    {
        case "esquerda":
            esquerda = true;
            reset = true;
            break;

        case "direita":
            direita = true;
            reset = true;
            break;

        default:
            Invalido();

            Console.WriteLine($@"
    Você poder ir para a ESQUERDA, ir para a DIREITA ou pode
    VOLTAR. ");
            break;
    }
} while (reset == false);
reset = false;



// CAMINHO DA ESQUERDA - CONCLUÍDO
if (esquerda == true) // $
{
    Br();
    Console.WriteLine($"Você escolhe ir para a esquerda.");
    Br();
    Console.WriteLine(@$"
    Agora, você anda em frente, entra no que parece ser um lado muito
    escuro da floresta. Parece que essa trilha não tem fim, e ja estás
    com cansaço.
    
    Andas tanto que nem vale mais a pena voltar. Numa floresta, escura
    e chuvosa, você percebe que já acabaram as suas energias. Pela sua
    sorte, avistas uma pequena figura que se aparenta com uma cabana.
    Mas é claro, não se sabe o que tem dentro dessa casinha, o que pode
    ser um risco para você mesmo.
    ");

    Br();
    Cut();
    Br();

    Console.WriteLine(@$"
    O que você vai fazer?
    CHECAR a cabana         SEGUIR o caminho
    ");

    do // $
    {
        string resposta = Resposta();

        switch (resposta) // $
        {
            case "checar":
                reset = true;
                checarCabana = true;
                break;

            case "seguir":
                reset = true;
                seguirCaminho = true;
                break;

            default:
                Invalido();

                Console.WriteLine(@$"
    Você pode CHECAR a cabana, ou SEGUIR o caminho, apenas.
            ");
                break;
        }
    } while (reset == false);
    reset = false;
}





// CAMINHO DA DIREITA - CONCLUÍDO
if (direita == true) // $
{
    int tocha = 0;
    int explosivos = 0;
    int picareta = 0;
    int corda = 0;
    int tecido = 0;
    int bastao = 0;
    int equipamentoEscalada = 0;
    int ativadorRemoto = 0;
    int dinamiteRemota = 0;
    bool bombaNaRocha = false;
    bool voltarMina = true;
    bool voltarParede = true;

    Br();
    Console.WriteLine($"Você escolhe ir para a direita.");
    Br();

    Console.WriteLine(@$"
    Seguindo o caminho da direita, percebes que está seguindo uma
    trilha que vai levar a uma ravina. Você passa entre um arco de
    pedra, descendo pela entrada dessa ravina. Porém, um raio cai e
    derruba uma enorme pedra que bloqueia o caminho de volta. Agora
    voltar não é mais uma opção... A não ser se algo quebrar aquela 
    grande rocha. Numa ravina como essa, talvez tenha uma outra saída
    ou talvez uma forma de lidar com o obstáculo...
    ");

    Cut();

    Console.WriteLine(@$"
    Descendo a inclinação dessa ravina (parece uma enorme rampa) você
    chega lá no fundo... O que é interessante é que parece haver uma
    velha MINA naquele lugar, ou seja, um local de mineração que, com
    certeza, ajude você a encontrar algo para escapar dali, como
    PICARETAS e CORDAS para subir (talvez) escalando... Mas não sabeis
    como fazer isso ainda... Ou talvez encontrar algo que acabe com a
    pedra da volta... Como marretas, imãs (se houver metais dentro da
    rocha)... Ou EXPLOSIVOS talvez?

    As escolhas são muitas nessa mina. Mas deves checá-la e procurar
    os itens.
    ");

    Cut();

    Console.WriteLine(@$"
    Só que as coisas estão escuras... Sabe? Vai ser muito ruim se você
    Entrar lá dentro sem conseguir enxergar nada. Vai que algo ruim
    acontece... Então encontre algo que possa iluminar a passagem. Uma
    lanterna, um isqueiro, uma TOCHA, qualquer coisa dessas será útil
    para iluminar o seu caminho.
    ");

    Cut();

    Console.WriteLine(@$"
    Outro fato é que, logo de cara, numa parte mais coberta, encontras
    uma bancada de trabalho. Ela pode ser utilizada para fazer itens ou
    melhorar os mesmos. Outra coisa é uma parede macia que, pelo o que
    parece, dá para escalar usando algum EQUIPAMENTO DE ESCALADA. 
    São essas coisas que são 'escolhíveis':

    explorar a MINA
    checar a BANCADA
    aproximar-se da PAREDE
    voltar para a PEDRA
    olhar os DESPOJOS do lugar
    ");
    Br();

    Cut();

    Br();
    do // $
    {
        Console.WriteLine($"Você está no meio da ravina");
        Br();

        Console.WriteLine(@$"
    Para onde você quer ir checar?
    MINA     BANCADA     PAREDE     PEDRA     DESPOJOS");
        if ((dinamiteRemota != 0) && (bombaNaRocha == true)) // $
        {
            Console.WriteLine(@$"
    EXPLODIR");
        }
        Br();
        string resposta = Resposta();

        if (resposta == "mina") // $
        {
            bool naMina = true;
            if (voltarMina == true) // $
            {
                do // $
                {
                    Console.WriteLine(@$"Você está na frente da entrada da mina");
                    Br();
                    if (tocha == 0) // $
                    {
                        Console.WriteLine(@$"
    Trata-se de um lugar extremamente escuro, como se fosse a entrada
    para um túnel. A única coisa que realmente você consegue ver é a
    própria entrada. O recomendado é você possuir uma TOCHA ou algo
    que ilumine a entrada antes de entrar...
                ");
                    }
                    else if (tocha > 0)// $
                    {
                        Console.WriteLine(@$"
    Como você tem uma TOCHA, dá para você entrar tranquilamente ai
    dentro.
                ");
                    }
                    else if (voltarMina == false) // $
                    {
                    }

                    Br();
                    Cut();
                    Br();

                    if (voltarMina == true) // $
                    {
                        Console.WriteLine(@$"
    ENTRAR?     ou     VOLTAR?
                ");
                        string acao = Resposta();

                        if (acao == "voltar") // $
                        {
                            naMina = false;

                            Console.WriteLine(@$"
                    Você voltou para o lugar de antes
                    ");

                        }
                        else if (acao == "entrar") // $
                        {
                            if (tocha == 0) // $
                            {
                                fimEscuro = true;
                                naMina = false;
                                reset = true;
                            }
                            else // $
                            {
                                Console.WriteLine($"Você está dentro da mina");
                                Br();

                                Console.WriteLine(@$"
    Ao entrar naquele lugar, você vê que aquela mina era de uma empresa
    que fornecia minérios em geral. Porém, parece que aquele lugar
    faliu, o que é bem estranho, já que você se lembra que essa
    empresa é bem famosa no mercado, com várias minas para si. Mas essa
    aqui faliu, e estranhamente ninguém retirou nada daqui. Por que?
    Não se sabe.");

                                Br();
                                Cut();
                                Br();

                                Console.WriteLine(@$"
    Andando por aquele túnel, percebes que muita gente deve ter
    trabalhado em busca de minérios em geral. Algumas pedras parecem
    conter carvão e ferro, e o chão é bem úmido, como uma caverna.
    Porém, andando mais um pouquinho você chega a uma enorme câmara de
    pedra, feita supostamente pelas escavações dos ex-funcionários do
    lugar.
    ");

                                Br();
                                Cut();
                                Br();

                                Console.WriteLine(@$"
    Você caminhando E PARA de repente quando percebe um enorme BURACO
    perfurado no chão (maior que um prédio). Parece um grande abismo
    em forma de cratera. Ainda bem que você tinha uma tocha... Imagina?
    Cair naquele buraco? Bom, andando parece que está tudo certo...
    ");

                                Br();
                                Cut();
                                Br();

                                Console.WriteLine(@$"
    O lado de onde você veio cai pedregulhos. agora não dá para sair
    da mina... Por enquanto...
    
    Bom, você tem três caminhos para seguir: VOLTAR, que agora é
    algo impossível... seguir para a DIREITA ou para a ESQUERDA, de
    novo...
    
    A escolha é sua, Player.
    
    VOLTAR     DIREITA     ESQUERDA
    ");

                                bool dentroDaMina = true;
                                do // $
                                {
                                    string escolha = Resposta();

                                    if (escolha == "voltar") // $
                                    {
                                        if (explosivos == 2) // $
                                        {
                                            Console.WriteLine(@$"
    Você coloca uma das suas dinamites naqueles pedregulhos. Porém,
    essa é a única que tem pavio, a outra não tem, ou seja, se for para
    ativá-la, terá que ter algo mais direto. Bom... de qualquer forma,
    Você pega sua TOCHA, ascende o pavio, vai para um lugar seguro e...
    ");

                                            Br();
                                            Cut();
                                            Br();

                                            Console.WriteLine(@$"
    888888888888    888888888888    888888888888    888      888
    888888888888    888888888888    888888888888    88888  88888
    888      888    888      888    888      888    888888888888
    888      888    888      888    888      888    888  88  888
    888     888     888      888    888      888    888      888
    88888888        888      888    888      888    888      888
    888     888     888      888    888      888    888      888
    888      888    888      888    888      888    888      888
    888      888    888      888    888      888    888      888
    888888888888    888888888888    888888888888    888      888
    888888888888    888888888888    888888888888    888      888
    ");

                                            Br();
                                            Cut();
                                            Br();

                                            Console.WriteLine(@$"O caminho está livre.
         
Você volta para o meio da ravina.");
                                            dentroDaMina = false;
                                            naMina = false;
                                            voltarMina = false;

                                            explosivos--;

                                            Br();
                                            Cut();
                                            Br();

                                            Console.WriteLine(@$"
    Parece que a explosão fez um pequeno tremor, e percebes que uma
    caixa caiu e quebrou. Dentro dela, há uma CORDA. Você a coleta
    ");

                                            Br();
                                            Cut();
                                            Br();

                                            corda++;
                                            Console.WriteLine($"Você obteve CORDA");

                                        }
                                        else // $
                                        {
                                            Console.WriteLine(@$"
    Você não consegue tirar todos esses pedregulhos à mão. Para obter
    sucesso nisso, é melhor que você exploda aqueles pedregulhos.
    
    Por hora, tente ir para a DIREITA ou para a ESQUERDA
    ");
                                        }
                                    }
                                    else if (escolha == "direita") // $
                                    {
                                        if (picareta != 2) // $
                                        {
                                            Console.WriteLine(@$"Você vai pra DIREITA... de novo...");
                                            Br();
                                            Console.WriteLine(@$"
    Bom, seguindo o caminho, você encontra algo interessante: Duas
    PICARETAS que aparentam ser de escalada, por causa das pontas.
    Diferente das outras, essas estão intactas, velhas, mas intactas.
    ");

                                            Br();
                                            Cut();
                                            Br();

                                            Console.WriteLine($"Você adiquire PICARETA x2.");
                                            picareta += 2;
                                            Br();
                                            Console.WriteLine($"Use-as para abrir coisas ou para criar algo.");
                                            Br();
                                        }
                                        Console.WriteLine(@$"
    Não há mais nada para ver aqui.
    
Você volta para o lugar de antes.

    ESQUERDA     ou     VOLTAR
");
                                    }
                                    else if (escolha == "esquerda") // $
                                    {
                                        Console.WriteLine(@$"Você vai para a ESQUERDA");
                                        Br();
                                        Console.WriteLine(@$"
    Ao andar um pouco, você avista uma mesa, com algumas ferramentas
    quebradas e com um papel e uma caixa. Você tenta ler aquela 
    mensagem.
    ");

                                        Br();
                                        Cut();
                                        Br();


                                        Console.WriteLine(@$"
    -------------------------------------------------------
    !  !  !  !  !  !  !  !  !  !  !  !  !  !  !  !  !  !  !
     ccccc   u   u   i   dddd        a       dddd    ooooo
    !c       u   u   i   d   d      a a      d   d   o   o!
     c       u   u   i   d   d     a   a     d   d   o   o
    !c       u   u   i   d   d    aaaaaaa    d   d   o   o!
     ccccc   uuuuu   i   dddd     a     a    dddd    ooooo
    !  !  !  !  !  !  !  !  !  !  !  !  !  !  !  !  !  !  !");
                                        Console.ResetColor();
                                        Br();
                                        Console.WriteLine(@$"   EXPLOSIVOS aqui.
    Tenha cuidado para usar
    Risco de MORTE
    ");

                                        Br();
                                        Cut();
                                        Br();

                                        Console.WriteLine(@$"
    Dentro da caixa há o que você precisa então. Basta apenas abrir ela
    para conseguir os EXPLOSIVOS. Porém... Ela está lacrada.
                                    ");

                                        Br();
                                        Cut();
                                        Br();

                                        if (picareta == 0) // $
                                        {
                                            Console.WriteLine(@$"
    Você não tem nenhuma ferramenta para abrir a caixa. Tente procurar
    algo por outros lados.");

                                            Br();
                                            Cut();
                                            Br();

                                            Console.WriteLine($"Você volta para o local de antes");

                                        }
                                        else // $
                                        {
                                            Console.WriteLine(@$"
    Você tem duas picaretas, e pode usá-las para abrir a caixa!
    
    Dito e feito. A caixa está aberta! Lá dentro tem duas dinamites
    fresquinhas, porém, uma delas não tem pavio para ser acendido, ou
    seja, algo deve ascender diretamente a bomba (como a sua tocha). 
    Mas a outra está boa para se usar, e tem um pavio maior do que tu
    esperavas! Agora dá para sair de dentro da mina!
    ");

                                            Br();
                                            Cut();
                                            Br();

                                            explosivos += 2;
                                            Console.WriteLine($"Você adiquiriu 2x EXPLOSIVOS");

                                            Br();
                                            Cut();
                                            Br();

                                            Console.WriteLine($"Você retorna ao meio");
                                        }
                                    }
                                    else // $
                                    {
                                        Invalido();

                                        Br();

                                        Console.WriteLine(@$"
    Por hora, VOLTAR, ir para a DIREITA ou ir para a ESQUERDA são as
    suas opções.
    
    E então?
    ");

                                    }
                                } while (dentroDaMina == true);
                            }
                        }
                        else // $
                        {
                            Invalido();
                            Br();
                            Console.WriteLine($@"
    Apenas duas escolhas: ENTRAR, ou VOLTAR
    ");

                        }
                    }
                } while (naMina == true);
            }
            else // $
            {
                Console.WriteLine(@$"
    Não há porque voltar aí
    ");
            }
        }
        else if (resposta == "bancada") // $
        {
            Console.WriteLine($"Você escolheu dar uma olhada na bancada");
            Br();
            Console.WriteLine(@$"
    Você está na frente da bancada. Parece que você pode criar coisas a 
    partir daqui.
    Para ajudar, parece haver uma LISTA que pode te ajudar no artesanato
    de novos equipamentos.
            
    VOLTAR     CRIAR     LISTA     CHECAR");
            Br();
            bool naBancada = true;

            do
            {

                string acao = Resposta();


                if (acao == "voltar") // $
                {
                    naBancada = false;
                }
                else if (acao == "criar") // $
                {
                    Console.WriteLine(@$"
    O que gostarias de criar?

    [1] - TOCHA
    [2] - EQUIPAMENTO DE ESCALADA
    [3] - DINAMITE REMOTA

    VOLTAR

    - dica: digite o número dentro da caixa para escolher essa parte;
");

                    bool criando = true;
                    do // $
                    {
                        string criacao = Resposta();

                        if (criacao == "1") // $
                        {
                            if ((bastao > 0) && (tecido > 0)) // $
                            {
                                tocha++;

                                Console.WriteLine(@$"
    Você pega o TECIDO, enrola no BASTÃO, usa algumas pequenas
    peças em cima da bancada. Com um pouco de cuidado, acendes uma
    pequena faísca. Dali, nasce um fogo, e agora a iluminação não é
    feita apenas da luz da lua...
    ");

                                Br();
                                Cut();
                                Br();

                                Console.WriteLine($"Você criou uma TOCHA");
                                Br();

                                Cut();
                                Console.WriteLine(@$"
    E agora?
    
    O que gostarias de criar?

    [1] - TOCHA
    [2] - EQUIPAMENTO DE ESCALADA
    [3] - DINAMITE CRONOMETRADA

    VOLTAR
    ");

                            }
                            else // $
                            {
                                Br();
                                Console.WriteLine($"Materiais insuficientes");
                                Br();
                            }
                        }
                        else if (criacao == "2") // $
                        {
                            if ((picareta > 1) && (corda > 0)) // $
                            {
                                Console.WriteLine(@$"
    Você pega uma PICARETA, amarra em um lado da CORDA, e complementa
    com a outra PICARETA do outro lado. Prendes esse novo equipamento
    na cintura. Agora, a melhor coisa para se fazer é procurar uma
    parede boa o sulficiente para testar o seu novo {"Brinquedinho"}
    ");

                                Br();
                                Cut();
                                Br();

                                equipamentoEscalada++;
                                Console.WriteLine($"Você criou o EQUIPAMENTO DE ESCALADA");
                                Br();
                            }
                            else // $
                            {
                                Br();
                                Console.WriteLine($"Materiais insulficientes");
                                Br();

                                Console.WriteLine(@$"
    E agora?
    O que gostarias de criar?

    [1] - TOCHA
    [2] - EQUIPAMENTO DE ESCALADA
    [3] - DINAMITE CRONOMETRADA

    VOLTAR                            
    ");

                            }
                        }
                        else if (criacao == "3") // $
                        {
                            if ((explosivos > 0) && (ativadorRemoto > 0)) // $
                            {
                                Console.WriteLine($@"
    Você pega os explosivos, entrelaça eles uns aos outros, conecta os
    cabos do controlador em um deles e faz um pequeno botão para a
    ativação. Agora dá para fazer uma explosão menos perigosa, sem
    riscos de se ferir. Use-a com o maior cuidado mesmo assim!
    ");

                                Br();
                                Cut();
                                Br();

                                Console.WriteLine($"Você criou uma DINAMITE REMOTA");
                                Br();

                                dinamiteRemota++;
                            }
                            else // $
                            {
                                Br();
                                Console.WriteLine($"Materiais insuficientes");
                                Br();
                            }
                        }
                        else if (criacao == "voltar") // $
                        {
                            Console.WriteLine(@$"Você  volta para as outras opções da bancada
                            
    VOLTAR     CRIAR     LISTA     CHECAR
    ");
                            criando = false;
                        }
                        else // $
                        {
                            Invalido();
                            Br();
                            Console.WriteLine(@$"
    Há apenas 3 opções:
    [1] criar uma TOCHA
    [2] criar um EQUIPAMENTO DE ESCALADA
    [3] criar... Uma bomba? (bom, é uma opção)
            
    Ou VOLTAR. Apenas essas opções.

    - ps: Aqui deve ser escrito os NÚMEROS dentro das chaves, exceto
    VOLTAR -
    ");
                        }
                    } while (criando == true);

                }
                else if (acao == "lista") // $
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@$"

R E C U R S O S     P A R A     C R I A R

TOCHA               | EQUIPAMENTO DE ESCALADA  | DINAMITE REMOTA
                    |                          |
Útil para iluminar  | Útil para escalar        | Boa para gerar uma
lugares escuros     | paredes macias           | explosão controlada e
                    |                          | mais segura
                    |                          |
1x BASTÃO           | 2x PICARETA              | 1x EXPLOSIVOS
1x TECIDO           | 1X CORDA                 | 1x CONTROLADOR REMOTO
");
                    Console.ResetColor();

                    Console.WriteLine(@"
                    
    VOLTAR     CRIAR     LISTA     CHECAR
    ");

                }
                else if (acao == "checar") // $
                {
                    Console.WriteLine(@$"
    Uma bancada velha e abandonada. Ainda dá para fazer algum 
    artesanato nela.
    ");
                }
                else // $
                {
                    Invalido();

                    Console.WriteLine(@$"
    VOLTAR, CRIAR, ver a LISTA ou CHECAR a bancada são as opções. Fora
    disso, não existe outra escolha.");

                }
            } while (naBancada == true);
        }
        else if (resposta == "parede") // $
        {

            bool naParede = true;
            if (voltarParede == true) // $
            {
                do // $
                {
                    Console.WriteLine(@$"
    Você está na frente da parede. Ela tem a maciez perfeita para se
    escalar. Obviamente, é necessário um EQUIPAMENTO DE ESCALADA.
    ");

                    Console.WriteLine($@"
    VOLTAR     ESCALAR
    ");

                    string acao = Resposta();

                    if (acao == "escalar") // $
                    {
                        if (equipamentoEscalada > 0) // $
                        {
                            Console.WriteLine(@$"
    Você tem o EQUIPAMENTO DE ESCALADA que criou e, com força, usa ele
    nessa parede. Subindo ela, a parede vai ficando mais e mai dura,
    até chegar um momento que não dá para escalar mais. Sair escalando
    não é uma opção...
    ");

                            Br();
                            Cut();
                            Br();

                            Console.WriteLine(@$"
    Mas há algo que pode ajudar você: Numa pequena plataforma que você
    conseguiu alcançar há uma caixa aberta, e nela há um pequeno
    dispositivo. Você pega esse dispositivo e desce. Ao olhar para ele,
    descobres que se trata de um ATIVADOR REMOTO, o que te permite
    acionar qualquer coisa remotamente, mas simplificadamente.
    
    Mesmo assim, é um avanço!
    ");

                            Br();
                            Cut();
                            Br();

                            ativadorRemoto++;
                            Console.WriteLine(@$"
    Você obteve um CONTROLADOR/ATIVADOR REMOTO");

                            naParede = false;
                            voltarParede = false;
                        }
                        else // $
                        {
                            Console.WriteLine(@$"
    Você não consegue escalar lá para cima.
    
    VOLTAR?");
                        }

                    }
                    else if (acao == "voltar") // $
                    {
                        naParede = false;
                    }

                } while (naParede == true);
            }
            else // $
            {
                Console.WriteLine($"Você já explorou tudo por aqui!");

            }
        }
        else if (resposta == "pedra") // $
        {
            bool naPedra = true;
            do // $
            {
                Console.WriteLine(@$"    
    Eis a pedra em sua frente!

    REMOVER     VOLTAR
            ");

                string acao = Resposta();
                if (acao == "remover") // $
                {
                    if ((dinamiteRemota == 0) && (explosivos > 0)) // $
                    {
                        Console.WriteLine(@$"
    Você tem o explosivo necessário para explodir essa pedra. Mas, ele
    não tem um pavio decente. Se você acender com a tocha, é melhor
    correr!
    
    EXPLODIR     ou     VOLTAR
    ");

                        bool escolhaFinal = true;
                        do // $
                        {
                            string escolha = Resposta();

                            if (escolha == "explodir") // $
                            {
                                fimExplosivo = true;
                                escolhaFinal = false;
                                naPedra = false;
                                reset = true;
                            }
                            else if (escolha == "voltar") // $
                            {
                                escolhaFinal = false;
                                naPedra = false;
                            }
                            else // $
                            {
                                Invalido();

                                Console.WriteLine(@$"
    EXPLODIR ou VOLTAR, é pegar ou largar!");

                            }

                        } while (escolhaFinal == true);

                    }
                    else if (dinamiteRemota > 0) // $
                    {
                        Console.WriteLine($"Você coloca a dinamite na rocha...");
                        bombaNaRocha = true;
                        Br();
                        Console.WriteLine($@"
    É melhor ter muito cuidado agora! Tente EXPLODIR essa bomba!
    
    EXPLODIR     VOLTAR");

                        bool escolhaFinal = true;
                        do // $
                        {
                            string escolha = Resposta();

                            if (escolha == "explodir") // $
                            {
                                fimExplosivo = true;
                                escolhaFinal = false;
                                naPedra = false;
                            }
                            else if (escolha == "voltar") // $
                            {
                                escolhaFinal = false;
                                naPedra = false;
                            }
                            else // $
                            {
                                Invalido();

                                Console.WriteLine(@$"
    EXPLODIR ou VOLTAR, é pegar ou largar!");

                            }

                        } while (escolhaFinal == true);
                    }
                    else if ((explosivos == 0) || (dinamiteRemota == 0))// $
                    {
                        Console.WriteLine(@$"
    Você não consegue remover essa grande pedra sozinho...

    VOLTAR?
    ");
                    }
                    else // $
                    {
                        Invalido();
                    }
                }
                else if (acao == "voltar") // $
                {
                    naPedra = false;
                }
                else // $
                {
                    Invalido();
                    Br();
                    Console.WriteLine(@$"
    VOLTAR ou REMOVER a pedra são as escolhas");
                }

            } while (naPedra == true);
        }
        else if (resposta == "despojos") // $
        {
            if (bastao < 1) // $
            {
                Console.WriteLine(@$"
    Há despojos espalhados por aí. Entre eles, encontras algumas
    picaretas quebradas, dinamites já usadas (inutilizáveis) e
    peças de roupas rasgadas... Mas o mais esquisito: Não há
    ninguém ali... 
        
    Você encontra uma PICARETA que parece que...
        
    ...
        ");
                Cut();
                Console.WriteLine(@$"CRAC
    A picareta quebra em suas mãos. Que ruim... Parece que nenhuma
    picareta naquela área está boa... Bom... Pelo menos há o cabo da
    ferramenta, um cabo de madeira, parecido com um BASTÃO.
    Além disso, você pega um pouco de TECIDO no meio das roupas
    rasgadas. Talvez dê para fazer algo com isso.
        ");
                Cut();
                Console.WriteLine($"TECIDO adiquirido");
                tecido++;
                Console.WriteLine($"BASTÃO adiquirido");
                bastao++;
                Cut();
            }
            else // $
            {
                Console.WriteLine($"Você já explorou tudo por aqui");

            }

        }
        else if ((resposta == "explodir") && (bombaNaRocha == true)) // $
        {
            fimCacador = true;
            reset = true;
        }
        else // $
        {
            Invalido();
            Console.WriteLine(@$"
    MINA, BANCADA, PAREDE, PEDRA, DESPOJOS da ravina. Essas
    são as suas escolhas, só essas.
            ");
        }

    } while (reset == false);
    reset = false;
}














// M E I O     D O     J O G O



// CAMINHO DA ESQUERDA

// C h e c a n d o     a     c a b a n a
if (checarCabana == true) // $
{
    Br();
    Console.WriteLine($"Você escolhe CHECAR a cabana.");
    Br();
    Console.WriteLine(@$"
    Pra quê continuar lá fora no escuro? A melhor coisa para se fazer
    é espiar a cabana, é claro! Se não tiver ninguém lá, dá para
    passar a noite tranquilamente!
    
    Bom, você está disposto a entrar naquela casa, espia a janela e
    não vê ninguém dentro do lugar. Não tem porquê ficar do lado de
    fora. Agora, o que dá para fazer é entrar pela porta... ou achar 
    outra entrada. O que você vai fazer?
    
    ENTRAR pela porta     RODEAR a casa
    ");



    do
    {
        string resposta = Resposta();

        switch (resposta)
        {
            case "entrar":
                entrarCabana = true;
                reset = true;
                break;

            case "rodear":
                rodearCabana = true;
                reset = true;
                break;

            default:
                Br();
                Invalido();

                Console.WriteLine(@$"
    tente ENTRAR na casa pela porta ou RODEAR ela mesma.
            ");
                break;
        }

    } while (reset == false);
    reset = false;
}

// Entrando pela porta - CONCLUÍDO
if (entrarCabana == true) // $
{
    fimUrso = true;
    Br();
    Console.WriteLine($"Você escolhe ENTRAR na cabana");
    Br();
}

// Rodear o local - CONCLUÍDO
if (rodearCabana == true) // $
{
    int péDeCabra = 0;
    int chaveVelha = 0;

    Br();
    Console.WriteLine($"Você escolhe RODEAR a cabana");
    Br();
    Console.WriteLine(@$"
    Parando para analizar, é melhor dar uma pequena olhada ao redor do
    lugar... Como você já virou uma vez para a esquerda (na hora de
    escolher um dos três caminhos), decides seguir para o lado direito.
    
    Andando um pouco, a parede direita da cabana não tem janelas nem
    nada do tipo. É um lugar até que velho, mas bem cuidado, é
    impossível ninguém morar ali! Mas agora vem o pensamento: E se
    a pessoa que mora aqui é um caçador? Ou alguém louco? Aquele 
    ambiente é muito bizarro para alguém morar sozinho...
    
    Bom, chegando na parte de trás da casa, percebes que há uma entrada
    para o porão da casa, uma caixa um pouco velha e um arbusto... 
    Suspeito, já que parece artificial (ele parece brilhar no escuro!)
    
    Talvez passar uma noite no porão não seria algo tão ruim, afinal, 
    você conseguiria evitar aquela chuva toda, além de poder descansar
    um pouquinho (mas não com o mesmo conforto que descansar na sala
    da cabana.)
    
    Existem três coisas que você pode fazer:

    Entrar no PORÃO
    Verificar a CAIXA
    Verificar o ARBUSTO
    
    
    ");

    do // $
    {
        Console.WriteLine(@"
    O que você escolhe?

    PORÃO     CAIXA     ARBUSTO

    - dica: cuidado com a acentuação!-");

        string resposta = Resposta();

        if (resposta == "porão") // $
        {
            Br();
            Console.WriteLine($"Você chega até a entrada do PORÃO");
            Br();
            Console.WriteLine(@$"
    Puxa vida! Parece que tem uma tábua pregada no que seria a
    porta do porão... A passagem está bloqueada por enquanto.

    A não ser que você tente ARRANCAR esse obstáculo.

    ARRANCAR   VOLTAR
            ");



            bool noPorao = false; // $
            do
            {
                string acao = Resposta();

                if (acao == "arrancar") // $
                {
                    if (péDeCabra == 0) // $
                    {
                        Br();
                        Console.WriteLine(@$"
    Essa tábua está bem pregada!
    Talvez haja alguma ferramenta por aí 
    para te ajudar a remover a tábua...
                        
    Tente encontrar algo, VOLTAR é
    a opção por enquanto.");
                    }
                    else // $
                    {
                        Br();
                        Console.WriteLine(@$"
    Você tem um pé de cabra que conseguiu
    Naquela caixa de antes. Parece ótimo para
    se usar nesta tábua pregada.
                        ");

                        Br();
                        Cut();
                        Br();

                        Console.WriteLine($"Você entra no PORÃO");

                        fimTranquilo = true;
                        noPorao = true;
                        reset = true;
                    }
                }
                else if (acao == "voltar") // $
                {
                    noPorao = true;
                    Br();
                    Console.WriteLine($"Você volta no lugar de antes.");
                }
                else // $
                {
                    Br();
                    Invalido();

                    Console.WriteLine(@$"
    Tente ARRANCAR a tábua... Ou, sei lá, encontrar alguma coisa
    para arrancá-la... Encontre uma se você VOLTAR para o lugar de
    antes.");
                }
            } while (noPorao == false);

        }
        else if (resposta == "caixa") // $
        {
            Br();
            Console.WriteLine($"Você decide checar a CAIXA");
            Br();

            if (péDeCabra == 0) // $
            {
                Console.WriteLine(@$"
    É uma caixa média, do tamanho de uma criança mais ou menos,
    está pregada no chão. Você pensa que pode ter alguma coisa 
    lá dentro, mas, óbviamente, há uma tranca. E agora? Vai
    tentar ABRIR a tranca ou gostaria de VOLTAR para checar
    os outros lugares?
            
    ABRIR     VOLTAR
            ");
            }
            else // $
            {
                Console.WriteLine(@$"
    Estás na frente da mesma caixa... Já aberta...

    ABRIR     VOLTAR
                ");

            }



            bool naCaixa = false;
            do // $
            {
                string acao = Resposta();

                if (acao == "abrir") // $
                {
                    if (chaveVelha == 0) // $
                    {
                        Br();
                        Console.WriteLine(@$"
    Não dá para abrir o cadeado, parece que você precisará encontrar uma
    chave...
                        
    VOLTAR?
                        ");
                    }
                    else if (péDeCabra == 1) // $
                    {
                        Br();
                        Console.WriteLine(@$"
    A caixa já está aberta...
    Tipo, não há mais nada para fazer por aí...
                        
    VOLTAR?");
                    }
                    else // $
                    {
                        Br();
                        Console.WriteLine(@$"
    Você abre a tranca utilizando a chave que você adquiriu e abre
    aquela caixa. Você encontra um PÉ DE CABRA lá dentro. Pra quê um
    PÉ DE CABRA? Você não sabe... Ou sabe?
                        
    Você conseguiu um PÉ DE CABRA
                        
    VOLTAR?
                        ");

                        péDeCabra++;
                    }
                }
                else if (acao == "voltar") // $
                {
                    Br();
                    Console.WriteLine($"Você volta no lugar de antes.");

                    naCaixa = true;
                }
                else // $
                {
                    Br();
                    Invalido();

                    Console.WriteLine(@$"
    Você só pode tentar ABRIR a caixa, ou apenas VOLTAR para o lugar
    de antes...
                    ");

                }

            } while (naCaixa == false);


        }
        else if (resposta == "arbusto") // $
        {
            if (chaveVelha == 0) // $
            {
                Br();
                Console.WriteLine(@$"Você investiga o ARBUSTO");
                Br();
                Console.WriteLine(@$"
    Que esquisito, um arbusto que pode brilhar? Mas não é
    Algo natural. O arbusto em si está com uma pequena
    lâmpada acesa... Parece ser um tipo de esconderijo para
    alguma coisa e alguém deixou aquela luz para reconhecer
    o local. Sem problemas, descobres o que tem naquele
    esconderijo: uma CHAVE VELHA. para que essa chave? Não
    sabemos... Ainda... Ou sabemos?
    ");

                Br();
                Cut();
                Br();

                Console.WriteLine(@$"
Você obtém a CHAVE VELHA
    
Você volta para o lugar de antes
");

                chaveVelha++;
            }
            else // $
            {
                Br();
                Console.WriteLine(@$"
    Você já checou o arbusto!");
                Br();
                Cut();
                Br();
            }
        }
        else // $
        {
            Br();
            Invalido();

            Console.WriteLine(@$"
    Talvez se você fosse olhar o PORÃO... Ou checar a CAIXA...
    Ou saber por que raios aquele ARBUSTO parece brilhar...
    ");
        }

    } while (reset == false);

}



// I g n o r a n d o     a     c a b a n a
if (seguirCaminho == true) // $
{
    Console.WriteLine(@$"
    Você escolhe SEGUIR o caminho e ignorar a cabana.");
    Br();
    Console.WriteLine(@$"
    Você pensa consigo mesmo e reflete que não é viável se 
    arriscar, mesmo com a situação que está passando.
    
    MAS VALEU A PENA! Caminhando um pouco mais você vê um carro, que
    maravilha! Agora é só sair daquele lugar...
    
    Porém, ao seu aproximar, avistas a uma tranca de 18 números na
    porta do carro...
    
    Você precisa colocar uma senha para abri-la e escapar da
    floresta.");

    Br();
    Console.WriteLine($"Insira a senha: ");
    string resposta = Resposta();

    if (resposta == "385270614910") // $
    {
        finalCanonico = true;
    }
    else // $
    {
        fimChuvoso = true;
    }
}










// CAMINHO DA DIREITA










// F I M     D O     J O G O

// 38. 52. 70. 61. 49. 10.
// Final Canônico:
if (finalCanonico == true) // $
{
    Console.WriteLine(@$"
    A TRANCA ABRE!
    Você, naquele carro, sai da floresta e volta para algum lugar
    familiar. De quem é aquele carro? Não se sabe, mas parece ter sido
    abandonado por lá.

    Você retorna para casa e tudo volta a ser como era antes para você.

    Fim
    ");

    Br();
    Cut();
    Br();

    Console.WriteLine(@$"
    Baptista HookIt

    Esse foi um pequeno pré protótipo que eu criei com o intuito de
    treinar as minhas habilidades de desenvolvedor back-end. Não é o
    jogo mais bonito que você jogou. Mas mesmo assim, sou muito grato
    por você ter jogado ter chego até aqui, foi muito demorado para 
    terminar esse jogo :)

    Se você gostou ou não, não sei... Mas afirmo mesmo assim:

    OBRIGADO POR JOGAR  :)
    ");

    Br();
    Cut();
    Br();

    Console.WriteLine(@$"
    See you next project ;)
    ");
}





// CAMINHO DA ESQUERDA


// Final Chuvoso - Erre a senha final
if (fimChuvoso == true) // $
{
    Br();
    Console.WriteLine(@$"
    A tranca não abre.
    Agora, a chuva aumenta. Que pena, um carro para nada. Talvez se
    Você encontrasse a senha para abrir aquela tranca.
    
    Mas antes de você pensar em fazer alguma coisa, você sente que algo
    está te observando. Ao perceber isso, tentas correr, mas suas 
    energias estão gastas faz muito tempo.

    Naquela noite, fria, assustadora e chuvosa, parece que é onde
    se encontra o seu final...

    GAME OVER

    38----------
    ");
}
// Final do Urso - Seja atacado pelo urso
if (fimUrso == true) // $
{
    Br();
    Console.WriteLine($@"
    Que estranho... A casa está acesa, parece até que alguém estava
    ali agora pouco... Não importa, você fecha a porta e vai descansar.

    Porém, seu descanso cessa ao ouvir a porta se abrindo com força,
    e o que você vê não é algo bom. Um urso extremamente grande e
    que não gostou da sua presença. 
    
    O animal te ataca. Enfim, Agora dá para saber o que aconteceu com
    o real morador daqui...
    
    GAME OVER
    
    --52--------");
}
// Final Tranquilo - Encontre a entrada do porão
if (fimTranquilo == true) // $
{
    Br();
    Console.WriteLine(@$"
    Agora você está dentro do lugar, e parece ser uma área tranquila.
    O fato de não estar na chuva é algo muito bom. Fechas a porta do
    porão para teres um pouco de descanso. Encontras um pequeno estoque
    de suprimentos, comida, água, e se sustenta com isso. Agora é só
    relaxar no porão até amanhecer... E até que esse porão não é tão
    desconfortável assim.
    ");

    Br();
    Cut();
    Br();

    Console.WriteLine($@"
    GAME OVER
    (sim, esse ainda não é o final verdadeiro)
    
    ----70------
    ");
}









// CAMINHO DA DIREITA


// Final Escuro - Caia no abismo
if (fimEscuro == true) // $
{
    Br();

    Console.WriteLine(@$"
    Você anda pelo caminho escuro. Sente que é um lugar úmido... Mas
    o que importa mesmo é que aquele lugar é um breu só.
    ");

    Br();
    Cut();
    Br();

    Console.WriteLine(@$"
    Você sente dar um piso em falso, e cai, na onde? Você não sabe.
    Não.. Não pode ser
    Você achou que ia ser apenas um pequeno buraco que pisou errado...
    MAS..

    PARECE QUE SUA QUEDA NÃO TEM FIM
    ");
    Br();
    Cut();

    Console.WriteLine($"EI");

    Br();
    Cut();

    Console.WriteLine($"ESCUTE, SE ACALME!");

    Br();
    Cut();

    Console.WriteLine($"ISSO NÃO É UM BURACO SEM FUND-");

    Br();
    Cut();

    Console.WriteLine(@$"
    888888888888    888      888    888         888
    888888888888    888      888    8888       8888
        888         888      888    88888     88888
        888         888      888    888888   888888
        888         888      888    888 888 888 888
        888         888      888    888  88888  888
        888         888      888    888   888   888
        888         888      888    888         888
        888         888888888888    888         888
        888         888888888888    888         888
    ");

    Br();
    Cut();

    Console.WriteLine($@"
    ÉH...
    
    Acho que seria melhor se você tivesse uma lanterna ou algo do tipo
    afinal...
    
    
    GAME OVER
    (tava muito óbvio que isso aconteceria...)
    
    ------61----
    ");

}
// Final Explosivo - Exploda a você mesmo
if (fimExplosivo == true) // $
{
    Console.WriteLine(@$"
    888888888888    888888888888    888888888888    888      888
    888888888888    888888888888    888888888888    88888  88888
    888      888    888      888    888      888    888888888888
    888      888    888      888    888      888    888  88  888
    888     888     888      888    888      888    888      888
    88888888        888      888    888      888    888      888
    888     888     888      888    888      888    888      888
    888      888    888      888    888      888    888      888
    888      888    888      888    888      888    888      888
    888888888888    888888888888    888888888888    888      888
    888888888888    888888888888    888888888888    888      888
    ");

    Console.WriteLine($"    Você explode a pe-");

    Br();
    Cut();
    Br();

    Console.WriteLine($"    Deixa para lá, você explodiu junto");

    Br();
    Cut();
    Br();

    Console.WriteLine($"GAME OVER");
    Console.WriteLine($"(tenta na próxima vez não explodir a bomba diretamente!)");

    Br();

    Console.WriteLine($"--------49--");
}
// Final do Reetorno - Tenha a ajuda do caçador
if (fimCacador == true) // $
{
    Console.WriteLine(@$"
    Você explode a pedra. Porém, o lugar começa a querer desabar, a
    explosão foi mais forte do que você pensou que seria... Não
    importa, é hora de CORRER.
    ");

    Br();
    Cut();
    Br();

    Console.WriteLine(@$"
    Você corre, sobe para onde veio antes da pedra ter caído. Agora que
    o lugar desabou, escutas uma voz:

    - Ei, você está bem?

    Trata-se de um caçador, mas parece que estava retornando de onde
    estava vindo.

    - Caramba! O lugar inteiro desabou! Mas se acalme. Eu moro no lado
    Oeste dessa floresta. É melhor ficar por lá até amanhecer...

    Você aceita a proposta e vai com o caçador, que a propósito foi bem
    recipitivo, e no outro dia, te levou para fora da floresta.

    Esse final foi realmente muito bom.
    MAS...
    ");

    Br();
    Cut();
    Br();

    Console.WriteLine($"GAME OVER");
    Console.WriteLine($"Acredite, acredite... esse não é o final verdadeiro...");

    Br();
    Console.WriteLine($"----------10");


}





// S H O R T C O D E S
static string Resposta()
{
    return Console.ReadLine()!.ToLower();
}

static string Br()
{
    Console.WriteLine($"");
    return "";
}

static void Invalido()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(@$"Você não tem essa opção");
    Console.ResetColor();
}

void Cut()
{
    Br();
    Console.WriteLine($"Pressione qualquer botão para continuar");
    Console.ReadLine();
    Br();
}