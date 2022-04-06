namespace LIBRA_LFF
{
    public enum Fact { Is, NotIs }

    public class Data
    {
        public string Name { get; set; }

        public Fact Fact { get; set; }

        public string Type { get; set; }

        public Data(string name, Fact Fact, string type)
        {
            this.Type = type;
            this.Fact = Fact;
            this.Name = name;
        }
    }
}
