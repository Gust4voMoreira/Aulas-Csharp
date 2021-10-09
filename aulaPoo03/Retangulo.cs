using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aulaPoo03
{
    public class Retangulo
    {
        public Retangulo()
        {
            this.Altura = 0;
            this.Base = 0;
        }

        private float baseret;
        public float Base
        {
            get { return baseret; }
            set 
            { 
                if(value >= 0) baseret = value; 
                else baseret = 0;
            }
        }
        
        private float altret;
        public float Altura
        {
            get { return altret; }
            set 
            {
                if(value >= 0) altret = value; 
                else baseret = 0;
            }
        }
        
        public float Area
        {
            get { return baseret*altret; }
        }
        
        public void ExibeDados()
        {
            Console.WriteLine("Base: "+ this.Base);
            Console.WriteLine("Altura: "+ this.Altura);
            Console.WriteLine("Area: "+ this.Area);
        }
    }
}