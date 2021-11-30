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
                Angle angle = new Angle();
                Console.Write("Введите градусы: ");
                angle.Gradus = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите минуты: ");
                angle.Min = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите секунды: ");
                angle.Sec = Convert.ToInt32(Console.ReadLine());
                
                
                Console.WriteLine("Угол в радианах = {0}", angle.ToRadians());
                Console.WriteLine("({0} об. {1} радиан)", angle.CountTurns(), angle.ToRadians()-2*Math.PI*angle.CountTurns());

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
            
            public int Gradus { get { return gradus; } set { gradus = value; } }//ввод отрицательных значений градуса угла допускается.
                                                                                //градусы могут быть более 180 и более 360

            public int Min
            {
                set
                {
                    if (value >=0 & value < 60)
                    {
                        min = value;
                    }
                    else
                    {
                        throw new Exception("Некорректный ввод минут: допустимый диапазон [0;60)"); 
                    }
                }

                get { return min; }

            }
            public int Sec
            {
                set
                {
                    if (value >= 0 & value < 60)
                    {
                        sec = value;
                    }
                    else
                    {
                        throw new Exception("Некорректный ввод секунд: допустимы диапазон [0;60) ");                     
                    }
                }

                get { return sec; }
            }
            
            public Angle(int gradus=0, int min = 0, int sec = 0)
            {
                Gradus = gradus;
                Min = min;
                Sec = sec;
            }


            public double ToRadians()
            {
                double radians;
                radians = Gradus * Math.PI / 180 + Min * Math.PI / 60 / 180 + Sec * Math.PI / 3600 / 180;
                return radians;
            }
            public double CountTurns()//считает целые обороты. Должно быть целым, может быть отрицательныи
            {
                int turns = 0;
                turns = Gradus / 360;
                return turns;
            }
        }
    }   
        }
        
   

