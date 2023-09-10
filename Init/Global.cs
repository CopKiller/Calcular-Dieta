using Calculadora_de_Macros.Alimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Macros.GlobalStatic
{
    public class Global
    {
        public List<Nutriente> alimentos { get; private set; }

        public Global()
        {
            alimentos = new List<Nutriente>();
        }

        public void AdicionarAlimento(Nutriente novoNutriente)
        {
            alimentos.Add(novoNutriente);
        }

        public double ObterSomaCalorias()
        {
            double somaCalorias = 0.0;

            foreach (Nutriente nutriente in alimentos)
            {
                somaCalorias += nutriente.Kcal;
            }

            return Math.Round(somaCalorias, 3);
        }

        public double ObterSomaCarboidratos()
        {
            double somaCarboidratos = 0.0;

            foreach (Nutriente nutriente in alimentos)
            {
                somaCarboidratos += nutriente.Carboidratos;
            }

            return Math.Round(somaCarboidratos, 3);
        }

        public double ObterSomaProteinas()
        {
            double somaProteinas = 0.0;

            foreach (Nutriente nutriente in alimentos)
            {
                somaProteinas += nutriente.Proteinas;
            }

            return Math.Round(somaProteinas, 3);
        }

        public double ObterSomaGorduras()
        {
            double somaGorduras = 0.0;

            foreach (Nutriente nutriente in alimentos)
            {
                somaGorduras += nutriente.Gorduras;
            }

            return Math.Round(somaGorduras, 3);
        }

        public double ObterSomaFibras()
        {
            double somaFibras = 0.0;

            foreach (Nutriente nutriente in alimentos)
            {
                somaFibras += nutriente.Fibras;
            }

            return Math.Round(somaFibras, 3);
        }
    }
}
