using System;

namespace week3.Cyberacademy
{
    public delegate int ArithmeticOperationDelegate(int i, int j);

    public class Program
    {
        public static int i { get; private set; }

        static void Main()
        {
            ArithmeticOperationDelegate[] array = new ArithmeticOperationDelegate[3];

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    array[i] = ArithmeticOperation.Add;
                    

                }

                if (i == 1)
                {
                    array[i] = ArithmeticOperation.Minus;
                }

                if (i == 2)
                {

                    array[i] = ArithmeticOperation.Multiply;
                }

                var del = array[i];
                Console.WriteLine(del(6, 5));
            }
                
                 


        }
        public class ArithmeticOperation 
        {

           public static int Add(int i, int j)
            {
                return i + j;
            }

           public static int Minus(int i, int j)
            {
                return i - j;
            }

          public  static int Multiply(int i, int j)
            {
                return i * j;
            }

        }


    }



}


