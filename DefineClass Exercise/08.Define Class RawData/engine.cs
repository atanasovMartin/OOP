using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class engine
    {
        private int speed;
        private int power;

        public engine(int speed, int power)
        {
            this.power = power;
            this.speed = speed;
        }
        public int Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

    }
}
