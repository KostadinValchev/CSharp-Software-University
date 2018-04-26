namespace Animals
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var data = Console.ReadLine();

            while (data != "Beast!")
            {
                try
                {
                    var animal = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string animalName;
                    int animalAge;
                    string animalGender;

                    if (animal.Length != 3)
                    {
                        throw new ArgumentException("Invalid input!");
                    }

                    animalName = animal[0];
                    if (!int.TryParse(animal[1], out animalAge))
                    {
                        throw new ArgumentException("Invalid input!");
                    }

                    animalGender = animal[2];
                    switch (data)
                    {
                        case "Dog":
                            var dog = new Dog(animalName, animalAge, animalGender);
                            Console.WriteLine(dog.ProduceSound());
                            break;

                        case "Cat":
                            var cat = new Cat(animalName, animalAge, animalGender);
                            Console.WriteLine(cat.ProduceSound());
                            break;

                        case "Frog":
                            var frog = new Frog(animalName, animalAge, animalGender);
                            Console.WriteLine(frog.ProduceSound());
                            break;

                        case "Kitten":
                            var kitten = new Kitten(animalName, animalAge);
                            Console.WriteLine(kitten.ProduceSound());
                            break;

                        case "Tomcat":
                            var tomcat = new Tomcat(animalName, animalAge);
                            Console.WriteLine(tomcat.ProduceSound());
                            break;

                        default:
                            throw new ArgumentException("Invalid input!");
                    }
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }

                data = Console.ReadLine();
            }
        }
    }
}
