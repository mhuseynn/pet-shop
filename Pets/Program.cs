using Pets;
using Animal_base;
using Pet_shop;

Cat cat = new Cat("Mestan", 10, "Disi", 50, 35, 90, "Sphinx");
Dog dog = new Dog("Alabas", 2, "erkek", 50, 45, 300, "Police dog");

Pet_Shop pet_shop = new Pet_Shop();

pet_shop.add_pet(cat);
pet_shop.add_pet(dog);
pet_shop.display();
cat.play();
Console.WriteLine();
pet_shop.display();