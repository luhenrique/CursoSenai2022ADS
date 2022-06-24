/*VETORES E MATRIZES -> ARRAY
    VETORES == ARRAY UNIDIMENSIONAL
    MATRIZ == ARRAY MULTIDIMENSIONAL

        SINTAXE
            TIPO[] NOMEVARIAVEL
*/
// VETORES OU ARRAY UNIDIMENSIONAL

        string[] carros = { "gol", "golf", "opala" }; //sintaxe de atribuição direta
        string[] carros2 = new string[5]; //sitaxe para atribuição posterior 

        int[] numeros = new int[4];

        numeros[0] = 1;
        numeros[1] = 4;
        numeros[2] = 5;
        numeros[3] = 14;

        Console.WriteLine(numeros.Max()); //retorna o maior valor do array
        Console.WriteLine(numeros.Min()); //retorna o menor valor do array
        Console.WriteLine(numeros.Sum()); //retorna a soma dos valores do array
        Console.WriteLine(numeros.Average()); //retorna a media dos valores do array
        Console.WriteLine(numeros.Length); //retorna o tamanho do vetor

        //----------------------------------------
        //MATRIZES OU ARRAYS MULTIDIMENSIONAIS

        int[,] matriz = { { 1, 2 }, { 3, 4 }, { 5, 6 } }; //sintaxe de declaração direta 2x2 - 2d
        int[,] matriz2 = new int[2, 2]; //sintaxe declação matrix - 2d
        int[,,] matriz3d = { { { 2, 3, 4 }, { 5, 7, 1 }, { 30, 50, 90 } } }; //não é usual em projetos conveicionais
        int[,,] matriz3d2 = new int[3, 3, 3]; //não é usual em projetos conveicionais

        Console.WriteLine(matriz3d.Length); //retorna o tamanho do vetor

        //LAÇO FOREACH
        /*
            foreach(tipoDoArray controle in nomeDoArray)
        */
        foreach (string i in carros)
        {
            Console.WriteLine(i);
        }

        string[] nomes = new string[5];

        foreach(string i in nomes){
            Console.WriteLine(i);
        }
