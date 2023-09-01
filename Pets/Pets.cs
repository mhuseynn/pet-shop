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

        public string _kind { get; set; }

        public Cat(string nickname, int age, string gender, int price, int mealquantity, int money, string kind) : base(nickname, age, gender, price, mealquantity, money)
        {
            _kind = kind;
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
                if (_energy > 90)
                {
                    _energy = 100;
                }
                else
                {
                    _energy += 10;
                }
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
                if (_energy > 80)
                {
                    _energy = 100;
                }
                else
                {
                    _energy += 20;
                }
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
                if (_energy < 30)
                {
                    _energy = 0;
                }
                else
                {
                    _energy -= 30;
                }
                _money += 10;
            }
        }

        public override void show()
        {
            base.show();
            Console.WriteLine($"Kind {_kind}");
        }

    }

    public class Dog : Animal
    {
        public string _job { get; set; }
        public Dog(string nickname, int age, string gender, int price, int mealquantity, int money, string job) : base(nickname, age, gender, price, mealquantity, money)
        {
            _job = job;
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
                if (_energy > 90)
                {
                    _energy = 100;
                }
                else
                {
                    _energy += 10;
                }
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
                if (_energy > 80)
                {
                    _energy = 100;
                }
                else
                {
                    _energy += 20;
                }
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
                if (_energy < 30)
                {
                    _energy = 0;
                }
                else
                {
                    _energy -= 30;
                }
                _money += 10;
            }
        }
        public override void show()
        {
            base.show();
            Console.WriteLine($"Job - {_job}");
        }

    }

    public class Bird : Animal
    {
        public bool _isfly { get; set; }
        public Bird(string nickname, int age, string gender, int price, int mealquantity, int money, bool isfly) : base(nickname, age, gender, price, mealquantity, money)
        {
            _isfly = isfly;
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
                if (_energy > 90)
                {
                    _energy = 100;
                }
                else
                {
                    _energy += 10;
                }
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
                if (_energy > 80)
                {
                    _energy = 100;
                }
                else
                {
                    _energy += 20;
                }
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
                if (_energy < 30)
                {
                    _energy = 0;
                }
                else
                {
                    _energy -= 30;
                }
                _money += 10;
            }
        }
        public override void show()
        {
            base.show();
            Console.WriteLine($"Is fly - {_isfly}");
        }

    }

    public class Fish : Animal
    {
        public string _kind { get; set; }
        public Fish(string nickname, int age, string gender, int price, int mealquantity, int money, string kind) : base(nickname, age, gender, price, mealquantity, money)
        {
            _kind = kind;
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
                if (_energy > 90)
                {
                    _energy = 100;
                }
                else
                {
                    _energy += 10;
                }
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
                if (_energy > 80)
                {
                    _energy = 100;
                }
                else
                {
                    _energy += 20;
                }
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
                if (_energy < 30)
                {
                    _energy = 0;
                }
                else
                {
                    _energy -= 30;
                }
                _money += 10;
            }
        }
        public override void show()
        {
            base.show();
            Console.WriteLine($"Kind - {_kind}");
        }

    }


}

