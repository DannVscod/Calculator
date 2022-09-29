    using System;
    namespace Calculator

    {

        class Program 
        {
    static void Main(string[] args)
        {
            menu();


        }
        static void menu(){
            Console.Clear();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - sair");
            

            Console.WriteLine("--------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());
            switch(res){
                case 1: soma(); break;
                case 2: subtracao(); break;
                case 3: divisao(); break;
                case 4: multiplicacao(); break;
                case 5: System.Environment.Exit(0);break;
                default: menu();break;

            }

        }
        static void soma(){
            Console.Clear();
        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("segundo valor:");
        float v2 = float.Parse(Console.ReadLine());
        Console.WriteLine("");
        float resultado = v1 + v2;
        Console.WriteLine("O resuldado da soma é " + resultado );
        Console.ReadKey();
        menu();

        // Console.WriteLine($"O resultado da soma é {resultado}");
        // Console.WriteLine($"O resultado da soma é " + (v1 + v2) );
        }

        static void subtracao(){
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 - v2;
            Console.WriteLine($"o resultado da subtração é: {resultado}");
            Console.ReadKey();
            menu();


            
        }
    
        static void divisao (){
            Console.Clear();
            Console.WriteLine("Primeiro valor é : ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor é : ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float resultado = v1/v2;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            menu();

        }
        static void multiplicacao(){
            Console.Clear();
            Console.WriteLine("Primeiro valor é : ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor é : ");
        
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine ("");
        
            float resultado = v1*v2;
        
            Console.WriteLine($"resultado da multiplicação é {resultado}");
            Console.ReadKey();
            menu();


        }

        }

    }

