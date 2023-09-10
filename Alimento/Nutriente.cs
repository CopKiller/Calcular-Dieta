using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Macros.Alimento
{
    public abstract class Nutriente
    {
        public const double JoulesPerKcal = 4.184;
        public double Kcal { get; set; }
        public double Carboidratos { get; set; }
        public double Proteinas { get; set; }
        public double Gorduras { get; set; }
        public double Fibras { get; set; }
    }
}
