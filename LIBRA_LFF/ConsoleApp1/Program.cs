namespace LIBRA_LFF
{
    public class Program
    {
        public static void Main()
        {
            Knowledge know = new Knowledge();

            know.ListData = new List<Data>()
            {
                new Data("Fabio", Fact.Is, "human"),
                new Data("Nicky", Fact.Is, "dog"),
                new Data("Amanda", Fact.Is, "little princess"),
                new Data("little princess", Fact.Is, "human"),
                new Data("human", Fact.NotIs, "little princess")
            };

            Console.WriteLine("Fabio is " + Show(know.GetTypes("Fabio")));
            // Fabio is human

            Console.WriteLine(Show(know.GetNamesOfType("human")) + " is type of human");
            // Fabio, little princess is type of human

            Console.WriteLine("Fabio is a human? R: " + know.CheckFact("Fabio", "human").ToString());
            // Fabio is a human? R: Yes
            
            Console.WriteLine("Nicky is a human? R: " + know.CheckFact("Nicky", "human").ToString());
            // Nicky is a human? R: NotFound
                        
            Console.WriteLine("human is little princess? R: " + know.CheckFact("human", "little princess").ToString());
            // human is little princess? R: No

            Console.ReadKey();
        }

        public static string Show(List<string> list)
        {
            string result = "";
            
            foreach (var item in list)
                 result += item + ", ";

            if (result.Length > 2)
                result = result.Substring(0, result.Length - 2);

            return result;
        }
        
    } 
}