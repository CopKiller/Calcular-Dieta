using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora_de_Macros.Alimento;

namespace Calculadora_de_Macros.BancoDeDados
{
    public class ArrozCru : Nutriente
    {
        public double kcalPerGram {  get; private set; }
        public double carboidratosPerGram { get; private set; }
        public double proteinasPerGram { get; private set; }
        public double gordurasPerGram { get; private set; }
        public double fibrasPerGram { get; private set; }
        public ArrozCru(double gramas)
        {
            kcalPerGram = 3.58;
            carboidratosPerGram = 0.79;
            proteinasPerGram = 0.07;
            gordurasPerGram = 0;
            fibrasPerGram = 0.02;

            base.Kcal += kcalPerGram * gramas;
            base.Carboidratos += carboidratosPerGram * gramas;
            base.Proteinas += proteinasPerGram * gramas;
            base.Gorduras += gordurasPerGram * gramas;
            base.Fibras += fibrasPerGram * gramas;
        }
    }
}
