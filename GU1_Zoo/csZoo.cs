using Seido.Utilities.SeedGenerator;

namespace GU1_Zoo
{
	public class csZoo //6. Här är vår modell av ett zoo
	{
		public string NameOfZoo; //7. Vårat namn på zoo:et

		List<csAnimal> animals = new List<csAnimal>(); //7. Här skapar vi en lista av djur (så att vårat zoo inhåller ett antal djur)

		public csZoo(string _nameOfZoo, csSeedGenerator rnd, int numberOfAnimals)
		{ //8. Eftersom det står public 'namn-på-klassen' så är det här en constructor

			NameOfZoo = _nameOfZoo; //Här ger vi ett namn till zooet

			for (int i = 0; i < numberOfAnimals; i++) //Här så skapar vi våra djur, vi skapar "numberOfAnimals" stycken djur
			{
				// animals är namnet på våran lista, .Add lägger till i listan, new csAnimal skpar ett nytt djur med random-constructorn i csAnimal
				animals.Add(new csAnimal(rnd));
			}
		}

		public override string ToString()
		{ //9. Vi gör en ToString för att kunna skriva ut vårat zoo 

			string s = $"This is the {NameOfZoo}"; //En tom string där vi kommer att spara djurens namn och ålder

			// Vi loop:ar igenom alla djur och sparar deras "toString" i s och skickar sedan tillbaka s
			foreach (var item in animals)
			{
				s += $"{item}\n"; //Lägg till varje djurs toString i s och en \n för att skapa en ny rad
			}
			return s;
		}
	}
}
