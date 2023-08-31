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


        public void display()
        {
            for (int i = 0; i < cats.Length; i++)
            {
                cats[i].show();
            }
        }
    }
}
