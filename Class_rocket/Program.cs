using System;

namespace Class_rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            Rocket balists = new Rocket
            {
                Name = "Балистическая",
                Speed = 2000,
                Fuel = 100,
                Type_of_fuel = "Твердотельный",
                Range_of_action = 100000
            };
            Print_Rocket(balists);
            Console.WriteLine("Объектов созданно {0}",balists.get_Count);
            Console.WriteLine("----------------------------------------");
            Military_missiles militaryMissiles = new Military_missiles
            {
                Guided_missile_class = "воздух-воздух",
                Guidance_system = "Инфракрасная систем самонаведения",
                Name = "Р-73",
                Speed = 2000,
                Fuel = 100,
                Type_of_fuel = "Твердотопливный двигатель с интерцепторами системы газодинамического управления",
                Range_of_action = 100000
            };
            Print_Military_missiles(militaryMissiles);
            Console.WriteLine("Объектов созданно {0}",militaryMissiles.get_Count);

            Rocket copy = new Rocket(balists);
            Console.WriteLine(balists.get_Count);

            Military_missiles[] array = new Military_missiles[5];
            Fill_Array_Military_missiles(array,5);

            for (int i = 0; i < 5; ++i)
            {
                Print_Military_missiles(array[i]);
                Console.WriteLine("--------------------------------");
            }
            
            Console.WriteLine("Объектов созданно {0}",militaryMissiles.get_Count);
        }
        
        static void Print_Rocket(Rocket rocket)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(rocket.get_Class);
            Console.WriteLine($" {rocket.Name}\nСкорость - {rocket.Speed}км/ч\nОсталось топлива - " +
                              $"{rocket.Fuel}%\nТип топлива - {rocket.Type_of_fuel}\n" +
                              $"Дальность действия - {rocket.Range_of_action}км");
            Console.ResetColor();
        }

        static void Print_Military_missiles(Military_missiles rocket)
        {
            Print_Rocket(rocket);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Класс ракеты - {0} \nСистема управления - {1}", rocket.Guided_missile_class,
                rocket.Guidance_system);
            Console.ResetColor();
        }
        static void Fill_Array_Rocket(Rocket[] array,int Index)
        {
            for (int counter = 0; counter < 5; ++counter)
            {
                array[counter] = new Military_missiles();
                Fill_Rocket(array[counter]);
            }
        }
        static void Fill_Array_Military_missiles(Military_missiles[] array,int Index)
        {
            for (int counter = 0; counter < 5; ++counter)
            {
                array[counter] = new Military_missiles();
                Fill_Military_missiles(array[counter]);
            }
        }
        static void Fill_Rocket(Rocket array)
        {
            Console.WriteLine("Введите имя ракеты");
            array.Name = Console.ReadLine();

            Console.WriteLine("Введите скорость ракеты");
            array.Speed = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите объем топлива от 1 - 100 %");
            array.Fuel = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите тип топлива жидкий , газообразный , твердый");
            array.Type_of_fuel = Console.ReadLine();
            
            Console.WriteLine("Введите дальность действия");
            array.Range_of_action = Convert.ToDouble(Console.ReadLine());
        }
        
        static void Fill_Military_missiles(Military_missiles array)
        {
            Fill_Rocket(array);
            Console.WriteLine("Введите класс ракеты {0},{1},{2}","воздух - воздух", "воздух - поверхность", "вода - земля");
            array.Guided_missile_class = Console.ReadLine();
            
            Console.WriteLine("Введите класс ракеты {0},{1},{2},{3},{4},{5}","инфракрасная (тепловая) ГСН", "ультрафиолетовая ГСН",
                "радиолокационная","инерциальная","астронавигационная","спутниковая навигация");
            array.Guided_missile_class = Console.ReadLine();
        }
    }
}