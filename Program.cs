using System;

namespace UsandoSwitchCaseMes
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = 0;
         


            Console.WriteLine("Por favor digite o numero do mês que deseje saber a quantidade de dias");
            Console.WriteLine("Caso não saiba o numero do mês que deseje saber digite 0 para ajuda");

            mes = Convert.ToInt32(Console.ReadLine());



            switch (mes)
            {
                case 1:
                    Console.WriteLine("Janeiro tem 31 dias");
                    break;

                case 2:
                    Console.WriteLine("Fevereiro tem 28 ou 29 dias");
                    break;

                case 3:
                    Console.WriteLine("Março tem 31 dias");
                    break;

                case 4:
                    Console.WriteLine("Abril tem 30 dias");
                    break;

                case 5:
                    Console.WriteLine("Maio tem 31 dias");
                    break;

                case 6:
                    Console.WriteLine("Junho tem 30 dias");
                    break;

                case 7:
                    Console.WriteLine("Julho tem 31 dias");
                    break;

                case 8:
                    Console.WriteLine("Agosto tem 31 dias");
                    break;

                case 9:
                    Console.WriteLine("Setembro tem 30 dias");
                    break;

                case 10:
                    Console.WriteLine("Outubro tem 31 dias");
                    break;

                case 11:
                    Console.WriteLine("Novembro tem 30 dias");
                    break;

                case 12:
                    Console.WriteLine("Janeiro tem 31 dias");
                    break;

                case 0:
                    Console.WriteLine("Janeiro = 1");
                    Console.WriteLine("Fevereiro = 2");
                    Console.WriteLine("Março = 3");
                    Console.WriteLine("Abril = 4");
                    Console.WriteLine("Maio = 5");
                    Console.WriteLine("Junho = 6");
                    Console.WriteLine("Julho = 7");
                    Console.WriteLine("Agosto = 8");
                    Console.WriteLine("Setembro = 9");
                    Console.WriteLine("Outubro = 10");
                    Console.WriteLine("Novembro = 11");
                    Console.WriteLine("Dezembro = 12");
                    Console.WriteLine("Depois de localizar o mês desejado reinicie a aplicação");
                    break;

                default:
                    Console.WriteLine("Por favor digite um numero valido");
                    break;


            }

        }
    }
}
