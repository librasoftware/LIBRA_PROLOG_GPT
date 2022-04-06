namespace LIBRA_LFF
{
    public enum Response { Yes, No, NotFound }

    public class Knowledge
    {
        public List<Data> ListData = new List<Data>();

        public List<string> GetTypes(string name)
        {
            List<string> result = new List<string>();

            foreach (Data data in ListData)
                if ((data.Name == name) && (data.Fact == Fact.Is))
                    result.Add(data.Type);

            return result;
        }

        public List<string> GetNamesOfType(string type)
        {
            List<string> result = new List<string>();

            foreach (Data data in ListData)
                if ((data.Type == type) && (data.Fact == Fact.Is))
                    result.Add(data.Name);

            return result;
        }

        public Response CheckFact(string name, string type)
        {
            foreach (Data data in ListData)
            {
                if ((data.Name == name)  && (data.Fact == Fact.Is) && (data.Type == type))
                    return Response.Yes;

                if ((data.Name == name) && (data.Fact == Fact.NotIs) && (data.Type == type))
                    return Response.No;
            }

            return Response.NotFound;
        }

    }
}
