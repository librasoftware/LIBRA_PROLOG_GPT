namespace LIBRA_LFF
{
    public enum Response { Yes, No, NotFound }

    public class Knowledge
    {
        public bool CaseSensitive = new bool();

        public List<Data> ListData = new List<Data>() { };
         
        public List<Equivalence> listEquivalence = new List<Equivalence>();

        public List<NeverIs> ListNeverIs = new List<NeverIs>();

        public Response CheckIs(string name, string type)
        {
            foreach (var item in ListData)
            {
                if (item.Name.Equals(name))
                {
                    if (item.Type.Equals(type))
                        return Response.Yes;
                    else
                        return Response.No;
                }
            }

            return Response.NotFound;
        }

        public List<string> Get(string name)
        {
            List<string> result = new List<string>();

            foreach (var item1 in ListData)
            {
                if (item1.Name.Equals(name))
                    result.Add(item1.Type);

                if (item1.Type.Equals(name))
                    result.Add(item1.Name);

                foreach (var item2 in listEquivalence)
                {
                    if (item2.Type1.Equals(item1.Type))
                        result.Add(item2.Type2);

                    if (item2.Type2.Equals(item1.Type))
                        result.Add(item2.Type1);
                }
            }  

            return result.Distinct().ToList();
        }
    }
}
