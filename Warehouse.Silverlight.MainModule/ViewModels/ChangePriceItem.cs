using System.Globalization;
using Microsoft.Practices.Prism.ViewModel;
using Warehouse.Silverlight.Models;

namespace Warehouse.Silverlight.MainModule.ViewModels
{
    public class ChangePriceItem : NotificationObject
    {
        private decimal newPriceOpt;
        private decimal newPriceRozn;
        private readonly string k;
        private readonly string length;

        public ChangePriceItem(Product p)
        {
            Product = p;

            k = p.K.ToString(CultureInfo.CurrentCulture);
            length = p.Length.ToString(CultureInfo.CurrentCulture);
        }

        public Product Product { get; private set; }

        public decimal NewPriceOpt
        {
            get { return newPriceOpt; }
            set
            {
                if (newPriceOpt != value)
                {
                    newPriceOpt = value;
                    RaisePropertyChanged(() => NewPriceOpt);
                }
            }
        }

        public decimal NewPriceRozn
        {
            get { return newPriceRozn; }
            set
            {
                if (newPriceRozn != value)
                {
                    newPriceRozn = value;
                    RaisePropertyChanged(() => NewPriceRozn);
                }
            }
        }

        public void Refresh(double percentage)
        {
            var a = (decimal) Product.PriceOpt;
            var x = (decimal) percentage;
            var b = a * (1 + x / 100);

            NewPriceOpt = decimal.Ceiling(b * 100) / 100;

            var priceOptStr = newPriceOpt.ToString(CultureInfo.CurrentCulture);
            NewPriceRozn = ProductExtensions.CalculatePriceRozn(priceOptStr, k, length, Product.IsSheet);
        }
    }
}
