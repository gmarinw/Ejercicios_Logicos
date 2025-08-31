using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
        static void FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            //int[] n1 = { 1, 3 };
            //int[] n2 = { 2 };
            // int[] n1 = { 1, 2 };
            //int[] n2 = { 3, 4 };
            //int[] n1 = { 5, 3, 1 };
            //int[] n2 = { 2, 4 };

            int[] ans = nums1.Concat(nums2).OrderBy(x => x).ToArray();
            int n = ans.Length;
            decimal medianSorted;
            if (n % 2 != 0)
            {
                medianSorted = ans[n / 2];
                decimal median = n / 2;
                int a = n / 2;
            }
            else
                medianSorted = Decimal.Divide((ans[n / 2] + ans[(n - 1) / 2]), 2);
            Console.WriteLine(medianSorted);
            //return Convert.ToDouble(medianSorted);
        }

        static void IsPalindrome(int x)
        {
            //12321
            string str = x.ToString();
            for (int i = 0; i < (str.Count() / 2); i++)
            {
                int n = str[str.Count() - 1 - i];
                if (str[i] != str[str.Count() - 1 - i])
                {
                    Console.Write("No es palindromo");
                }
            }
            Console.Write("Es palindromo");
        }

        static void ordenamientoNumeros(int num)
        {
            char[] charNums = num.ToString().ToCharArray();
            int[] arrNums = new int[charNums.Length];
            for (int i = 0; i < charNums.Length; i++)
            {
                arrNums[i] = charNums[i] - '0';
            }
            int[] ordernums = arrNums.OrderByDescending(x => x).ToArray();
            Console.WriteLine(string.Join(" ", ordernums));
        }
        static void LengthOfLongestSubstring(string s)
        {
            //pwwkew
            char[] chars = new char[s.Length];
            char[] schar = s.ToCharArray();
            int longest = 0;
            int k = 0;
            for (int j = 0; j < schar.Length; j++)
            {
                bool b = chars.Any(x => x == s[j]);
                if (b)
                {
                    if (longest < k)
                    {
                        longest = k;
                    }
                    k = 0;
                }
                chars[k] = schar[j];
                k++;

            }
            Console.WriteLine(longest);
        }

        static void ReverseName()
        {
            string nombre = "gisel";
            char[] str = nombre.ToCharArray();
            char[] n = str.Reverse().ToArray();
            Console.WriteLine(string.Join(", ", n));
        }

        static void LongestPalindrome(string s)
        {

        }

        static void ControlAcceso()
        {
            int intentos = 0;
            int us, pass;
            do
            {
                Console.WriteLine("Ingrese su usuario");
                us = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese su contraseña");
                pass = Convert.ToInt32(Console.ReadLine());
                if (us != 12 || pass != 1234)
                {
                    Console.WriteLine("Error de inicio de sesión");
                    intentos++;
                }
                else
                    Console.WriteLine("Usuario válido");

            }
            while ((us != 12 || pass != 1234) && intentos != 3);
            if (intentos == 3)
            {
                Console.WriteLine("Muchos intentos...");
            }
        }

        void DivisionConResto()
        {
            int n1, n2, resto = 0;
            double result = 0;

            Console.WriteLine("Ingrese el primer numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 != 0)
            {
                do
                {
                    Console.WriteLine("Ingrese el segundo numero");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    if (n2 == 0)
                    {
                        Console.WriteLine("No se puede dividir entre 0");
                    }
                } while (n2 == 0);
                result = n1 / n2;
                resto = n1 % n2;
                Console.WriteLine($"El resultado de la divisón es {result} y el resto es {resto}");
            }
            else
                Console.WriteLine("BYE...");
        }

        void Multiplicacion()
        {
            Console.WriteLine("Ingrese el primer numero");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i = x; i <= y; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int res = i * j;
                    Console.WriteLine($"{i}x{j}={res}");
                }
                Console.WriteLine();
            }
        }

        void NotasAlumno()
        {
            Console.WriteLine("Ingrese su nota de alumno");
            double nota = Convert.ToDouble(Console.ReadLine());

            switch (nota)
            {
                case 10:
                    Console.WriteLine("Matrícula de honor");
                    break;
                case 9:
                    Console.WriteLine("Sobresaliente");
                    break;
                case 7.8:
                    Console.WriteLine("Notable");
                    break;
                case 6:
                    Console.WriteLine("Bien");
                    break;
                case 5:
                    Console.WriteLine("Aprobado");
                    break;
                default:
                    Console.WriteLine("Suspenso");
                    break;
            }
        }

        void RangoNumeros()
        {
            Console.WriteLine("Ingrese n1");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese n2");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = n1; i <= n2; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            int j = n1;
            while (j <= n2)
            {
                Console.WriteLine(j);
                j++;
            }
            int k = n1;
            Console.WriteLine();
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k <= n2);
        }

    }
}
