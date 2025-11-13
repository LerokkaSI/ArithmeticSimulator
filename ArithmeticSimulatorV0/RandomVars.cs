using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticSimulatorV0
{
    public class RandomVars
    {
        //Инициализация Random
        private static readonly Random _globalRandom = new Random();

        //Генерация переменных для сумм и разностей
        public static (decimal a, decimal b, decimal result) 
            RandomSumm(int min, int max, int rounding)
        {
            decimal a = _globalRandom.Next(min, max);
            decimal result = _globalRandom.Next((min + Math.Abs((int)a)), (max - Math.Abs((int)a)));
            if (rounding != 0)
            {
                a += rounding != 0 ? Math.Round((decimal)_globalRandom.NextDouble(), rounding) : 0;
                result += rounding != 0 ? Math.Round((decimal)_globalRandom.NextDouble(), rounding) : 0;
            }
            return (a, result - a, result);
        }

        //Генерация переменных для произведений и частных
        public static (decimal a, decimal b, decimal result)
            RandomMulti(int min, int max, int rounding, bool isMulty = true)
        {
            decimal a = _globalRandom.Next(min, max);
            decimal b = _globalRandom.Next(min, max);
            if (rounding != 0)
            {
                a += Math.Round((decimal)_globalRandom.NextDouble(), rounding);
                b += Math.Round((decimal)_globalRandom.NextDouble(), rounding);
            }
            if (!isMulty)
            {
                if (a == 0) a += 7;
                if (b == 0) b += 8;
            }
            return (a, b, a * b);
        }
        
        //Генерация переменных для квадратного уравнения
        public static (decimal a, decimal b, decimal c, decimal x1, decimal x2, decimal d)
            RandomQuadratic(int range = 20)
        {
            decimal b = _globalRandom.Next(-range, range);
            decimal d = _globalRandom.Next(0, range);

            // Проверка чётности
            if (Math.Abs(b) % 2 != d % 2)
            {
                if (b < d)
                {
                    d++;
                }
                else
                {
                    b++;
                }
            }

            //Предотвращение появления простого числа
            if (b % 2 == 0)
                if (Math.Abs(Math.Abs(b) - d) == 2 || b - d == 2)
                {
                    if (Math.Abs(b) < d)
                    {
                        d += 2;
                    }
                    else
                    {
                        b += 2;
                    }
                }

            //Проверка на нулевую разницу
            if (Math.Abs(b) == d)
            {
                if (b < d)
                {
                    d += 2;
                }
                else
                {
                    b += 2;
                }
            }

            decimal ac = ((b * b - d * d) / 4.0m);
            List<decimal> result = Divisors(ac);
            
            
            //Тут может вылезти ошибка выхода за пределы диапазона, причина неизвестна:
            decimal a = result[_globalRandom.Next(result.Count)];
            decimal c = ac / a;
            if (_globalRandom.Next(0, 2) == 1)
            {
                a *= -1;
                c *= -1;
            }

            decimal x1 = Math.Round((-b - d) / (2m * a), 3);
            decimal x2 = Math.Round((-b + d) / (2m * a), 3);

            return (a, b, c, x1, x2, d);
        }

        // Делители числа
        private static List<decimal> Divisors(decimal number)
        {

            number = Math.Abs(number);
            List<decimal> result = new List<decimal>();
            int min2Dec = (int)number;
            decimal tempVar = 0;

            for (int i = 1; i < min2Dec; i++)
            {
                tempVar = number / i;
                if (tempVar % 1 == 0)
                {
                    result.Add(i);
                    min2Dec = (int)tempVar;
                    result.Add(min2Dec);
                }
            }
            return result;
        }

        //public static (int a, int b, int result) RandomSumm()
        //{
        //    var retDecimal = RandomSumm(0);
        //    var retInt = (a: (int)retDecimal.a, b: (int)retDecimal.b, result: (int)retDecimal.result);
        //    return retInt;
        //}
    }
}
