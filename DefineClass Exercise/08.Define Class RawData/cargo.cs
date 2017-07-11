using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Cargo
    {
        private string type;
        private int weight;
       

        public Cargo(string type,int weight)
        {
            this.weight = weight;
            this.type = type;
        }
        public string Type
        {
            get { return this.type; }
        }
     
    }
}
