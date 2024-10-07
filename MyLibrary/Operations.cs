using System.Collections;

namespace MyLibrary
{
    public class Operations
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public bool Iseven(int number)
        {
            return number % 2 == 0;
        }

        public double AddDecimal(double number1, double number2)
        {
            return number1 + number2;
        }


        //ArrayList= List
        public IList<int> GetEvenNumbers(int start, int end)
        {
            //List<int> numbers = new List<int>();
            //for (int i = start; i < end; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        numbers.Add(i);
            //    }
            //}
            //return numbers;

            //List<int> numbers = Enumerable.Range(start, end)
            //    .Where(number => number % 2 == 0)
            //    .ToList();

            return Enumerable.Range(start, end)
                .Where(Iseven)
                .ToList();
        }

        //Metodo de prueba para la clase sobre el array para ver que numeros devuelve, hay que usar metodos de prueba de unit para arrays
    }
}
