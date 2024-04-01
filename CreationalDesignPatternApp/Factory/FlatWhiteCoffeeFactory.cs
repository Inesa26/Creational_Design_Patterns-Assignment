using CreationalDesignPatternApp.CoffeeShop;
using CreationalDesignPatternApp.Enums;

namespace CreationalDesignPatternApp.Factory
{
    internal class FlatWhiteCoffeeFactory : CoffeeFactory
    {
        public override Coffee MakeCoffee(MilkType? milkType = null)
        {
            if (milkType is null)
            {
                throw new ArgumentNullException("Milk must be provided for FlatWhite");
            }

            FlatWhite flatWhite = FlatWhite.Create();
            flatWhite.CoffeeType = CoffeeType.Black;
            flatWhite.MilkType = milkType.Value;
            return flatWhite;
        }
    }
}
