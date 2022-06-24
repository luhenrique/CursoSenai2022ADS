        string Adicao()
        {
            Console.WriteLine("Digite o primero valor da soma:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor da soma:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            return $"O resultado é {num1 + num2}";
        }

        string Subtracao()
        {
            Console.WriteLine("Digite o primero valor da subtração:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor da subtração:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            return $"O resultado é {num1 - num2}";
        }

        string Multiplicacao()
        {
            Console.WriteLine("Digite o primero valor da multiplicação:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor da multiplicação:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            return $"O resultado é {num1 * num2}";
        }

        string Divicao()
        {
            Console.WriteLine("Digite o divisor:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o dividendo:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("Não pode dividir um numero por 0");
                //break; VOLTAR AQUI
            }
            return $"O resultado é {num1 / num2}";
        }

        string Fatorial()
        {
            Console.WriteLine("Digite numero que deseja fatorar:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double result = 1;
            while (num1 != 1)
            {
                result *= num1;
                num1--;
            }
            return $"O resultado do fatorial é: {result}";
        }

        string Potenciacao()
        {
            Console.WriteLine("Digite o base:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o expoente:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = 1;
            for (int i = 1; i <= num2; i++)
            {
                result *= num1;
            }
            return $"O resultado é {result}";
        }

        int menu()
        {
            Console.WriteLine("===========CALCULADORA C#================");
            Console.WriteLine("=======SELECIONE A OPÇÃO DESEJADA========\n" +
                                    "Opções:\n" +
                                    "1 - Adição\n" +
                                    "2 - Subtração\n" +
                                    "3 - Multiplicação\n" +
                                    "4 - Divisão\n" +
                                    "5 - Fatorial\n" +
                                    "6 - Potenciação\n" +
                                    "7 - Sair\n");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        void opcao(int op)
        {
            switch(op){
                case 1:
                    Console.WriteLine(Adicao());
                    Console.ReadKey();
                    break;
                case 2:
                   Console.WriteLine(Subtracao());
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine(Multiplicacao());
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine(Divicao());
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine(Fatorial());
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine(Potenciacao());
                    Console.ReadKey();
                    break;
                case 7:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine($"Valor invalido, selecione uma operação do menu!");
                    break;

            }
        }


        int op = 0;
        do{
            opcao(op = menu());

        }while(op!=7);


