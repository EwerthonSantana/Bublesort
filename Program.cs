using Dio.Helper;
using System;

namespace Dio
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] { 6, 10, 4, 7, 1 };

            Console.WriteLine("Array Original:");
            op.ImprimirArray(array);

            op.OrdenarBubleSort(array);

            Console.WriteLine("Array Ordenado:");
            op.ImprimirArray(array);     

        }
    }
}
