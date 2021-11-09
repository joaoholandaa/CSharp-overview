using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            //PRINT
            Console.WriteLine("Hello World!"); //ou \n
            Console.WriteLine("Meu nome é João Pedro Holanda");

            //VARIÁVEIS
            /*Int = inteiro ----> -123 ou 123
            Float = decimais ----> -12.3 ou 12.3
            Bool = booleanos ----> true(verdadeiro) ou false(falso)
            String = conjunto de caracteres "eu gosto de maçã"
            Char = um único caractere "a"*/

            int anoLancamentoAtari = 1977; /*não pode haver espaços entre os nomes das variáveis,
                                             nem caracteres especiais, exceto "_", e nem números no começo,
                                             como tambémo nomes reservados pelo C# como: class e using.*/

            string cor_favorita = "Azul";   /*não pode declarar variável do tipo string sem aspas duplas,
                                             como também não podemos modificar seu tipo.*/

            float velocidadeF1 = 280.50f;   /*necessario uso do "f" ao final do numero para explicitar
                                             que é do tipo float*/

            bool anoLancouAtari = true;     /*nao pode haver variáveis com mesmo nome que pertencem 
                                             ao mesmo escopo*/

            Console.WriteLine(anoLancamentoAtari);
            Console.WriteLine(cor_favorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(anoLancouAtari);

            velocidadeF1 = 350.10f; //mudança do valor da variável
            cor_favorita = "Preto";

            Console.WriteLine(velocidadeF1);
            Console.WriteLine(cor_favorita);

            var anoNintendo = 1985;  //Forma diferente de declarar variáveis(não usual)

            //anoNintendo = "mil novecentos e cinquenta e cinco"; *AINDA NÃO PODEMOS MUDAR SEU TIPO

            dynamic anoMegaDrive = 1992; //Não recomendavel 

            Console.WriteLine(anoMegaDrive);

            anoMegaDrive = "mil novecentos e noventa e dois";

            Console.WriteLine(anoMegaDrive);

            //CONSTANTES

            const float PI = 3.14159f; //não podemos mudar o valor da constante
                                       //PI = 3.14; *codigo apresentará erro

            string nome = "";
            Console.WriteLine("Digite o ano em que você nasceu: ");
            nome = Console.ReadLine();
            // ou string nome = Console.ReadLine();

            Console.WriteLine("O ano em que você nasceu é: ");
            Console.WriteLine(nome);

            //OPERADORES ARITMETICOS

            int numeroSoma = 20 + 20 - 15;
            int numeroMult = 5 * 5;
            float numeroDiv = 18f / 5; // 5/5 = 1 (int), 5/2 = 2.5 (float)
            int teste = 2 + 2 * 10; // multiplicação e divisão sempre tem prioridade, assim como os parenteses

            Console.WriteLine(numeroSoma);
            Console.WriteLine(numeroMult);
            Console.WriteLine(numeroDiv);
            Console.WriteLine(teste);

            // OPERADORES CONDICIONAIS E LOGICOS

            int num1 = 10;
            int num2 = 20;
            int num3 = 30;

            // > , < , >=, <=, ==, != (CONDICIONAIS)

            // && (E OU AND) e || (OU/OR) (LOGICOS)

            //*&&
            // TRUE && TRUE --> TRUE
            // FALSE && FALSE --> FALSE
            // TRUE && FALSE --> FALSE
            // FALSE && TRUE --> FALSE

            //*||
            // TRUE || TRUE --> TRUE
            // FALSE || FALSE --> FALSE
            // TRUE || FALSE --> TRUE
            // FALSE || TRUE --> TRUE

            if (num2 > num1 || num2 > num3) //SE 
            {
                Console.WriteLine("Sim, é verdade");
            }
            else if (num1 == num2) //MAS, SE
            {
                Console.WriteLine("Sim, são iguais");
            }
            else //SENÃO
            {
                Console.WriteLine("Não, é falso");
            }

            //OPERADORES LOGICOS NA PRATICA

            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Você é uma criança");
            }
            else if (idade >= 12 && idade <= 17)
            {
                Console.WriteLine("Você é um adolescente");
            }
            else if (idade >= 18 && idade <= 59)
            {
                Console.WriteLine("Você é um(a) adulto(a)");
            }
            else
            {
                Console.WriteLine("Você é um(a) idoso(a)");
            }

            //FUNÇÕES
            ExibirMsg();
            ExibirMsg();
            GerarPreco("pac man", 25);

            //RETORNO DE FUNÇÕES
            string colecao1 = Jogos("megaman-", " zelda-", " alex kidd");
            string colecao2 = Jogos("top gear-", " pac man-", " mario kart");
            Console.WriteLine(colecao1);
            Console.WriteLine(colecao2);

            //ARRAY
            string produto1 = "World of Tanks";
            string produto2 = "PUBG";
            string produto3 = "Free Fire";
            string produto4 = "FIFA";
            string produto5 = "Minecraft";

            string[] produtos = new string[5]
            {
                "World of Tanks", //0
                "PUBG", //1
                "Free Fire", //2
                "FIFA", //3
                "Minecraft", //4
            };

            int[] valores = { 1, 2, 3, 4, 5 }; //outra forma de criar array


            produtos[3] = "FIFA 2021"; //atualizando valores da lista
            Console.WriteLine(produtos[3]); //acesso a qualquer elemento da lista
            Console.WriteLine(valores[0]);

            //SWITCH
            string cor = "Azul";

            switch (cor)
            {
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho!");
                    break;

                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é amarelo!");
                    break;

                case "Azul":
                    Console.WriteLine("Sua cor favorita é azul!");
                    break;

                default: //caso a cor não seja a que foi definida na variável
                    Console.WriteLine("Sua cor favorita não foi identificada!");
                    break;

                    /* 
                    string cor = "Azul";

                    if (cor == "Vermelho")
                    {
                        Console.WriteLine("Sua cor favorita é vermelho!");
                    }
                    else if (cor == "Amarelo")
                    {
                        Console.WriteLine("Sua cor favorita é amarelo!");
                    }
                    else if (cor == "Azul")
                    {
                        Console.WriteLine("Sua cor favorita é azul!");
                    }

                    */

            }

            //ENUM
            Cor corFavoritaPlayer1 = Cor.AMARELO;
            Console.WriteLine((int)corFavoritaPlayer1); //retorno do index ou da cor
            

            //ESTRUTURAS DE REPETIÇÃO

            //WHILE
            int contador = 0;
            while (contador < 10) //enquanto for verdade faça (loop infinito)
            {
                Console.WriteLine("Rodando o While!");
                contador = contador + 1; //irá fazer o código sair do loop infinto 
            }
            Console.WriteLine("fim do loop");

            //FOREACH
            string[] amigos = { "João", "Lucas", "Maria", "Lúcia" };

            foreach (string amigo in amigos) //para cada palavra no array palavras, repita o bloco de código
            {
                Console.WriteLine(amigo); //imprime todas os itens dentro do array
            }

            //FOR
            string[] amigos1 = { "João", "Lucas", "Maria", "Lúcia" };
            for (int contador1 = 0; contador1 < amigos1.Length; contador1++)
            {
                Console.WriteLine(contador1);
                Console.WriteLine(amigos[contador1]);
            }

            Console.ReadLine();

        }

        //FUNÇÕES
        static void ExibirMsg()
        {
            Console.WriteLine("Esse código é legal");
            Console.WriteLine("Estou usando funções");
            Console.WriteLine("Bem-vindo");
        }

        static void GerarPreco(string nome, int preco)
        {
            Console.WriteLine("Nome do jogo: " + nome);
            Console.WriteLine("Valor do jogo: " + preco);
        }

        //RETORNO DE FUNÇÕES

        static string Jogos(string jogo1, string jogo2, string jogo3)
        {
            string resultadoFinal = (jogo1 + jogo2 + jogo3);
            return resultadoFinal;
        }

       //ENUM
       enum Cor { AZUL, VERDE, AMARELO };
    }
}
