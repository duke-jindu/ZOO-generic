namespace AnimalSounds
{
    class Animal_Sound
    {
        public void  animalSound<T> (T Sound) 
        {
            Console.WriteLine(Sound);
        }

    }

    class program
    {
        static void Main(string[] args)
        {
            Animal_Sound Animal = new Animal_Sound();
            Animal.animalSound("DOGS"); 
            Animal.animalSound("Dogs bark"); 
            Animal.animalSound(" "); 
            Animal.animalSound("COWS"); 
            Animal.animalSound("Cows Moo!"); 
            Animal.animalSound(" "); 
            Animal.animalSound("ELEPHANT"); 
            Animal.animalSound("Elephants Trumpet"); 
            Animal.animalSound(" "); 
            Animal.animalSound("MONKEY"); 
            Animal.animalSound("Monkeys laught?"); 
            Animal.animalSound(" "); 
            Animal.animalSound("HORSE"); 
            Animal.animalSound("Horses neigh"); 
            Animal.animalSound(" "); 
            Animal.animalSound("LION"); 
            Animal.animalSound("Lions Roar"); 
            Animal.animalSound(" "); 
            
        }
    }
}