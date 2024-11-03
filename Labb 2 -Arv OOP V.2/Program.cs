namespace Labb_2__Arv_OOP_V._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Wolf wolf = new Wolf();
            Goose goose = new Goose();
            Bear bear = new Bear();
            PolarBear polarBear = new PolarBear();
            GrizzlyBear grizzlyBear = new GrizzlyBear();
 

            Animal[] animals = { bear, wolf, goose, polarBear, grizzlyBear };

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
                animal.Hunting();
                animal.Migrate();
            
                if (animal is PolarBear polar)
                {
                    polar.Swim(); // Anropa PolarBear-specifik metod
                }
                else if (animal is GrizzlyBear grizzly)
                {
                    grizzly.Claws(); // Anropa GrizzlyBear-specifik metod
                }
                else if (animal is Wolf wolfAnimal)
                {
                    wolfAnimal.HuntInPack(); // Anropa Wolf-specifik metod
                }
                else if (animal is Goose gooseAnimal)
                {
                    gooseAnimal.FlyingInV(); // Anropa Goose-specifik metod
                }
                else
                {
                    // Om det är en vanlig björn, utför vanliga björnfunktioner
                    animal.Hibernating(); // Anropa Bear-metod
                }

            }


        }
    }



    public class Animal
    {
        public int Legs { get; set; }
        public int Eyes { get; set; }
        public bool Fur { get; set; }
        public string Gender { get; set; }
        public bool Omnivore { get; set; }

        public Animal()
        {
            // Standardvärden
            Legs = 4;
            Eyes = 2;
            Fur = true;
            Omnivore = true;
            Gender = "Female";

        }

        public virtual void MakeSound() { }
        public virtual void Hunting() { }
        public virtual void Migrate() { }
        public virtual void HuntInPack() { }
        public virtual void FlyingInV() { }
        public virtual void Swim() { }
        public virtual void Hibernating() { }
        public virtual void Claws(){ }

    }


    public class Bear : Animal
    {
        public bool IsHibernating { get; set; }

        public Bear()
        {
            Legs = 4;
            Eyes = 2;
            Fur = true;
            Omnivore = true;
            Gender = "Female";
            IsHibernating = true;
 

        }

        public override void MakeSound()
        {
            Console.WriteLine("Roar!");
        }

        public override void Hunting()
        {
            Console.WriteLine("The bear is eyeing up its prey.");
        }

        public override void Migrate()
        {
            Console.WriteLine("The bear is migrating to a colder climate");
        }

        public override void Hibernating() // Unik
        {
            Console.WriteLine("This bear is going to sleep for 8 months!");
        }

      
    }

    public class Wolf : Animal
    {
        public int PackSize { get; set; }

        public Wolf()
        {
            Legs = 4;
            Eyes = 2;
            Fur = true;
            Omnivore = true;
            Gender = "Male";
            PackSize = 5;

        }

        public override void MakeSound()
        {
            Console.WriteLine("Howl!");
        }

        public override void Hunting()
        {
            Console.WriteLine("The wolf is eyeing up its prey.");
        }

        public override void Migrate()
        {
            Console.WriteLine("The Wolf is migrating a colder climate");
        }

        public override void HuntInPack() // Unik
        {
            Console.WriteLine("The wolf hunts in a pack");
        }
    }

    public class Goose : Animal
    {
        public bool CanFly { get; set; }

        public Goose()
        {
            Eyes = 2;
            Legs = 2;
            Fur = false;
            Omnivore = true;
            Gender = "Male";
            CanFly = true;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Honk!");
        }

        public override void Hunting()
        {
            Console.WriteLine("The goose is eyeing up its prey.");
        }

        public override void Migrate()
        {
            Console.WriteLine("The goose is migrating to a warmer place.");
        }

        public override void FlyingInV() // Unik
        {
            Console.WriteLine("When the geese flies to another place they always fly in a V shape");
        }
    }

    public class PolarBear : Bear
    {
        public bool IsOnIce { get; set; }

        public PolarBear()
        {
            IsOnIce = true;
        }

        public override void Swim()
        {
            Console.WriteLine("The polar bear is swimming in icy waters.");
        }

    }

    public class GrizzlyBear : Bear
    {
        public bool LivesInForest { get; set; }

        public GrizzlyBear()
        {
            LivesInForest = true;
        }

        public override void Claws()
        {
            Console.WriteLine("The grizzly bear has the biggest bear claws.");
        }

    }


}
