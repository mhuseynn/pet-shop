using Animal_base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class Cat : Animal
    {


        public Cat(string nickname, int age, string gender, int energy, int price, int mealquantity,int money) : base(nickname, age, gender, energy, price, mealquantity,money)
        {
        }


        public void buy_meal()
        {
            if (_money == 0 )
            {
                Console.WriteLine("There is no money, please play games and make some money");
                return;
            }
            _mealquantity += 10;
            _money -= 10;
        }

        public void eat()
        {
            if (_energy == 100)
            {
                Console.WriteLine("Energy is max(100),he/she can't eat");
            }
            else
            {
                _energy += 10;
                _mealquantity -= 10;
                _price += 5;
            }
            

        }

        public void sleep()
        {
            if (_energy == 100)
            {
                Console.WriteLine("Energy is max(100),he/she can't sleep");
            }
            else
            { 
                _energy += 20;
                _price += 5;
            }

        }

        public void play()
        {
            if (_energy == 0)
            {
                Console.WriteLine("It has no energy(0),please eat or sleep");
            }
            else
            {
                _energy -= 30;
                _money += 10;
            }
        }

        public override void show()
        {
            base.show();
        }

    }



    public class Dog : Animal
    {

        public Dog(string nickname, int age, string gender, int energy, int price, int mealquantity, int money) : base(nickname, age, gender, energy, price, mealquantity, money)
        {
        }


        public void buy_meal()
        {
            if (_money == 0)
            {
                Console.WriteLine("There is no money, please play games and make some money");
                return;
            }
            _mealquantity += 10;
            _money -= 10;
        }

        public void eat()
        {
            if (_energy == 100)
            {
                Console.WriteLine("Energy is max(100),he/she can't eat");
            }
            else
            {
                _energy += 10;
                _mealquantity -= 10;
                _price += 5;
            }


        }

        public void sleep()
        {
            if (_energy == 100)
            {
                Console.WriteLine("Energy is max(100),he/she can't sleep");
            }
            else
            {
                _energy += 20;
                _price += 5;
            }

        }

        public void play()
        {
            if (_energy == 0)
            {
                Console.WriteLine("It has no energy(0),please eat or sleep");
            }
            else
            {
                _energy -= 30;
                _money += 10;
            }
        }


    }

    public class Bird : Animal
    {

        public Bird(string nickname, int age, string gender, int energy, int price, int mealquantity, int money) : base(nickname, age, gender, energy, price, mealquantity, money)
        {
        }


        public void buy_meal()
        {
            if (_money == 0)
            {
                Console.WriteLine("There is no money, please play games and make some money");
                return;
            }
            _mealquantity += 10;
            _money -= 10;
        }

        public void eat()
        {
            if (_energy == 100)
            {
                Console.WriteLine("Energy is max(100),he/she can't eat");
            }
            else
            {
                _energy += 10;
                _mealquantity -= 10;
                _price += 5;
            }


        }

        public void sleep()
        {
            if (_energy == 100)
            {
                Console.WriteLine("Energy is max(100),he/she can't sleep");
            }
            else
            {
                _energy += 20;
                _price += 5;
            }

        }

        public void play()
        {
            if (_energy == 0)
            {
                Console.WriteLine("It has no energy(0),please eat or sleep");
            }
            else
            {
                _energy -= 30;
                _money += 10;
            }
        }


    }


    public class Fish : Animal
    {

        public Fish(string nickname, int age, string gender, int energy, int price, int mealquantity, int money) : base(nickname, age, gender, energy, price, mealquantity, money)
        {
        }


        public void buy_meal()
        {
            if (_money == 0)
            {
                Console.WriteLine("There is no money, please play games and make some money");
                return;
            }
            _mealquantity += 10;
            _money -= 10;
        }

        public void eat()
        {
            if (_energy == 100)
            {
                Console.WriteLine("Energy is max(100),he/she can't eat");
            }
            else
            {
                _energy += 10;
                _mealquantity -= 10;
                _price += 5;
            }


        }

        public void sleep()
        {
            if (_energy == 100)
            {
                Console.WriteLine("Energy is max(100),he/she can't sleep");
            }
            else
            {
                _energy += 20;
                _price += 5;
            }

        }

        public void play()
        {
            if (_energy == 0)
            {
                Console.WriteLine("It has no energy(0),please eat or sleep");
            }
            else
            {
                _energy -= 30;
                _money += 10;
            }
        }


    }


}

