using System.Collections.Generic;

namespace RawData
{
    public class car
    {
        public string model;
        public engine engine;
        public Cargo cargo;
        public List<tyre> tyres;



        public car(string model,
        engine engine,
        Cargo cargo,
        List<tyre> tyres)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tyres = tyres;

        }
    }
}

