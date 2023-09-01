using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_base
{
    public abstract class Animal
    {
        public string _nickname { get; set; }
        public int _age { get; set; }
        public string _gender { get; set; }

        public int _energy { get; set; }

        public int _price { get; set; }
        public int _mealquantity { get; set; }

        public int _money { get; set; }

        public Animal(string nickname, int age, string gender, int price, int mealquantity, int money)
        {
            _nickname = nickname;
            _age = age;
            _gender = gender;
            _energy = 100;
            _price = price;
            _mealquantity = mealquantity;
            _money = money;
        }



        public virtual void show()
        {
            Console.WriteLine($"Nickname - {_nickname}");
            Console.WriteLine($"Age - {_age}");
            Console.WriteLine($"Gender - {_gender}");
            Console.WriteLine($"Energy - {_energy}");
            Console.WriteLine($"Price - {_price}");
            Console.WriteLine($"Meal Quantity - {_mealquantity}");
        }
    }


}
