using Seido.Utilities.SeedGenerator; // Det här måste vi skriva för att kunna använda SeedGeneratorn

namespace GU1_Zoo
{
	public enum enKind { Moose, Wolf, Deer, Eagle, Hawk, Aligator, Elephant, Lion, Monkey }; // 2. Våran samling (enum) av kinds of animal
	public enum enMood { Happy, Sleepy, Sad, Hungry, Lazy, Quick, Slow }; // enum med moods

	public class csAnimal //1. Modellera ett djur (csAnimal)
	{
		public string Name; // Med ett namn
		public int Age; // och en ålder

		public enKind Kind; // 2. Djuret har en kind
		public enMood Mood; // och en mood

		public csAnimal() // Allt som heter "public [Class-namnet]" är en Constructor, här är constructorn tom, så vi kallar den för "Empty constructor"
		{
		}

		public csAnimal(csSeedGenerator rnd)
		{ //3. Här har vi en till Constructor, här så har vi en "SeedGenerator" som slumpar (random) fram värden, denna kallas för random-constructor 
			Age = rnd.Next(1, 100); // Slumpa fram en siffra 
			Name = rnd.PetName; // ett namn
			Kind = rnd.FromEnum<enKind>(); // en kind
			Mood = rnd.FromEnum<enMood>(); // och en mood
		}

		public csAnimal(csAnimal old)
		{ //4. Här har vi våran Constructor numer 3, här så skicka vi in ett redan skapat csAnimal (old), och kopierar den till ett nytt likadant djur
		  // Efter som denna är en Constructor som kopierar så kallas denna för "Copy-Constructor"

			Age = old.Age;   //Här kopieras våra old values till nya värden
			Name = old.Name;
			Kind = old.Kind;
			Mood = old.Mood;
		}

		// 5. Här skapar vi en toString [metod] (inte en constructor) för att presentera djuret
		public override string ToString() => $"{Name} the {Age} old {Mood} {Kind}";
	}
}

