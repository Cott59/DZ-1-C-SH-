namespace DZ_1__C_SH_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задание 1
            Console.WriteLine("задание 1 ");
            int A, B, C, S_pr;
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            C = Convert.ToInt32(Console.ReadLine());
            if (C > A || C > B)
            {
                Console.WriteLine("значение С превышает размер сторон прямоугольника");
            }
            else
            {
                S_pr = A * B;
                int Count_A = A / C;
                int Count_B = B / C;
                Console.WriteLine("Количество квадратов на прямоугольнике : ");
                Console.WriteLine(Count_A * Count_B);
                Console.WriteLine("площадь незанятой части прямоугольника : ");
                Console.WriteLine((A * B) - (C * C) * (Count_A * Count_B));
            }
            Console.WriteLine();
            // задание 2
            Console.WriteLine("задание 2 ");

            int Start_Cash = 10000;
            Console.WriteLine("Введите число от 1 до 25 : ");
            int P = Convert.ToInt32(Console.ReadLine());
            int Summ_proc = (Start_Cash / 100) * P;
            for (int i = 1; i <= 30; i++)
            {
                if (i % 2 == 0)
                    Start_Cash += Summ_proc;
                if (Start_Cash > 11000)
                {
                    Console.WriteLine("Количество месяцев вклада: ");
                    Console.WriteLine(i);
                    Console.WriteLine("Сумма вклада: ");
                    Console.WriteLine(Start_Cash);
                    break;
                }
            }
            Console.WriteLine();
            // задание 3
            Console.WriteLine("задание 3 ");

            int Min = 3;
            int Max = 8;
            for (int i = Min; i <= Max; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // задание 4
            Console.WriteLine("задание 4 ");

            int N = 372594;
            Console.WriteLine("Изначальное число: ");
            Console.WriteLine(N);
            string str1=N.ToString();
            char[] chars =str1.ToCharArray(); ;
            Array.Reverse(chars);
            string str2 = new string(chars);
            N= Convert.ToInt32(str2);
            Console.WriteLine("Измененное число: ");
            Console.WriteLine(N);






        }
    }
}
