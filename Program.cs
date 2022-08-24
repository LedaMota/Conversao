using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Conversao Implicita  ok #

            //byte num1 = 100; // 8 bits de 0 a 255

            //ushort num2; // 16 bits 0 a 65.535

            //float num3 = 1250.45f;
            //double num4 = num3;

            //num3 = num1;
            //num2 = num1;
            //Aqui ele converte a posição ASNCI o caractere c de string para inteiro fazendo uma conversão implicita
            //int numero = 'c';

            //Console.WriteLine(numero);
            //Console.ReadKey();

            #endregion

            #region  Tipos Numericos explicitas ok # 

            //ushort num1 = 500;
            //byte num2 = (byte)num1;

            //float num3 = 2500f;
            //int num4 = (int)num3;

            //char letra = (char)97;

            //Console.WriteLine(letra);
            //Console.ReadKey();

            #endregion

            #region Metodo Parse

            //String txtNumero = "1985";

            //int numero = int.Parse(txtNumero);

            //byte num1 = byte.Parse("120");
            //double num2 = double.Parse("125626,57");

            //float num3 = float.Parse("457,75");

            //Console.WriteLine(num3);
            //Console.ReadLine();

            #endregion

            #region Tipo Clase Convert  não passou

            //Aqui a classe convert está declarada de maneira erra e também a sua conversão favor corrigir e testar
            string texto = convert.tostring(2500);
            double num1 = convert.todouble(false);

                        int num2 = convert.toint32('c');

            //Console esta escrito errado favor corrigir
            console.writeline(num2);
            console.readline();

            #endregion

        }
    }
}
