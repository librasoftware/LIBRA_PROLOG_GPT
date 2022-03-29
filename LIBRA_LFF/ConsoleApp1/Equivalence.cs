namespace LIBRA_LFF
{
    public class Equivalence
    {
        public string Type1 { get; set; }

        public string Type2 { get; set; }

        public Equivalence(string type1, string type2)
        {
            this.Type1 = type1;
            this.Type2 = type2;
        }
    }
}