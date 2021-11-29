using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        //Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
        //Реализовать класс, в котором указанные значения представлены в виде свойств. Для свойств предусмотреть проверку корректности данных.
        //Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы.
        //Создать объект на основе разработанного класса.
        //Осуществить использование объекта в программе.
        {
            try
            {
                Console.Write("Введите количество градусов: ");
                int gradus = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество минут: ");
                int min = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество секунд: ");
                int sec = Convert.ToInt32(Console.ReadLine());
                Angle angle = new Angle(gradus, min, sec);
                Console.Write("Количество радиан = {0}", angle.ToRadians());
            }
            catch (Exception ex)
            { Console.WriteLine("Ошибка: {0}",ex.Message);}  
            Console.ReadKey();
        }
        public class Angle
        {
            int gradus;             
            int min;
            int sec;
            
            public int Gradus { get { return gradus; } set { gradus = value; } }

            public int Min
            {
                set
                {
                    if (value < 60)
                    {
                        min = value;
                    }
                    else
                    {
                        throw new Exception("Некорректный ввод минут: максимальное допустимое значение - 60"); 
                    }
                }

                get { return min; }

            }
            public int Sec
            {
                set
                {
                    if (value < 60)
                    {
                        sec = value;
                    }
                    else
                    {
                        throw new Exception("Некорректный ввод секунд: максимальное допустимое значение - 60");                     
                    }
                }

                get { return sec; }
            }

            public Angle(int gradus, int min = 0, int sec = 0)
            {
                Gradus = gradus;
                Min = min;
                Sec = sec;
            }


            public double ToRadians()
            {
                double radians;
                double PI = Math.PI;
                radians = Gradus * PI / 180 + Min * PI / 60 / 180 + Sec * PI / 3600 / 180;
                return radians;
            }
        }
    }   
        }
        
   

