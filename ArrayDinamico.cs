using System;

namespace ArrayDinamico
{
    class Program
    {
        public class ArrayDinamico
        {
            private int _i = 0;
            private int[] _array = new int[10];

            public int Add(int item)
            {
                _array[_i] = item;
                _i++;
                if (_i == _array.Length) { DobrarTamanhoArray(); }
                return _i - 1;
            }
            public int Get(int posicao) { return _array[posicao]; }
            private void DobrarTamanhoArray()
            {
                int[] novoArray = new int[_array.Length * 2];
                for (int i = 0; i < _array.Length * 2; i++)
                {
                    novoArray[i] = _array[i];
                }
                _array = novoArray;
            }
        }
        static void Main(string[] args)
        {
            ArrayDinamico A1 = new ArrayDinamico();
            A1.Add(1);
            A1.Add(2);
            A1.Add(3);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(A1.Get(i));
            }
            Console.ReadLine();
        }
    }
}
