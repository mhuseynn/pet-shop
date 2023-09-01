using Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_shop
{
    public class Pet_Shop
    {
        private Cat[] cats = new Cat[0];
        private Dog[] dogs = new Dog[0];
        private Bird[] birds = new Bird[0];
        private Fish[] fishes = new Fish[0];

        public void add_pet(Cat cat)
        {
            Array.Resize(ref cats, cats.Length + 1);
            cats[cats.Length - 1] = cat;
        }

        public void add_pet(Dog dog)
        {
            Array.Resize(ref dogs, dogs.Length + 1);
            dogs[dogs.Length - 1] = dog;
        }

        public void add_pet(Bird bird)
        {
            Array.Resize(ref birds, birds.Length + 1);
            birds[birds.Length - 1] = bird;
        }

        public void add_pet(Fish fish)
        {
            Array.Resize(ref fishes, fishes.Length + 1);
            fishes[fishes.Length - 1] = fish;
        }


        public void search_by_nickname(string nickname)
        {
            for (int i = 0; i < cats.Length; i++)
            {
                if (cats[i]._nickname == nickname)
                {
                    cats[i].show();
                }
            }

            for (int i = 0; i < dogs.Length; i++)
            {
                if (dogs[i]._nickname == nickname)
                {

                    dogs[i].show();
                }
            }

            for (int i = 0; i < birds.Length; i++)
            {
                if (birds[i]._nickname == nickname)
                {

                    birds[i].show();
                }
            }

            for (int i = 0; i < fishes.Length; i++)
            {
                if (fishes[i]._nickname == nickname)
                {

                    fishes[i].show();
                }
            }
        }
















        public void display()
        {
            for (int i = 0; i < cats.Length; i++)
            {
                cats[i].show();
            }
            Console.WriteLine("--------------------------");
            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].show();
            }
            Console.WriteLine("--------------------------");
            for (int i = 0; i < birds.Length; i++)
            {
                birds[i].show();
            }
            Console.WriteLine("--------------------------");
            for (int i = 0; i < fishes.Length; i++)
            {
                fishes[i].show();
            }
            
        }
    }
}
