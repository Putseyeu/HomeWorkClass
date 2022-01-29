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
            Console.WriteLine("Создайте персонажа");
            Console.WriteLine("Укажите возвраст.");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите рост.");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите вес.");
            int growth = Convert.ToInt32(Console.ReadLine());
            PLayer newPLayer = new PLayer(age, weight, growth);          
            newPLayer.ShowDescription();
        }
    }

    class PLayer
    {
        public PLayer(int age, int weight, int growth)
        {
            Age = age;
            Weight = weight;
            Growth = growth;
        } 

        public int Age;
        public int Weight;
        public int Growth;

        public void ShowDescription()
        {
            Console.WriteLine($"Описание вашего персонажа: Возвраст {Age}, рост {Weight} и вес {Growth}");
        }
    }
}
