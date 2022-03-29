namespace LIBRA_LFF
{
    public class Program
    {
        public static void Main()
        {
            Knowledge know = new Knowledge();

            know.CaseSensitive = false;

            know.ListData = new List<Data>()
            {
                new Data("Fabio", "human"),
                new Data("Nicky", "dog"),
                new Data("Amanda", "little princess")
            };

            know.listEquivalence = new List<Equivalence>()
            {
                new Equivalence("little princess", "human")
            };

            know.ListNeverIs = new List<NeverIs>()
            {
                new NeverIs("Fabio", "little princess")
            };

            Console.WriteLine("Fabio is a human? R: " + know.CheckIs("Fabio", "human").ToString());
            Console.WriteLine("Nicky is a human? R: " + know.CheckIs("Nicky", "human").ToString());
            Console.WriteLine("Nicky is a dog? R: " + know.CheckIs("Nicky", "dog").ToString());


            Console.Write("\r\n\nAmanda is: ");

            List<string> result = know.Get("Amanda");

            foreach (var item in result)
                Console.Write(item.ToString() + ", ");

            Console.Write("\r\n\nlittle princess is: ");

            result = know.Get("little princess");

            foreach (var item in result)
                Console.Write(item.ToString() + ", ");

            Console.Write("\r\n\nFabio is: ");

            result = know.Get("Fabio");

            foreach (var item in result)
                Console.Write(item.ToString() + ", ");

            Console.ReadKey();
        }
    } 
}