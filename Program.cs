using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                    default:
                        Console.WriteLine("Insira um valor válido");
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
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var path = Environment.CurrentDirectory;
            var arquivo = Directory.GetParent(path);
            using (StreamReader r = new StreamReader(arquivo + @"\dados.json"))
            {
                string json = r.ReadToEnd();
                dynamic array = serializer.DeserializeObject(json);
                Console.WriteLine("");
                Console.WriteLine(serializer.Serialize(array));
                Console.WriteLine("");
                Console.WriteLine("MAIOR VALOR : " + json.Count());

                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.ReadKey();

            }
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

        }
    }
}
