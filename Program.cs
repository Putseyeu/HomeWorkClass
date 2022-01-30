using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClass
{
    class Program
    {
        static void Main(string[] args)
        {
            bool characterСreated = false;
            int age = 0;
            int weight = 0;
            int growth = 0;
            int number = 0;           
            int ageMin = 18;
            int ageMax = 50;
            int growthMin = 70;
            int growthMax = 140;
            int weightMin = 150;
            int weightMax = 251;

            while (characterСreated == false)
            {
                Console.WriteLine("Создайте персонажа");
                Console.WriteLine($"Укажите возвраст. Возвраст от {ageMin} лет  до {ageMax} лет!.");
                ChekUserInput(ref number, ageMin, ageMax);
                age = number;
                Console.WriteLine($"Укажите рост. Рост минимальный от {weightMin} см до {weightMax} см.");
                ChekUserInput(ref number, weightMin, weightMax);
                weight = number;
                Console.WriteLine($"Укажите вес. Вес минимальный  от {growthMin} кг до {growthMax} кг.");
                ChekUserInput(ref number, growthMin, growthMax);
                growth = number;
                characterСreated = true;
            }
            PLayer newPLayer = new PLayer(age, weight, growth);
            newPLayer.ShowDescription();
        }

        static void ChekUserInput ( ref int number, int numberMin, int numberMax)
        {         
            bool completed = false;
            while (completed == false)
            {
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int intValue))
                {                    
                    if (numberMin <= intValue && intValue <= numberMax)
                    {
                        number = intValue;                      
                        completed = true;                      
                    }
                    else
                    {
                        Console.WriteLine($"Не верный ввод значения.Введите число от {numberMin} до {numberMax}");
                    }                    
                }
                else
                {
                    Console.WriteLine($"Не верный ввод значения.Введите число от {numberMin} до {numberMax}");
                }
            }
        }
    }

    class PLayer
    {
        int _age;
        int _weight;
        int _growth;

        public PLayer(int age, int weight, int growth)
        {
            _age = age;
            _weight = weight;
            _growth = growth;
        }

        public void ShowDescription()
        {
            Console.WriteLine($"Описание вашего персонажа: Возвраст {_age} лет, рост {_weight} см и вес {_growth} кг.");
        }
    }
}
