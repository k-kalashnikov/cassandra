using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    /*
     * 1. Наследование - перенос функционала одного класса(родитель) в другой(наследник)
     * 2. Полиморфизм - расширение текущего функционала методом добавления новых реализация, но не измения старых
     * 3. Инкапсуляция - сокрытие и раскрытие комконетов класса
     * 4. Абстракция - класс и контект неразлучимы
     */

    /*
     * Классы - внутренности
     * 1. Свойства
     * 2. Переменные класса - не надо использовать
     * 3. Методы 
     * 4. Конструктор
     */

    /*
     * Правила:
     * 1. Один класс может наследовать только один класс
     * 2. public private protected
     * 3. Конструктор ВСЕГДА должен быть публичным
     */

    public class TestOpp 
    {
        public void testOne() 
        {
            Animal animal = new Animal();

            Animal newAnimal = new Animal(DateTime.Now.AddDays(10));

            Dog dog = new Dog("Vafel");

            Wolf wolf = new Wolf();
        }
    }

    public class Animal
    {
        public Animal()
        {
            BirthDay = DateTime.Now;
        }

        public Animal(DateTime _deathDay) : this()
        {
            DeathDay = _deathDay;
        }

        private DateTime BirthDay { get; }
        public DateTime DeathDay { get; set; }
    }

    public class Dog : Wolf
    {
        public Dog(string _name) : base() 
        {
            Name = _name;
        }

        public string Name { get; set; }

        public string DogBreed { get; set; }

        public void CreateShit(string food) 
        {
            Console.WriteLine($"I created shit with {food}");
            FeelHunger();
        }
    }

    public class Wolf : Animal
    {
        public Wolf() : base() 
        {

        }

        public string area;

        public void Foo() 
        {
            Console.WriteLine("Foooooo");
        }

        public void CreateShit()
        {
            Console.WriteLine("I create shit");
            FeelHunger();
        }

        protected void FeelHunger() 
        {
            Console.WriteLine("I'm hunger");
        }

    }
}
