using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRA_LFF
{
    public class Data
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public Data(string name, string type)
        {
            this.Type = type;
            this.Name = name;
        }
    }
}
