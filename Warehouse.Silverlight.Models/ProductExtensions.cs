using System.Globalization;

namespace Warehouse.Silverlight.Models
{
    public static class ProductExtensions
    {
        public static double CalculatePriceRozn(string priceOpt, string k, string length, bool isSheet)
        {
            var _priceOpt = decimal.Parse(priceOpt);
            var _k = decimal.Parse(k);
            var rozn = _priceOpt * _k / 1000m * 1.2m;
            if (isSheet)
            {
                var _l = decimal.Parse(length);
                rozn *= _l;
            }
            return (double) decimal.Ceiling(rozn * 100) / 100;
        }

        public static double CalculatePriceRozn(this Product p)
        {
            var priceOpt = p.PriceOpt.ToString(CultureInfo.InvariantCulture);
            var k = p.K.ToString(CultureInfo.InvariantCulture);
            var length = p.Length.ToString(CultureInfo.InvariantCulture);
            return CalculatePriceRozn(priceOpt, k, length, p.IsSheet);
        }
    }
}
