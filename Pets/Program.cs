using Pets;
using Animal_base;
using Pet_shop;

Cat c = new Cat("mestan", 10,"d", 100, 100, 100, 100);


Pet_Shop pet_shop = new Pet_Shop();

pet_shop.add_pet(c);

pet_shop.display();