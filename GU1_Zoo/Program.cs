using Seido.Utilities.SeedGenerator;
namespace GU1_Zoo;

class Program
{
    static void Main(string[] args)
    {
        //Här gör vi en csSeedGenerator för att kunna slumpa fram djuren
        var rnd = new csSeedGenerator();

        //10. Här är vårat small zoo
        var zooSmall = new csZoo("Small zoo", rnd, 5);

        //11. Här är vårat large zoo
        var zooLarge = new csZoo("Large zoo", rnd, 25);

        //Här printar vi ut dom
        Console.WriteLine(zooSmall);
        Console.WriteLine(zooLarge);
        var biggestZoo = new csZoo(); //Tom constructor gör en av varje animal med alla moods
        Console.WriteLine(biggestZoo);
    }
}



// Model an animal in class csAnimal. Animal has a name (name), age (age),
// animalkind (kind) and mood (mood).
// Kind - Moose, Wolf, Deer, Eagle, Hawk, Aligator, Elephant, Lion, Monkey,
// Mood - Happy, Sleepy, Happy, Hungry, Lazy, Quick, Slow
// create a  random-constructor, copy-constructor
// create a ToString() print ex ”Max the Happy Aligator”
// Model a Zoo in csZoo. Zoo has a name and a number of animals.
// create a constructor to give your Zoo a name and create a number of animals.
// name and numberOfAnimals is parameters to teh constructor
// create a ToString() to print the  animals in your zoo
// make a program to create and print the amnimals
// - one zoo called ”Small Zoo” with 5 animals
// - a zoo called ”Large Zoo” with 25 animals


/*
Avancerat
Skapa en tom constructor till csZoo som skapar ett zoo som har djur där det för varje
djurtyp finns ett djur för varje humör.
Dvs en Moose-Happy, Moose-Sleepy, .., Moose-Slow, .., Monkey-Happy, MonkeySleepy, .., Monkey-Slow
*/