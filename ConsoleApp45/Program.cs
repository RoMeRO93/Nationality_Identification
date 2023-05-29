using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bun venit! Introduceti numele dumneavoastra:");
        string numeUtilizator = Console.ReadLine();

        Roman roman = new Roman();
        roman.Nume = numeUtilizator;
        roman.Continent = "Europa";
        roman.Limba = "romana";
        roman.Print();

        Chinez chinez = new Chinez();
        chinez.Nume = "Jackie Chan";
        chinez.Limba = "Chineza";
        chinez.Continent = "Asia";
        chinez.Print();
        chinez.DanseazaKungFu();

        Mexican mexican = new Mexican();
        mexican.Nume = "Rodriguez";
        mexican.Limba = "Mexicana";
        mexican.Continent = "America de Nord";
        mexican.Print();
        mexican.DanseazaSalsa();

        Console.WriteLine("Introduceti nationalitatea dumneavoastra:");
        string nationalitate = Console.ReadLine().ToLower();

        Console.WriteLine("Introduceti tara dumneavoastra:");
        string tara = Console.ReadLine();

        Tara utilizator = null;

        switch (nationalitate)
        {
            case "roman":
                utilizator = new Roman();
                utilizator.Nume = numeUtilizator;
                utilizator.Continent = "Europa";
                utilizator.Limba = "romana";
                break;

            case "chinez":
                utilizator = new Chinez();
                utilizator.Nume = numeUtilizator;
                utilizator.Continent = "Asia";
                utilizator.Limba = "Chineza";
                break;

            case "mexican":
                utilizator = new Mexican();
                utilizator.Nume = numeUtilizator;
                utilizator.Continent = "America de Nord";
                utilizator.Limba = "Mexicana";
                break;

            case "italian":
                utilizator = new Italian();
                utilizator.Nume = numeUtilizator;
                utilizator.Continent = "Europa";
                utilizator.Limba = "Italiana";
                break;

            default:
                Console.WriteLine("Nationalitatea introdusa nu este suportata in acest program.");
                break;
        }

        if (utilizator != null)
        {
            utilizator.Print();
            Console.WriteLine($"Cetateanul {utilizator.Nume} este din {tara}.");
        }
    }
}

public abstract class Tara
{
    public string Nume { get; set; }
    public string Limba { get; set; }
    public string Continent { get; set; }

    public abstract void Print();
}

public class Roman : Tara
{
    public override void Print()
    {
        Console.WriteLine($"Cetateanul {Nume} vorbeste limba {Limba} pentru ca este de pe continentul {Continent}");
    }
}

public class Chinez : Tara
{
    public void DanseazaKungFu()
    {
        Console.WriteLine($"Cetateanul chinez {Nume} danseaza Kung Fu!");
    }

    public override void Print()
    {
        Console.WriteLine($"Cetateanul chinez {Nume} vorbeste limba {Limba} pentru ca este de pe continentul {Continent}");
    }
}

public class Mexican : Tara
{
    public void DanseazaSalsa()
    {
        Console.WriteLine($"Cetateanul mexican {Nume} danseaza Salsa!");
    }

    public override void Print()
    {
        Console.WriteLine($"Cetateanul mexican {Nume} vorbeste limba {Limba} pentru ca este de pe continentul {Continent}");
    }
}

public class Italian : Tara
{
    public void CookPizza()
    {
        Console.WriteLine($"Cetateanul italian {Nume} gateste pizza delicioasa!");
    }

    public override void Print()
    {
        Console.WriteLine($"Cetateanul italian {Nume} vorbeste limba {Limba} pentru ca este de pe continentul {Continent}");
    }
}

