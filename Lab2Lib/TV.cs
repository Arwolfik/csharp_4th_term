using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task2
{
    public class TV : Televisions 
    {
        private string _producingCountry; 
        public TV(string firm, int diagonal, int soundPower, string producingCountry) : base(firm, diagonal, soundPower) //конструктор
        {
            _producingCountry = producingCountry;
        }

        public string GetProducingCountry()
        {
            return _producingCountry;
        }

        public void SetProducingCountry(string producingCountry)
        {
            _producingCountry = producingCountry;
        }

        public override double QualityOfTV() 
        {
            double quality = base.QualityOfTV();
            double qualityProd;
            if (GetProducingCountry() == "Япония")
            {
                qualityProd = 2 * quality;
            }
            else if (GetProducingCountry() == "Сингапур" || GetProducingCountry() == "Корея")
            {
                qualityProd = 1.5 * quality;
            }
            else
            {
                qualityProd = quality;
            }
            return qualityProd;
        }

        public override string MakeStr() 
        {
            return base.MakeStr() + ", Страна-производитель: " + GetProducingCountry();
        }
    }

}
