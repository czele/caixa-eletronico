using System;

namespace caixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor.");

            int valor = Convert.ToInt32(Console.ReadLine());

            int saldo = valor;

            int qt100 = 0;
            int qt50 = 0;
            int qt20 = 0;
            int qt10 = 0;
            int qt5 = 0;
            int qt2 = 0;


            while (saldo >= 0)
            {
                if ((saldo - 100) > 0)
                {
                    saldo -= 100;
                    qt100++;
                }
                else
                {
                   
                    if ((saldo - 50) > 0)
                    {
                        saldo -= 50;
                        qt50++;
                    }
                    else
                    { 
                        if ((saldo - 20) > 0)
                        {
                            saldo -= 20;
                            qt20++;
                        }
                        else
                        {
                            if ((saldo - 10) > 0)
                            {
                                saldo -= 10;
                                qt10++;
                            }
                            else
                            {
                                if ((saldo - 5) > 0)
                                {
                                    saldo -= 5;
                                    qt5++;
                                }
                                else
                                {
                                    if ((saldo - 2) > 0)
                                    {
                                        saldo -= 2;
                                        qt2++;
                                    }
                                    if (saldo == 1)
                                    {
                                        break;
                                    }
                                }
                            }
                   
                        }
                   
                    }          

                   
                
               
                }
            }

            if (qt100 > 0)
            {
                Console.WriteLine($"{qt100}x R$100,00.");
            }
            if (qt50 > 0)
            {
                Console.WriteLine($"{qt50}x R$50,00.");
            }
            if (qt20 > 0)
            {
                Console.WriteLine($"{qt20}x R$20,00.");
            }
            if (qt10 > 0)
            {
                Console.WriteLine($"{qt10}x R$10,00.");
            }
            if (qt5 > 0)
            {
                Console.WriteLine($"{qt5}x R$5,00.");
            }
            if (qt2 > 0)
            {
                Console.WriteLine($"{qt2}x R$2,00.");
            }
        }
    }
}
