using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiss_Levente_Varosok
{
    internal class Varos
    {
        public string VarosNeve { get; set; }
        public string OrszagNeve { get; set; }
        public double Nepesseg { get; set; }

        public Varos(string s)
        {
            var v = s.Split(';');
            VarosNeve = v[0];
            OrszagNeve = v[1];
            Nepesseg = Math.Round(double.Parse(v[2]),2);
        }

        public override string ToString()
        {
            return $"Város: {VarosNeve}  Ország: {OrszagNeve}  Nepesség: {Nepesseg} millió";
        }
    }
}
