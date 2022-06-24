/*
    ---------ESTRUTURA SWITCH(ESCOLHA-CASO)-----------
    SINTAXE
        SWITCH(CONDIÇÃO){
            CASE 1: 
                AÇÃO
            CASE 2:
                OUTRA AÇÃO
            DEFAULT:
                OUTRA AÇÃO
        }
*/
    string opcao;
    Console.WriteLine("Escolha uma opção:");
    opcao = Console.ReadLine();

    switch(opcao){
        case "sim":
            Console.WriteLine("Falou sim");
            break;
        case "nao":
            Console.WriteLine("Falou não");
            break;
        case "talvez":
            Console.WriteLine("Falou talvez");
            break;
        default:
            Console.WriteLine("Falou " + opcao);
            break;
    }
