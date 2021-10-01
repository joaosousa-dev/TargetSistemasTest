using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace TesteTarget
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                //não foi feito validação 
                int option;
                Console.Clear();
                Console.WriteLine("Escolha uma opção\n");
                Console.WriteLine("DIGITE 1 PARA QUESTÃO 1\n" +
                    "DIGITE 2 PARA QUESTÃO 2\n" +
                    "DIGITE 3 PARA QUESTÃO 3\n" +
                    "DIGITE 4 PARA QUESTÃO 4\n" +
                    "DIGITE 5 PARA QUESTÃO 5");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {

                    case 1:
                        questao1();
                        break;
                    case 2:
                        questao2();
                        break;
                    case 3:
                        questao3();
                        break;
                    case 4:
                        questao4();
                        break;
                    case 5:
                        questao5();
                        break;
                    default:
                        Console.WriteLine("Insira um valor válido");
                        Console.ReadKey();
                        break;
                }
            }
        }
        public static void questao1()
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }
            Console.WriteLine("SOMA = " + SOMA);
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
        public static void questao2()
        {
            int num1 = 0, num2 = 1, aux, numeroinformado;
            Console.WriteLine("informe o numero que deseja saber se faz parte de fibonacci");
            numeroinformado = int.Parse(Console.ReadLine());

            for (int i = 0; num2 < numeroinformado; i++)
            {
                aux = num1;
                num1 = num2;
                num2 = num1 + aux;
                Console.WriteLine(num2);

            }
            if (numeroinformado == num2)
            {
                Console.WriteLine(numeroinformado + " Pertence a fibonacci");
            }
            else
            {
                Console.WriteLine(numeroinformado + " Não pertence a fibonacci");
            }
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();

        }
        public static void questao3()
        {

            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"/dados.json");

            var js = new DataContractJsonSerializer(typeof(List<Dados>));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var dados = (List<Dados>)js.ReadObject(ms);

            double maior = 0, menor = 99999999, diaMaior = 0, diaMenor = 0, totalpmes = 0;
            for (int i = 0; i < 30; i++)
            {
                if (dados[i].valor > 0)
                    totalpmes += dados[i].valor;
            }

            double mediamensal = totalpmes / 30;
            for (int i = 0; i < 30; i++)
            {
                if (dados[i].valor > maior)
                {
                    maior = dados[i].valor;
                    diaMaior = dados[i + 1].dia;
                }
            }
            for (int i = 0; i < 30; i++)
            {
                if (dados[i].valor < menor)
                {
                    menor = dados[i].valor;
                    diaMenor = dados[i + 1].dia;
                }

            }
            int count = 0;
            for (int i = 0; i < 30; i++)
            {
                if (dados[i].valor > mediamensal)
                {
                    count++;
                }
            }
            Console.WriteLine("O maior faturamento foi de: {0} dia {1}", maior, diaMaior);
            Console.WriteLine("O menor faturamento foi de: {0} dia {1}", menor, diaMenor);
            Console.WriteLine("A média de faturamento por mes é: " + mediamensal);
            Console.WriteLine("Foram {0} dias que o faturamento foi maior que a media mensal de {1}", count, mediamensal);
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();


        }
        public static void questao4()
        {
            decimal rj = 36678.66M, mg = 29229.88M, sp = 67836.43M, es = 27165.48M, outros = 19849.53M;
            decimal total = rj + sp + mg + outros + es;
            Console.WriteLine("Percentual de faturamento de:\n" +
                "RJ é : " + decimal.Round(rj / total * 100, 2) + "% \n" +
                "MG é : " + decimal.Round(mg / total * 100, 2) + " % \n" +
                "ES é : " + decimal.Round(es / total * 100, 2) + "% \n" +
                "SP é : " + decimal.Round(sp / total * 100, 2) + "% \n" +
                "outros estados é : " + decimal.Round(outros / total * 100, 2) + "% de um total de : " + total + "R$");
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
        public static void questao5()
        {
            //Sem a função reverse
            string original = "Teste para target sistemas";
            char[] inversoArray=original.ToCharArray();
            char[] originalArray = original.ToCharArray();
            int lenght = int.Parse(originalArray.Length.ToString());
            for (int i = 0; lenght>0; i++)
            {
                inversoArray[i] = originalArray[lenght - 1];
                lenght--;
            }
            Console.WriteLine(inversoArray); ;
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();

        }
    }
}
