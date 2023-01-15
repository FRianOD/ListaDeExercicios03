using System;
using System.Globalization;

namespace ListaDeExercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema 0 = Senha

            int senha = 2002, tentativa = 0;

            while (true)
            {
                tentativa = int.Parse(Console.ReadLine());

                if (tentativa == senha) 
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                } else
                {
                    Console.WriteLine("Senha Invalida");
                }
            }
            //Problema 1 = Coordenadas

            int x = 0, y = 0;

            while (true) 
            {
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                if (x== 0 || y == 0) {break;}
                else if (x > 0 && y > 0) { Console.WriteLine("Primeiro quadrante"); }
                else if (x < 0 && y > 0) { Console.WriteLine("Segundo quadrante"); }
                else if (x < 0 && y < 0) { Console.WriteLine("Terceiro quadrante"); }
                else if (x > 0 && y < 0) { Console.WriteLine("Quarto quadrante"); }

            }
            
            //Problema 2 = Posto de gasolina

            int alcool = 0, gasolina = 0, disel = 0, escolha ;

            while (true)
            {
                escolha = int.Parse(Console.ReadLine());
                if (escolha == 1) { alcool += 1; }
                else if (escolha == 2) { gasolina += 1; }
                else if (escolha == 3) { disel += 1; }
                else if (escolha == 4) { break; }
            }
            Console.WriteLine($"Muito Obrigado!\nAlcool = {alcool}\nGasolina = {gasolina}\nDisel = {disel}");
        }
    }
}